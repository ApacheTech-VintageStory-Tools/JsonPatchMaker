using System.ComponentModel;
using JsonPatchMaker.Core;
using JsonPatchMaker.Core.DataStructures;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonPatchMaker.WinFormsApp
{
    internal class WinFormsAdapter
    {
        private readonly FrontEnd _frontEnd;
        private readonly ToolStripMenuItem _mnuAppSide;

        private FileInfo? _jsonFile;
        private string _originalJson = string.Empty;
        private AppSide _side = AppSide.Universal;

        internal WinFormsAdapter(FrontEnd frontEnd)
        {
            _frontEnd = frontEnd;
            _mnuAppSide = (ToolStripMenuItem)GetControl<MenuStrip>("barMenu")!.Items[^1];
        }

        private T? GetControl<T>(string controlName) where T : Component
        {
            var control = _frontEnd.Controls.Find(controlName, true).FirstOrDefault();
            return control as T;
        }

        internal void ResetPatch()
        {
            GetControl<TextBox>("txtOriginal")!.Text = _originalJson;
            GetControl<TextBox>("txtEdited")!.Text = _originalJson;
            ChangeAppSides(GetControl<Control>("btnUniversal")!, AppSide.Universal);
        }

        internal void SavePatchToFile()
        {
            var sfd = new SaveFileDialog
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                DefaultExt = "json",
                FileName =
                    $"{Path.GetFileNameWithoutExtension(_jsonFile!.FullName)}_{_side.ToString().ToLowerInvariant()}_patches.json",
                Filter = @"JSON Files (*.json)|*.json",
                Title = @"Save JSON Patch File"
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
                Filter = @"JSON Files (*.json)|*.json",
                Title = @"Open JSON File",
            };

            var gameDir = Environment.GetEnvironmentVariable("VINTAGE_STORY");
            if (gameDir is not null) ofd.InitialDirectory = Path.Combine(gameDir, "assets");
            if (ofd.ShowDialog() != DialogResult.OK) return;
            _jsonFile = new FileInfo(ofd.FileName);

            _originalJson = JToken
                .Parse(File.ReadAllText(_jsonFile.FullName))
                .ToString(Formatting.Indented);

            GetControl<TextBox>("txtOriginal")!.Text = _originalJson;
            GetControl<TextBox>("txtEdited")!.Text = _originalJson;
        }

        internal void ChangeAppSides(object sender, AppSide side)
        {
            _side = side;
            foreach (var button in _mnuAppSide.DropDownItems.OfType<ToolStripMenuItem>())
            {
                button.Checked = button.Equals(sender);
            }
            RefreshPatch();
        }

        internal void RefreshPatch()
        {
            if (_jsonFile is null) return;
            var editedJson = GetControl<TextBox>("txtEdited")!.Text;
            var patch = Patcher.GeneratePatch(_originalJson, editedJson, _jsonFile!.FullName, _side);
            var json = patch.ToString(Formatting.Indented);
            GetControl<TextBox>("txtPatch")!.Text = json;
        }
    }
}