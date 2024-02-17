using System.Diagnostics.CodeAnalysis;

namespace JsonPatchMaker.WinFormsApp.Forms
{
    /// <summary>
    ///     WinForms APL for the JSON Patch Maker Library.
    /// </summary>
    /// <seealso cref="Form" />
    [SuppressMessage("Naming Violations", "IDE1006", Justification = "Hungarian Notation for WinForms Controls.")]
    internal partial class FrontEnd : Form
    {
        private readonly WinFormsAdapter _adapter;

        /// <summary>
        ///     Initialises a new instance of the <see cref="FrontEnd"/> class.
        /// </summary>
        internal FrontEnd()
        {
            InitializeComponent();
            _adapter = new WinFormsAdapter(this);
            cbxAppSide.SelectedIndex = 2;
        }

        /// <summary>
        ///     Handles the Click event of the btnLoadJsonFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLoadJsonFile_Click(object sender, EventArgs e) => _adapter.LoadJsonFromFile();

        /// <summary>
        ///     Handles the Click event of the btnSaveJsonPatch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSaveJsonPatch_Click(object sender, EventArgs e) => _adapter.SavePatchToFile();

        /// <summary>
        ///     Handles the TextChanged event of the txtEdited control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtEdited_TextChanged(object sender, EventArgs e) => _adapter.RefreshPatch();

        /// <summary>
        ///     Handles the Click event of the btnReset control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnReset_Click(object sender, EventArgs e) => _adapter.ResetPatch();

        /// <summary>
        ///     Handles the TextChanged event of the txtDomain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtDomain_TextChanged(object sender, EventArgs e) => _adapter.UpdateAssetDomain(txtDomain.Text);

        /// <summary>
        ///     Handles the TextChanged event of the txtDirectory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtDirectory_TextChanged(object sender, EventArgs e) => _adapter.UpdateAssetDirectory(txtDirectory.Text);

        private void cbxAppSide_SelectedIndexChanged(object sender, EventArgs e) => _adapter.ChangeAppSides(cbxAppSide.SelectedIndex);

        private void FrontEnd_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) != true) return;
            e.Effect = DragDropEffects.Copy;
        }

        private void FrontEnd_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data?.GetData(DataFormats.FileDrop) is not string[] files)
            {
                MessageBox.Show("Only JSON files can be loaded by this application.", "JSON Patch Maker", MessageBoxButtons.OK);
                return;
            }

            if (files.Length > 1)
            {
                MessageBox.Show("Can only edit one file a time.", "JSON Patch Maker", MessageBoxButtons.OK);
                return;
            }

            var file = new FileInfo(files[0]);
            if (!file.Exists)
            {
                MessageBox.Show("File could not be loaded.", "JSON Patch Maker", MessageBoxButtons.OK);
                return;
            }

            if (!file.Extension.EndsWith("json"))
            {
                MessageBox.Show("Only JSON files can be loaded by this application.", "JSON Patch Maker", MessageBoxButtons.OK);
                return;
            }

            var rootDirectory = Environment.GetEnvironmentVariable("VINTAGE_STORY");
            if (rootDirectory is null)
            {
                MessageBox.Show("Environment variable 'VINTAGE_STORY' is not set.", "JSON Patch Maker", MessageBoxButtons.OK);
                return;
            }

            if (!file.FullName.StartsWith(rootDirectory))
            {
                MessageBox.Show("Only vanilla asset files can be loaded with this application.", "JSON Patch Maker", MessageBoxButtons.OK);
                return;
            }

            _adapter.LoadFile(file);
        }
    }
}