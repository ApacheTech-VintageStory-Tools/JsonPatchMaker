using System.Diagnostics.CodeAnalysis;
using JsonPatchMaker.Core.DataStructures;

namespace JsonPatchMaker.WinFormsApp
{
    [SuppressMessage("Naming Violations", "IDE1006", Justification = "Hungarian Notation for WinForms Controls.")]
    public partial class FrontEnd : Form
    {
        private readonly WinFormsAdapter _adapter;

        public FrontEnd()
        {
            InitializeComponent();
            _adapter = new WinFormsAdapter(this);
        }

        private void btnLoadJsonFile_Click(object sender, EventArgs e) => _adapter.LoadJsonFromFile();
        private void btnSaveJsonPatch_Click(object sender, EventArgs e) => _adapter.SavePatchToFile();
        private void txtEdited_TextChanged(object sender, EventArgs e) => _adapter.RefreshPatch();
        private void btnClient_Click(object sender, EventArgs e) => _adapter.ChangeAppSides(sender, AppSide.Client);
        private void btnServer_Click(object sender, EventArgs e) => _adapter.ChangeAppSides(sender, AppSide.Server);
        private void btnUniversal_Click(object sender, EventArgs e) => _adapter.ChangeAppSides(sender, AppSide.Universal);
        private void btnReset_Click(object sender, EventArgs e) => _adapter.ResetPatch();
    }
}