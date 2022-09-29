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
            this.barMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveJsonPatch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReset = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.tabEditJsonFile = new System.Windows.Forms.TabControl();
            this.tabOriginal = new System.Windows.Forms.TabPage();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.tabEdited = new System.Windows.Forms.TabPage();
            this.txtEdited = new System.Windows.Forms.TextBox();
            this.pnlPatch = new System.Windows.Forms.Panel();
            this.grpPatchFile = new System.Windows.Forms.GroupBox();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.grpPatchInfo = new System.Windows.Forms.GroupBox();
            this.lblAppSide = new System.Windows.Forms.Label();
            this.cbxAppSide = new System.Windows.Forms.ComboBox();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtAssetPath = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lblAssetPath = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.barMenu.SuspendLayout();
            this.pnlFiles.SuspendLayout();
            this.tabEditJsonFile.SuspendLayout();
            this.tabOriginal.SuspendLayout();
            this.tabEdited.SuspendLayout();
            this.pnlPatch.SuspendLayout();
            this.grpPatchFile.SuspendLayout();
            this.grpPatchInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // barMenu
            // 
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(884, 24);
            this.barMenu.TabIndex = 0;
            this.barMenu.Text = "Menu Bar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadJsonFile,
            this.btnSaveJsonPatch,
            this.toolStripSeparator1,
            this.btnReset});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // btnLoadJsonFile
            // 
            this.btnLoadJsonFile.Name = "btnLoadJsonFile";
            this.btnLoadJsonFile.Size = new System.Drawing.Size(183, 22);
            this.btnLoadJsonFile.Text = "&Load JSON Asset File";
            this.btnLoadJsonFile.Click += new System.EventHandler(this.btnLoadJsonFile_Click);
            // 
            // btnSaveJsonPatch
            // 
            this.btnSaveJsonPatch.Enabled = false;
            this.btnSaveJsonPatch.Name = "btnSaveJsonPatch";
            this.btnSaveJsonPatch.Size = new System.Drawing.Size(183, 22);
            this.btnSaveJsonPatch.Text = "&Save JSON Patch";
            this.btnSaveJsonPatch.Click += new System.EventHandler(this.btnSaveJsonPatch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(183, 22);
            this.btnReset.Text = "&Reset Patch";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlFiles
            // 
            this.pnlFiles.Controls.Add(this.tabEditJsonFile);
            this.pnlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiles.Location = new System.Drawing.Point(0, 24);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(884, 437);
            this.pnlFiles.TabIndex = 4;
            // 
            // tabEditJsonFile
            // 
            this.tabEditJsonFile.Controls.Add(this.tabOriginal);
            this.tabEditJsonFile.Controls.Add(this.tabEdited);
            this.tabEditJsonFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEditJsonFile.Location = new System.Drawing.Point(0, 0);
            this.tabEditJsonFile.Name = "tabEditJsonFile";
            this.tabEditJsonFile.SelectedIndex = 0;
            this.tabEditJsonFile.Size = new System.Drawing.Size(884, 437);
            this.tabEditJsonFile.TabIndex = 0;
            // 
            // tabOriginal
            // 
            this.tabOriginal.Controls.Add(this.txtOriginal);
            this.tabOriginal.Location = new System.Drawing.Point(4, 24);
            this.tabOriginal.Name = "tabOriginal";
            this.tabOriginal.Padding = new System.Windows.Forms.Padding(3);
            this.tabOriginal.Size = new System.Drawing.Size(876, 409);
            this.tabOriginal.TabIndex = 0;
            this.tabOriginal.Text = "Original File";
            this.tabOriginal.UseVisualStyleBackColor = true;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOriginal.Location = new System.Drawing.Point(3, 3);
            this.txtOriginal.MaxLength = 2147483647;
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ReadOnly = true;
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginal.Size = new System.Drawing.Size(870, 403);
            this.txtOriginal.TabIndex = 0;
            // 
            // tabEdited
            // 
            this.tabEdited.Controls.Add(this.txtEdited);
            this.tabEdited.Location = new System.Drawing.Point(4, 24);
            this.tabEdited.Name = "tabEdited";
            this.tabEdited.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdited.Size = new System.Drawing.Size(876, 409);
            this.tabEdited.TabIndex = 1;
            this.tabEdited.Text = "Edited File";
            this.tabEdited.UseVisualStyleBackColor = true;
            // 
            // txtEdited
            // 
            this.txtEdited.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEdited.Location = new System.Drawing.Point(3, 3);
            this.txtEdited.MaxLength = 2147483647;
            this.txtEdited.Multiline = true;
            this.txtEdited.Name = "txtEdited";
            this.txtEdited.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEdited.Size = new System.Drawing.Size(870, 403);
            this.txtEdited.TabIndex = 0;
            this.txtEdited.TextChanged += new System.EventHandler(this.txtEdited_TextChanged);
            // 
            // pnlPatch
            // 
            this.pnlPatch.Controls.Add(this.grpPatchFile);
            this.pnlPatch.Controls.Add(this.grpPatchInfo);
            this.pnlPatch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPatch.Location = new System.Drawing.Point(587, 24);
            this.pnlPatch.Name = "pnlPatch";
            this.pnlPatch.Size = new System.Drawing.Size(297, 437);
            this.pnlPatch.TabIndex = 5;
            // 
            // grpPatchFile
            // 
            this.grpPatchFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatchFile.Controls.Add(this.txtPatch);
            this.grpPatchFile.Location = new System.Drawing.Point(3, 188);
            this.grpPatchFile.Name = "grpPatchFile";
            this.grpPatchFile.Size = new System.Drawing.Size(290, 239);
            this.grpPatchFile.TabIndex = 1;
            this.grpPatchFile.TabStop = false;
            this.grpPatchFile.Text = "Patch File";
            // 
            // txtPatch
            // 
            this.txtPatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatch.Location = new System.Drawing.Point(3, 19);
            this.txtPatch.MaxLength = 2147483647;
            this.txtPatch.Multiline = true;
            this.txtPatch.Name = "txtPatch";
            this.txtPatch.ReadOnly = true;
            this.txtPatch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPatch.Size = new System.Drawing.Size(284, 217);
            this.txtPatch.TabIndex = 0;
            // 
            // grpPatchInfo
            // 
            this.grpPatchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatchInfo.Controls.Add(this.lblAppSide);
            this.grpPatchInfo.Controls.Add(this.cbxAppSide);
            this.grpPatchInfo.Controls.Add(this.lblDirectory);
            this.grpPatchInfo.Controls.Add(this.lblFileName);
            this.grpPatchInfo.Controls.Add(this.txtAssetPath);
            this.grpPatchInfo.Controls.Add(this.txtFileName);
            this.grpPatchInfo.Controls.Add(this.txtDirectory);
            this.grpPatchInfo.Controls.Add(this.txtDomain);
            this.grpPatchInfo.Controls.Add(this.lblAssetPath);
            this.grpPatchInfo.Controls.Add(this.lblDomain);
            this.grpPatchInfo.Location = new System.Drawing.Point(3, 3);
            this.grpPatchInfo.Name = "grpPatchInfo";
            this.grpPatchInfo.Size = new System.Drawing.Size(290, 179);
            this.grpPatchInfo.TabIndex = 0;
            this.grpPatchInfo.TabStop = false;
            this.grpPatchInfo.Text = "Patch Info";
            // 
            // lblAppSide
            // 
            this.lblAppSide.AutoSize = true;
            this.lblAppSide.Location = new System.Drawing.Point(14, 144);
            this.lblAppSide.Name = "lblAppSide";
            this.lblAppSide.Size = new System.Drawing.Size(57, 15);
            this.lblAppSide.TabIndex = 9;
            this.lblAppSide.Text = "App Side:";
            // 
            // cbxAppSide
            // 
            this.cbxAppSide.FormattingEnabled = true;
            this.cbxAppSide.Items.AddRange(new object[] {
            "Client",
            "Server",
            "Universal"});
            this.cbxAppSide.Location = new System.Drawing.Point(77, 141);
            this.cbxAppSide.Name = "cbxAppSide";
            this.cbxAppSide.Size = new System.Drawing.Size(205, 23);
            this.cbxAppSide.TabIndex = 8;
            this.cbxAppSide.SelectedIndexChanged += new System.EventHandler(this.cbxAppSide_SelectedIndexChanged);
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(13, 57);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(58, 15);
            this.lblDirectory.TabIndex = 7;
            this.lblDirectory.Text = "Directory:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(8, 86);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(63, 15);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "File Name:";
            // 
            // txtAssetPath
            // 
            this.txtAssetPath.Location = new System.Drawing.Point(77, 112);
            this.txtAssetPath.Name = "txtAssetPath";
            this.txtAssetPath.ReadOnly = true;
            this.txtAssetPath.Size = new System.Drawing.Size(205, 23);
            this.txtAssetPath.TabIndex = 5;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(77, 83);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(205, 23);
            this.txtFileName.TabIndex = 4;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(77, 54);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(205, 23);
            this.txtDirectory.TabIndex = 3;
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(77, 25);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.ReadOnly = true;
            this.txtDomain.Size = new System.Drawing.Size(205, 23);
            this.txtDomain.TabIndex = 2;
            this.txtDomain.TextChanged += new System.EventHandler(this.txtDomain_TextChanged);
            // 
            // lblAssetPath
            // 
            this.lblAssetPath.AutoSize = true;
            this.lblAssetPath.Location = new System.Drawing.Point(6, 115);
            this.lblAssetPath.Name = "lblAssetPath";
            this.lblAssetPath.Size = new System.Drawing.Size(65, 15);
            this.lblAssetPath.TabIndex = 1;
            this.lblAssetPath.Text = "Asset Path:";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(19, 28);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(52, 15);
            this.lblDomain.TabIndex = 0;
            this.lblDomain.Text = "Domain:";
            // 
            // FrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pnlPatch);
            this.Controls.Add(this.pnlFiles);
            this.Controls.Add(this.barMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barMenu;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FrontEnd";
            this.Text = "JSON Patch File Maker";
            this.barMenu.ResumeLayout(false);
            this.barMenu.PerformLayout();
            this.pnlFiles.ResumeLayout(false);
            this.tabEditJsonFile.ResumeLayout(false);
            this.tabOriginal.ResumeLayout(false);
            this.tabOriginal.PerformLayout();
            this.tabEdited.ResumeLayout(false);
            this.tabEdited.PerformLayout();
            this.pnlPatch.ResumeLayout(false);
            this.grpPatchFile.ResumeLayout(false);
            this.grpPatchFile.PerformLayout();
            this.grpPatchInfo.ResumeLayout(false);
            this.grpPatchInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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