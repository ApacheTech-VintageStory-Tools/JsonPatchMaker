namespace JsonPatchMaker.WinFormsApp.Forms
{
    partial class FrontEnd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontEnd));
            barMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            btnLoadJsonFile = new ToolStripMenuItem();
            btnSaveJsonPatch = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnReset = new ToolStripMenuItem();
            pnlFiles = new Panel();
            tabEditJsonFile = new TabControl();
            tabOriginal = new TabPage();
            txtOriginal = new TextBox();
            tabEdited = new TabPage();
            txtEdited = new TextBox();
            pnlPatch = new Panel();
            grpPatchFile = new GroupBox();
            txtPatch = new TextBox();
            grpPatchInfo = new GroupBox();
            lblAppSide = new Label();
            cbxAppSide = new ComboBox();
            lblDirectory = new Label();
            lblFileName = new Label();
            txtAssetPath = new TextBox();
            txtFileName = new TextBox();
            txtDirectory = new TextBox();
            txtDomain = new TextBox();
            lblAssetPath = new Label();
            lblDomain = new Label();
            barMenu.SuspendLayout();
            pnlFiles.SuspendLayout();
            tabEditJsonFile.SuspendLayout();
            tabOriginal.SuspendLayout();
            tabEdited.SuspendLayout();
            pnlPatch.SuspendLayout();
            grpPatchFile.SuspendLayout();
            grpPatchInfo.SuspendLayout();
            SuspendLayout();
            // 
            // barMenu
            // 
            barMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            barMenu.Location = new Point(0, 0);
            barMenu.Name = "barMenu";
            barMenu.Size = new Size(884, 24);
            barMenu.TabIndex = 0;
            barMenu.Text = "Menu Bar";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnLoadJsonFile, btnSaveJsonPatch, toolStripSeparator1, btnReset });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // btnLoadJsonFile
            // 
            btnLoadJsonFile.Name = "btnLoadJsonFile";
            btnLoadJsonFile.Size = new Size(183, 22);
            btnLoadJsonFile.Text = "&Load JSON Asset File";
            btnLoadJsonFile.Click += btnLoadJsonFile_Click;
            // 
            // btnSaveJsonPatch
            // 
            btnSaveJsonPatch.Enabled = false;
            btnSaveJsonPatch.Name = "btnSaveJsonPatch";
            btnSaveJsonPatch.Size = new Size(183, 22);
            btnSaveJsonPatch.Text = "&Save JSON Patch";
            btnSaveJsonPatch.Click += btnSaveJsonPatch_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(180, 6);
            // 
            // btnReset
            // 
            btnReset.Enabled = false;
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(183, 22);
            btnReset.Text = "&Reset Patch";
            btnReset.Click += btnReset_Click;
            // 
            // pnlFiles
            // 
            pnlFiles.Controls.Add(tabEditJsonFile);
            pnlFiles.Dock = DockStyle.Fill;
            pnlFiles.Location = new Point(0, 24);
            pnlFiles.Name = "pnlFiles";
            pnlFiles.Size = new Size(884, 437);
            pnlFiles.TabIndex = 4;
            // 
            // tabEditJsonFile
            // 
            tabEditJsonFile.Controls.Add(tabOriginal);
            tabEditJsonFile.Controls.Add(tabEdited);
            tabEditJsonFile.Dock = DockStyle.Fill;
            tabEditJsonFile.Location = new Point(0, 0);
            tabEditJsonFile.Name = "tabEditJsonFile";
            tabEditJsonFile.SelectedIndex = 0;
            tabEditJsonFile.Size = new Size(884, 437);
            tabEditJsonFile.TabIndex = 0;
            // 
            // tabOriginal
            // 
            tabOriginal.Controls.Add(txtOriginal);
            tabOriginal.Location = new Point(4, 24);
            tabOriginal.Name = "tabOriginal";
            tabOriginal.Padding = new Padding(3);
            tabOriginal.Size = new Size(876, 409);
            tabOriginal.TabIndex = 0;
            tabOriginal.Text = "Original File";
            tabOriginal.UseVisualStyleBackColor = true;
            // 
            // txtOriginal
            // 
            txtOriginal.Dock = DockStyle.Fill;
            txtOriginal.Location = new Point(3, 3);
            txtOriginal.MaxLength = int.MaxValue;
            txtOriginal.Multiline = true;
            txtOriginal.Name = "txtOriginal";
            txtOriginal.ReadOnly = true;
            txtOriginal.ScrollBars = ScrollBars.Both;
            txtOriginal.Size = new Size(870, 403);
            txtOriginal.TabIndex = 0;
            // 
            // tabEdited
            // 
            tabEdited.Controls.Add(txtEdited);
            tabEdited.Location = new Point(4, 24);
            tabEdited.Name = "tabEdited";
            tabEdited.Padding = new Padding(3);
            tabEdited.Size = new Size(876, 409);
            tabEdited.TabIndex = 1;
            tabEdited.Text = "Edited File";
            tabEdited.UseVisualStyleBackColor = true;
            // 
            // txtEdited
            // 
            txtEdited.Dock = DockStyle.Fill;
            txtEdited.Location = new Point(3, 3);
            txtEdited.MaxLength = int.MaxValue;
            txtEdited.Multiline = true;
            txtEdited.Name = "txtEdited";
            txtEdited.ScrollBars = ScrollBars.Both;
            txtEdited.Size = new Size(870, 403);
            txtEdited.TabIndex = 0;
            txtEdited.TextChanged += txtEdited_TextChanged;
            // 
            // pnlPatch
            // 
            pnlPatch.Controls.Add(grpPatchFile);
            pnlPatch.Controls.Add(grpPatchInfo);
            pnlPatch.Dock = DockStyle.Right;
            pnlPatch.Location = new Point(587, 24);
            pnlPatch.Name = "pnlPatch";
            pnlPatch.Size = new Size(297, 437);
            pnlPatch.TabIndex = 5;
            // 
            // grpPatchFile
            // 
            grpPatchFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpPatchFile.Controls.Add(txtPatch);
            grpPatchFile.Location = new Point(3, 188);
            grpPatchFile.Name = "grpPatchFile";
            grpPatchFile.Size = new Size(290, 239);
            grpPatchFile.TabIndex = 1;
            grpPatchFile.TabStop = false;
            grpPatchFile.Text = "Patch File";
            // 
            // txtPatch
            // 
            txtPatch.Dock = DockStyle.Fill;
            txtPatch.Location = new Point(3, 19);
            txtPatch.MaxLength = int.MaxValue;
            txtPatch.Multiline = true;
            txtPatch.Name = "txtPatch";
            txtPatch.ReadOnly = true;
            txtPatch.ScrollBars = ScrollBars.Both;
            txtPatch.Size = new Size(284, 217);
            txtPatch.TabIndex = 0;
            // 
            // grpPatchInfo
            // 
            grpPatchInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPatchInfo.Controls.Add(lblAppSide);
            grpPatchInfo.Controls.Add(cbxAppSide);
            grpPatchInfo.Controls.Add(lblDirectory);
            grpPatchInfo.Controls.Add(lblFileName);
            grpPatchInfo.Controls.Add(txtAssetPath);
            grpPatchInfo.Controls.Add(txtFileName);
            grpPatchInfo.Controls.Add(txtDirectory);
            grpPatchInfo.Controls.Add(txtDomain);
            grpPatchInfo.Controls.Add(lblAssetPath);
            grpPatchInfo.Controls.Add(lblDomain);
            grpPatchInfo.Location = new Point(3, 3);
            grpPatchInfo.Name = "grpPatchInfo";
            grpPatchInfo.Size = new Size(290, 179);
            grpPatchInfo.TabIndex = 0;
            grpPatchInfo.TabStop = false;
            grpPatchInfo.Text = "Patch Info";
            // 
            // lblAppSide
            // 
            lblAppSide.AutoSize = true;
            lblAppSide.Location = new Point(14, 144);
            lblAppSide.Name = "lblAppSide";
            lblAppSide.Size = new Size(57, 15);
            lblAppSide.TabIndex = 9;
            lblAppSide.Text = "App Side:";
            // 
            // cbxAppSide
            // 
            cbxAppSide.FormattingEnabled = true;
            cbxAppSide.Items.AddRange(new object[] { "Client", "Server", "Universal" });
            cbxAppSide.Location = new Point(77, 141);
            cbxAppSide.Name = "cbxAppSide";
            cbxAppSide.Size = new Size(205, 23);
            cbxAppSide.TabIndex = 8;
            cbxAppSide.SelectedIndexChanged += cbxAppSide_SelectedIndexChanged;
            // 
            // lblDirectory
            // 
            lblDirectory.AutoSize = true;
            lblDirectory.Location = new Point(13, 57);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(58, 15);
            lblDirectory.TabIndex = 7;
            lblDirectory.Text = "Directory:";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(8, 86);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(63, 15);
            lblFileName.TabIndex = 6;
            lblFileName.Text = "File Name:";
            // 
            // txtAssetPath
            // 
            txtAssetPath.Location = new Point(77, 112);
            txtAssetPath.Name = "txtAssetPath";
            txtAssetPath.ReadOnly = true;
            txtAssetPath.Size = new Size(205, 23);
            txtAssetPath.TabIndex = 5;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(77, 83);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(205, 23);
            txtFileName.TabIndex = 4;
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new Point(77, 54);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.ReadOnly = true;
            txtDirectory.Size = new Size(205, 23);
            txtDirectory.TabIndex = 3;
            txtDirectory.TextChanged += txtDirectory_TextChanged;
            // 
            // txtDomain
            // 
            txtDomain.Location = new Point(77, 25);
            txtDomain.Name = "txtDomain";
            txtDomain.ReadOnly = true;
            txtDomain.Size = new Size(205, 23);
            txtDomain.TabIndex = 2;
            txtDomain.TextChanged += txtDomain_TextChanged;
            // 
            // lblAssetPath
            // 
            lblAssetPath.AutoSize = true;
            lblAssetPath.Location = new Point(6, 115);
            lblAssetPath.Name = "lblAssetPath";
            lblAssetPath.Size = new Size(65, 15);
            lblAssetPath.TabIndex = 1;
            lblAssetPath.Text = "Asset Path:";
            // 
            // lblDomain
            // 
            lblDomain.AutoSize = true;
            lblDomain.Location = new Point(19, 28);
            lblDomain.Name = "lblDomain";
            lblDomain.Size = new Size(52, 15);
            lblDomain.TabIndex = 0;
            lblDomain.Text = "Domain:";
            // 
            // FrontEnd
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(pnlPatch);
            Controls.Add(pnlFiles);
            Controls.Add(barMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = barMenu;
            MinimumSize = new Size(900, 500);
            Name = "FrontEnd";
            Text = "JSON Patch File Maker";
            DragDrop += FrontEnd_DragDrop;
            DragEnter += FrontEnd_DragEnter;
            barMenu.ResumeLayout(false);
            barMenu.PerformLayout();
            pnlFiles.ResumeLayout(false);
            tabEditJsonFile.ResumeLayout(false);
            tabOriginal.ResumeLayout(false);
            tabOriginal.PerformLayout();
            tabEdited.ResumeLayout(false);
            tabEdited.PerformLayout();
            pnlPatch.ResumeLayout(false);
            grpPatchFile.ResumeLayout(false);
            grpPatchFile.PerformLayout();
            grpPatchInfo.ResumeLayout(false);
            grpPatchInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip barMenu;
        private Panel pnlFiles;
        private TabControl tabEditJsonFile;
        private TabPage tabOriginal;
        private TabPage tabEdited;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem btnLoadJsonFile;
        private ToolStripMenuItem btnSaveJsonPatch;
        private TextBox txtOriginal;
        private TextBox txtEdited;
        private Panel pnlPatch;
        private GroupBox grpPatchFile;
        private TextBox txtPatch;
        private GroupBox grpPatchInfo;
        private Label lblDirectory;
        private Label lblFileName;
        private TextBox txtAssetPath;
        private TextBox txtFileName;
        private TextBox txtDirectory;
        private TextBox txtDomain;
        private Label lblAssetPath;
        private Label lblDomain;
        private Label lblAppSide;
        private ComboBox cbxAppSide;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem btnReset;
    }
}