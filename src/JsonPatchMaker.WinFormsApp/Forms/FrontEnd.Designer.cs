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
            this.mnuAppSide = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClient = new System.Windows.Forms.ToolStripMenuItem();
            this.btnServer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUniversal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReset = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.tabEditJsonFile = new System.Windows.Forms.TabControl();
            this.tabOriginal = new System.Windows.Forms.TabPage();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.tabEdited = new System.Windows.Forms.TabPage();
            this.txtEdited = new System.Windows.Forms.TextBox();
            this.tabPatch = new System.Windows.Forms.TabPage();
            this.barMenu.SuspendLayout();
            this.pnlFiles.SuspendLayout();
            this.tabEditJsonFile.SuspendLayout();
            this.tabOriginal.SuspendLayout();
            this.tabEdited.SuspendLayout();
            this.tabPatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // barMenu
            // 
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuAppSide});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(584, 24);
            this.barMenu.TabIndex = 0;
            this.barMenu.Text = "Menu Bar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadJsonFile,
            this.btnSaveJsonPatch});
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
            this.btnSaveJsonPatch.Name = "btnSaveJsonPatch";
            this.btnSaveJsonPatch.Size = new System.Drawing.Size(183, 22);
            this.btnSaveJsonPatch.Text = "&Save JSON Patch";
            this.btnSaveJsonPatch.Click += new System.EventHandler(this.btnSaveJsonPatch_Click);
            // 
            // mnuAppSide
            // 
            this.mnuAppSide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClient,
            this.btnServer,
            this.btnUniversal,
            this.toolStripSeparator1,
            this.btnReset});
            this.mnuAppSide.Name = "mnuAppSide";
            this.mnuAppSide.Size = new System.Drawing.Size(49, 20);
            this.mnuAppSide.Text = "&Patch";
            // 
            // btnClient
            // 
            this.btnClient.CheckOnClick = true;
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(135, 22);
            this.btnClient.Tag = "AppSide";
            this.btnClient.Text = "&Client";
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnServer
            // 
            this.btnServer.CheckOnClick = true;
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(135, 22);
            this.btnServer.Tag = "AppSide";
            this.btnServer.Text = "&Server";
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnUniversal
            // 
            this.btnUniversal.Checked = true;
            this.btnUniversal.CheckOnClick = true;
            this.btnUniversal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnUniversal.Name = "btnUniversal";
            this.btnUniversal.Size = new System.Drawing.Size(135, 22);
            this.btnUniversal.Tag = "AppSide";
            this.btnUniversal.Text = "&Universal";
            this.btnUniversal.Click += new System.EventHandler(this.btnUniversal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // btnReset
            // 
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 22);
            this.btnReset.Text = "&Reset Patch";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtPatch
            // 
            this.txtPatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatch.Location = new System.Drawing.Point(3, 3);
            this.txtPatch.MaxLength = 2147483647;
            this.txtPatch.Multiline = true;
            this.txtPatch.Name = "txtPatch";
            this.txtPatch.ReadOnly = true;
            this.txtPatch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPatch.Size = new System.Drawing.Size(570, 353);
            this.txtPatch.TabIndex = 0;
            // 
            // pnlFiles
            // 
            this.pnlFiles.Controls.Add(this.tabEditJsonFile);
            this.pnlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiles.Location = new System.Drawing.Point(0, 24);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(584, 387);
            this.pnlFiles.TabIndex = 4;
            // 
            // tabEditJsonFile
            // 
            this.tabEditJsonFile.Controls.Add(this.tabOriginal);
            this.tabEditJsonFile.Controls.Add(this.tabEdited);
            this.tabEditJsonFile.Controls.Add(this.tabPatch);
            this.tabEditJsonFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEditJsonFile.Location = new System.Drawing.Point(0, 0);
            this.tabEditJsonFile.Name = "tabEditJsonFile";
            this.tabEditJsonFile.SelectedIndex = 0;
            this.tabEditJsonFile.Size = new System.Drawing.Size(584, 387);
            this.tabEditJsonFile.TabIndex = 0;
            // 
            // tabOriginal
            // 
            this.tabOriginal.Controls.Add(this.txtOriginal);
            this.tabOriginal.Location = new System.Drawing.Point(4, 24);
            this.tabOriginal.Name = "tabOriginal";
            this.tabOriginal.Padding = new System.Windows.Forms.Padding(3);
            this.tabOriginal.Size = new System.Drawing.Size(576, 359);
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
            this.txtOriginal.Size = new System.Drawing.Size(570, 353);
            this.txtOriginal.TabIndex = 0;
            // 
            // tabEdited
            // 
            this.tabEdited.Controls.Add(this.txtEdited);
            this.tabEdited.Location = new System.Drawing.Point(4, 24);
            this.tabEdited.Name = "tabEdited";
            this.tabEdited.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdited.Size = new System.Drawing.Size(576, 359);
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
            this.txtEdited.Size = new System.Drawing.Size(570, 353);
            this.txtEdited.TabIndex = 0;
            this.txtEdited.TextChanged += new System.EventHandler(this.txtEdited_TextChanged);
            // 
            // tabPatch
            // 
            this.tabPatch.Controls.Add(this.txtPatch);
            this.tabPatch.Location = new System.Drawing.Point(4, 24);
            this.tabPatch.Name = "tabPatch";
            this.tabPatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatch.Size = new System.Drawing.Size(576, 359);
            this.tabPatch.TabIndex = 2;
            this.tabPatch.Text = "Patch";
            this.tabPatch.UseVisualStyleBackColor = true;
            // 
            // FrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pnlFiles);
            this.Controls.Add(this.barMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barMenu;
            this.MinimumSize = new System.Drawing.Size(600, 450);
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
            this.tabPatch.ResumeLayout(false);
            this.tabPatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip barMenu;
        private TextBox txtPatch;
        private Panel pnlFiles;
        private TabControl tabEditJsonFile;
        private TabPage tabOriginal;
        private TabPage tabEdited;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem btnLoadJsonFile;
        private ToolStripMenuItem btnSaveJsonPatch;
        private TextBox txtOriginal;
        private TextBox txtEdited;
        private TabPage tabPatch;
        private ToolStripMenuItem mnuAppSide;
        private ToolStripMenuItem btnClient;
        private ToolStripMenuItem btnServer;
        private ToolStripMenuItem btnUniversal;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem btnReset;
    }
}