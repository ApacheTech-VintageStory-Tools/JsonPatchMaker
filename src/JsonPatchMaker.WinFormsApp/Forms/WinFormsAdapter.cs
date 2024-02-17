using System.ComponentModel;
using JsonPatchMaker.Core;
using JsonPatchMaker.Core.DataStructures;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonPatchMaker.WinFormsApp.Forms
{
    /// <summary>
    ///     Code-Behind / Adapter Layer for the WinForms APL.
    /// </summary>
    internal class WinFormsAdapter
    {
        private readonly FrontEnd _frontEnd;
        private readonly ToolStripMenuItem _mnuFile;

        private string _originalJson = string.Empty;
        private AppSide _side = AppSide.Universal;
        private AssetFile? _originalFile;

        /// <summary>
        /// Initialises a new instance of the <see cref="WinFormsAdapter"/> class.
        /// </summary>
        /// <param name="frontEnd">The front end.</param>
        internal WinFormsAdapter(FrontEnd frontEnd)
        {
            _frontEnd = frontEnd;
            _mnuFile = (ToolStripMenuItem)GetControl<MenuStrip>("barMenu")!.Items[0];
        }

        internal void ResetPatch()
        {
            GetControl<TextBox>("txtOriginal")!.Text = _originalJson;
            GetControl<TextBox>("txtEdited")!.Text = _originalJson;
            GetControl<ComboBox>("cbxAppSide")!.SelectedIndex = 2;

            if (!_originalFile!.IsGameAsset)
            {
                GetControl<TextBox>("txtDomain")!.ReadOnly = false;
                GetControl<TextBox>("txtDirectory")!.ReadOnly = false;
            }

            GetControl<TextBox>("txtDomain")!.Text = _originalFile.Domain;
            GetControl<TextBox>("txtDirectory")!.Text = _originalFile.Directory;
            GetControl<TextBox>("txtFileName")!.Text = _originalFile.File.Name;
            GetControl<TextBox>("txtAssetPath")!.Text = _originalFile.ToString();

            foreach (ToolStripItem menuButton in _mnuFile.DropDown.Items)
            {
                menuButton.Enabled = true;
            }
        }

        internal void SavePatchToFile()
        {
            var sfd = new SaveFileDialog
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                DefaultExt = "json",
                FileName =
                    $"{Path.GetFileNameWithoutExtension(_originalFile!.File.FullName)}_{_side.ToString().ToLowerInvariant()}_patches.json",
                Filter = "JSON Files (*.json)|*.json",
                Title = "Save JSON Patch File"
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(sfd.FileName, GetControl<TextBox>("txtPatch")!.Text);
        }

        internal void LoadJsonFromFile()
        {
            var ofd = new OpenFileDialog
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "json",
                FileName = "Select a JSON asset file...",
                Filter = "JSON Files (*.json)|*.json",
                Title = "Open JSON File"
            };

            var gameDir = Environment.GetEnvironmentVariable("VINTAGE_STORY");
            if (gameDir is not null) ofd.InitialDirectory = Path.Combine(gameDir, "assets");
            if (ofd.ShowDialog() != DialogResult.OK) return;
            LoadFile(new FileInfo(ofd.FileName));
        }

        internal void LoadFile(FileInfo file)
        {
            try
            {
                _originalFile = AssetFile.FromFileInfo(file);
                _originalJson = JToken
                    .Parse(File.ReadAllText(_originalFile.File.FullName))
                    .ToString(Formatting.Indented);

                ResetPatch();
            }
            catch
            {
                MessageBox.Show("An error occured while loading the file.", "JSON Patch Maker.");
            }
        }

        internal void UpdateAssetDomain(string domain)
        {
            _originalFile!.Domain = domain;
            GetControl<TextBox>("txtAssetPath")!.Text = _originalFile.ToString();
            RefreshPatch();
        }

        internal void UpdateAssetDirectory(string directory)
        {
            _originalFile!.Directory = directory;
            GetControl<TextBox>("txtAssetPath")!.Text = _originalFile.ToString();
            RefreshPatch();
        }

        internal void ChangeAppSides(int side)
        {
            _side = (AppSide)side;
            RefreshPatch();
        }

        internal void RefreshPatch()
        {
            if (_originalFile is null) return;
            var editedJson = GetControl<TextBox>("txtEdited")!.Text;
            var patch = Patcher.GeneratePatch(_originalFile, editedJson, _side);
            var json = patch.ToString(Formatting.Indented);
            GetControl<TextBox>("txtPatch")!.Text = json;
        }

        private T? GetControl<T>(string controlName) where T : Component
        {
            var control = _frontEnd.Controls.Find(controlName, true).FirstOrDefault();
            return control as T;
        }
    }
}