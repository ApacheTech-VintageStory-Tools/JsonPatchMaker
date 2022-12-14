using System.Diagnostics.CodeAnalysis;
using JsonPatchMaker.Core.DataStructures;

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

        private void cbxAppSide_SelectedIndexChanged(object sender, EventArgs e) => _adapter?.ChangeAppSides(cbxAppSide.SelectedIndex);
    }
}