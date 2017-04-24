namespace FF7Viewer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveTilemapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveMIMTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.lZSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.unLZSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        	this.tabControl1 = new System.Windows.Forms.TabControl();
        	this.tpScript = new System.Windows.Forms.TabPage();
        	this.lblNbAKAO = new System.Windows.Forms.Label();
        	this.lblAKAOBlocks = new System.Windows.Forms.Label();
        	this.btnNextAKAO = new System.Windows.Forms.Button();
        	this.btnPrevAKAO = new System.Windows.Forms.Button();
        	this.txtAKAOId = new System.Windows.Forms.TextBox();
        	this.txtAKAOFrames = new System.Windows.Forms.RichTextBox();
        	this.lblNbScripts = new System.Windows.Forms.Label();
        	this.lblScripts = new System.Windows.Forms.Label();
        	this.btnNextScript = new System.Windows.Forms.Button();
        	this.btnPrevScript = new System.Windows.Forms.Button();
        	this.txtScriptId = new System.Windows.Forms.TextBox();
        	this.txtDescription = new System.Windows.Forms.TextBox();
        	this.lblNbDialogs = new System.Windows.Forms.Label();
        	this.lblDialogs = new System.Windows.Forms.Label();
        	this.lblEntities = new System.Windows.Forms.Label();
        	this.btnNextDialog = new System.Windows.Forms.Button();
        	this.btnPrevDialog = new System.Windows.Forms.Button();
        	this.txtDialogId = new System.Windows.Forms.TextBox();
        	this.txtDialog = new System.Windows.Forms.RichTextBox();
        	this.lstEntities = new System.Windows.Forms.ListBox();
        	this.lblCreator = new System.Windows.Forms.Label();
        	this.txtCreator = new System.Windows.Forms.TextBox();
        	this.lblScriptName = new System.Windows.Forms.Label();
        	this.txtName = new System.Windows.Forms.TextBox();
        	this.tpWalkmesh = new System.Windows.Forms.TabPage();
        	this.pnlTK = new System.Windows.Forms.Panel();
        	this.tpMIMTexture = new System.Windows.Forms.TabPage();
        	this.tlpTileMap = new System.Windows.Forms.TableLayoutPanel();
        	this.pbMIMTexture = new System.Windows.Forms.PictureBox();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.btnNextPalette = new System.Windows.Forms.Button();
        	this.btnPrevPalette = new System.Windows.Forms.Button();
        	this.txtPaletteId = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.tpTileMap = new System.Windows.Forms.TabPage();
        	this.pbTileMap = new System.Windows.Forms.PictureBox();
        	this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        	this.menuStrip1.SuspendLayout();
        	this.tabControl1.SuspendLayout();
        	this.tpScript.SuspendLayout();
        	this.tpWalkmesh.SuspendLayout();
        	this.tpMIMTexture.SuspendLayout();
        	this.tlpTileMap.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pbMIMTexture)).BeginInit();
        	this.panel1.SuspendLayout();
        	this.tpTileMap.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pbTileMap)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.lZSToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(960, 24);
        	this.menuStrip1.TabIndex = 0;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openToolStripMenuItem,
			this.exitToolStripMenuItem,
			this.saveFieldToolStripMenuItem,
			this.saveMIMTextureToolStripMenuItem,
			this.saveTilemapToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// openToolStripMenuItem
        	// 
        	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        	this.openToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
        	this.openToolStripMenuItem.Text = "&Open";
        	this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
        	this.exitToolStripMenuItem.Text = "&Exit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        	// 
        	// saveTilemapToolStripMenuItem
        	// 
        	this.saveTilemapToolStripMenuItem.Name = "saveTilemapToolStripMenuItem";
        	this.saveTilemapToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
        	this.saveTilemapToolStripMenuItem.Text = "Save &Tilemap";
        	this.saveTilemapToolStripMenuItem.Click += new System.EventHandler(this.SaveTilemapToolStripMenuItemClick);
        	// 
        	// saveFieldToolStripMenuItem
        	// 
        	this.saveFieldToolStripMenuItem.Name = "saveFieldToolStripMenuItem";
        	this.saveFieldToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
        	this.saveFieldToolStripMenuItem.Text = "Save &Field";
        	this.saveFieldToolStripMenuItem.Click += new System.EventHandler(this.SaveFieldToolStripMenuItemClick);
        	// 
        	// saveMIMTextureToolStripMenuItem
        	// 
        	this.saveMIMTextureToolStripMenuItem.Name = "saveMIMTextureToolStripMenuItem";
        	this.saveMIMTextureToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
        	this.saveMIMTextureToolStripMenuItem.Text = "Save &MIM Texture";
        	this.saveMIMTextureToolStripMenuItem.Click += new System.EventHandler(this.SaveMIMTextureToolStripMenuItemClick);
        	// 
        	// lZSToolStripMenuItem
        	// 
        	this.lZSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.unLZSToolStripMenuItem});
        	this.lZSToolStripMenuItem.Name = "lZSToolStripMenuItem";
        	this.lZSToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
        	this.lZSToolStripMenuItem.Text = "LZS";
        	// 
        	// unLZSToolStripMenuItem
        	// 
        	this.unLZSToolStripMenuItem.Name = "unLZSToolStripMenuItem";
        	this.unLZSToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
        	this.unLZSToolStripMenuItem.Text = "unLZS";
        	this.unLZSToolStripMenuItem.Click += new System.EventHandler(this.UnLZSToolStripMenuItemClick);
        	// 
        	// openFileDialog1
        	// 
        	this.openFileDialog1.Filter = "DAT Files|*.dat|MIM Files|*.mim|BSX Files|*.bsx";
        	// 
        	// tabControl1
        	// 
        	this.tabControl1.Controls.Add(this.tpScript);
        	this.tabControl1.Controls.Add(this.tpWalkmesh);
        	this.tabControl1.Controls.Add(this.tpMIMTexture);
        	this.tabControl1.Controls.Add(this.tpTileMap);
        	this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tabControl1.ItemSize = new System.Drawing.Size(50, 18);
        	this.tabControl1.Location = new System.Drawing.Point(0, 24);
        	this.tabControl1.Name = "tabControl1";
        	this.tabControl1.Padding = new System.Drawing.Point(10, 3);
        	this.tabControl1.SelectedIndex = 0;
        	this.tabControl1.Size = new System.Drawing.Size(960, 471);
        	this.tabControl1.TabIndex = 1;
        	// 
        	// tpScript
        	// 
        	this.tpScript.Controls.Add(this.lblNbAKAO);
        	this.tpScript.Controls.Add(this.lblAKAOBlocks);
        	this.tpScript.Controls.Add(this.btnNextAKAO);
        	this.tpScript.Controls.Add(this.btnPrevAKAO);
        	this.tpScript.Controls.Add(this.txtAKAOId);
        	this.tpScript.Controls.Add(this.txtAKAOFrames);
        	this.tpScript.Controls.Add(this.lblNbScripts);
        	this.tpScript.Controls.Add(this.lblScripts);
        	this.tpScript.Controls.Add(this.btnNextScript);
        	this.tpScript.Controls.Add(this.btnPrevScript);
        	this.tpScript.Controls.Add(this.txtScriptId);
        	this.tpScript.Controls.Add(this.txtDescription);
        	this.tpScript.Controls.Add(this.lblNbDialogs);
        	this.tpScript.Controls.Add(this.lblDialogs);
        	this.tpScript.Controls.Add(this.lblEntities);
        	this.tpScript.Controls.Add(this.btnNextDialog);
        	this.tpScript.Controls.Add(this.btnPrevDialog);
        	this.tpScript.Controls.Add(this.txtDialogId);
        	this.tpScript.Controls.Add(this.txtDialog);
        	this.tpScript.Controls.Add(this.lstEntities);
        	this.tpScript.Controls.Add(this.lblCreator);
        	this.tpScript.Controls.Add(this.txtCreator);
        	this.tpScript.Controls.Add(this.lblScriptName);
        	this.tpScript.Controls.Add(this.txtName);
        	this.tpScript.Location = new System.Drawing.Point(4, 22);
        	this.tpScript.Name = "tpScript";
        	this.tpScript.Padding = new System.Windows.Forms.Padding(3);
        	this.tpScript.Size = new System.Drawing.Size(952, 445);
        	this.tpScript.TabIndex = 0;
        	this.tpScript.Text = "Scripts";
        	this.tpScript.UseVisualStyleBackColor = true;
        	// 
        	// lblNbAKAO
        	// 
        	this.lblNbAKAO.AutoSize = true;
        	this.lblNbAKAO.Location = new System.Drawing.Point(694, 46);
        	this.lblNbAKAO.Name = "lblNbAKAO";
        	this.lblNbAKAO.Size = new System.Drawing.Size(12, 13);
        	this.lblNbAKAO.TabIndex = 49;
        	this.lblNbAKAO.Text = "/";
        	// 
        	// lblAKAOBlocks
        	// 
        	this.lblAKAOBlocks.AutoSize = true;
        	this.lblAKAOBlocks.Location = new System.Drawing.Point(573, 46);
        	this.lblAKAOBlocks.Name = "lblAKAOBlocks";
        	this.lblAKAOBlocks.Size = new System.Drawing.Size(71, 13);
        	this.lblAKAOBlocks.TabIndex = 48;
        	this.lblAKAOBlocks.Text = "AKAO Blocks";
        	// 
        	// btnNextAKAO
        	// 
        	this.btnNextAKAO.Location = new System.Drawing.Point(757, 41);
        	this.btnNextAKAO.Name = "btnNextAKAO";
        	this.btnNextAKAO.Size = new System.Drawing.Size(16, 23);
        	this.btnNextAKAO.TabIndex = 47;
        	this.btnNextAKAO.Text = ">";
        	this.btnNextAKAO.UseVisualStyleBackColor = true;
        	this.btnNextAKAO.Click += new System.EventHandler(this.BtnNextAKAOClick);
        	// 
        	// btnPrevAKAO
        	// 
        	this.btnPrevAKAO.Location = new System.Drawing.Point(737, 41);
        	this.btnPrevAKAO.Name = "btnPrevAKAO";
        	this.btnPrevAKAO.Size = new System.Drawing.Size(14, 23);
        	this.btnPrevAKAO.TabIndex = 46;
        	this.btnPrevAKAO.Text = "<";
        	this.btnPrevAKAO.UseVisualStyleBackColor = true;
        	this.btnPrevAKAO.Click += new System.EventHandler(this.BtnPrevAKAOClick);
        	// 
        	// txtAKAOId
        	// 
        	this.txtAKAOId.Enabled = false;
        	this.txtAKAOId.Location = new System.Drawing.Point(650, 43);
        	this.txtAKAOId.Name = "txtAKAOId";
        	this.txtAKAOId.Size = new System.Drawing.Size(38, 20);
        	this.txtAKAOId.TabIndex = 45;
        	// 
        	// txtAKAOFrames
        	// 
        	this.txtAKAOFrames.Location = new System.Drawing.Point(573, 66);
        	this.txtAKAOFrames.Name = "txtAKAOFrames";
        	this.txtAKAOFrames.Size = new System.Drawing.Size(376, 365);
        	this.txtAKAOFrames.TabIndex = 44;
        	this.txtAKAOFrames.Text = "";
        	// 
        	// lblNbScripts
        	// 
        	this.lblNbScripts.AutoSize = true;
        	this.lblNbScripts.Location = new System.Drawing.Point(283, 250);
        	this.lblNbScripts.Name = "lblNbScripts";
        	this.lblNbScripts.Size = new System.Drawing.Size(24, 13);
        	this.lblNbScripts.TabIndex = 43;
        	this.lblNbScripts.Text = "/32";
        	// 
        	// lblScripts
        	// 
        	this.lblScripts.AutoSize = true;
        	this.lblScripts.Location = new System.Drawing.Point(191, 250);
        	this.lblScripts.Name = "lblScripts";
        	this.lblScripts.Size = new System.Drawing.Size(39, 13);
        	this.lblScripts.TabIndex = 42;
        	this.lblScripts.Text = "Scripts";
        	// 
        	// btnNextScript
        	// 
        	this.btnNextScript.Location = new System.Drawing.Point(346, 245);
        	this.btnNextScript.Name = "btnNextScript";
        	this.btnNextScript.Size = new System.Drawing.Size(16, 23);
        	this.btnNextScript.TabIndex = 41;
        	this.btnNextScript.Text = ">";
        	this.btnNextScript.UseVisualStyleBackColor = true;
        	this.btnNextScript.Click += new System.EventHandler(this.btnNextScript_Click);
        	// 
        	// btnPrevScript
        	// 
        	this.btnPrevScript.Location = new System.Drawing.Point(326, 245);
        	this.btnPrevScript.Name = "btnPrevScript";
        	this.btnPrevScript.Size = new System.Drawing.Size(14, 23);
        	this.btnPrevScript.TabIndex = 40;
        	this.btnPrevScript.Text = "<";
        	this.btnPrevScript.UseVisualStyleBackColor = true;
        	this.btnPrevScript.Click += new System.EventHandler(this.btnPrevScript_Click);
        	// 
        	// txtScriptId
        	// 
        	this.txtScriptId.Enabled = false;
        	this.txtScriptId.Location = new System.Drawing.Point(239, 247);
        	this.txtScriptId.Name = "txtScriptId";
        	this.txtScriptId.Size = new System.Drawing.Size(38, 20);
        	this.txtScriptId.TabIndex = 39;
        	// 
        	// txtDescription
        	// 
        	this.txtDescription.Location = new System.Drawing.Point(191, 271);
        	this.txtDescription.Multiline = true;
        	this.txtDescription.Name = "txtDescription";
        	this.txtDescription.Size = new System.Drawing.Size(375, 160);
        	this.txtDescription.TabIndex = 38;
        	// 
        	// lblNbDialogs
        	// 
        	this.lblNbDialogs.AutoSize = true;
        	this.lblNbDialogs.Location = new System.Drawing.Point(283, 46);
        	this.lblNbDialogs.Name = "lblNbDialogs";
        	this.lblNbDialogs.Size = new System.Drawing.Size(12, 13);
        	this.lblNbDialogs.TabIndex = 37;
        	this.lblNbDialogs.Text = "/";
        	// 
        	// lblDialogs
        	// 
        	this.lblDialogs.AutoSize = true;
        	this.lblDialogs.Location = new System.Drawing.Point(191, 46);
        	this.lblDialogs.Name = "lblDialogs";
        	this.lblDialogs.Size = new System.Drawing.Size(42, 13);
        	this.lblDialogs.TabIndex = 36;
        	this.lblDialogs.Text = "Dialogs";
        	// 
        	// lblEntities
        	// 
        	this.lblEntities.AutoSize = true;
        	this.lblEntities.Location = new System.Drawing.Point(13, 46);
        	this.lblEntities.Name = "lblEntities";
        	this.lblEntities.Size = new System.Drawing.Size(41, 13);
        	this.lblEntities.TabIndex = 35;
        	this.lblEntities.Text = "Entities";
        	// 
        	// btnNextDialog
        	// 
        	this.btnNextDialog.Location = new System.Drawing.Point(346, 41);
        	this.btnNextDialog.Name = "btnNextDialog";
        	this.btnNextDialog.Size = new System.Drawing.Size(16, 23);
        	this.btnNextDialog.TabIndex = 34;
        	this.btnNextDialog.Text = ">";
        	this.btnNextDialog.UseVisualStyleBackColor = true;
        	this.btnNextDialog.Click += new System.EventHandler(this.btnNextDialog_Click);
        	// 
        	// btnPrevDialog
        	// 
        	this.btnPrevDialog.Location = new System.Drawing.Point(326, 41);
        	this.btnPrevDialog.Name = "btnPrevDialog";
        	this.btnPrevDialog.Size = new System.Drawing.Size(14, 23);
        	this.btnPrevDialog.TabIndex = 33;
        	this.btnPrevDialog.Text = "<";
        	this.btnPrevDialog.UseVisualStyleBackColor = true;
        	this.btnPrevDialog.Click += new System.EventHandler(this.btnPrevDialog_Click);
        	// 
        	// txtDialogId
        	// 
        	this.txtDialogId.Enabled = false;
        	this.txtDialogId.Location = new System.Drawing.Point(239, 43);
        	this.txtDialogId.Name = "txtDialogId";
        	this.txtDialogId.Size = new System.Drawing.Size(38, 20);
        	this.txtDialogId.TabIndex = 32;
        	// 
        	// txtDialog
        	// 
        	this.txtDialog.Location = new System.Drawing.Point(191, 66);
        	this.txtDialog.Name = "txtDialog";
        	this.txtDialog.Size = new System.Drawing.Size(376, 169);
        	this.txtDialog.TabIndex = 31;
        	this.txtDialog.Text = "";
        	// 
        	// lstEntities
        	// 
        	this.lstEntities.FormattingEnabled = true;
        	this.lstEntities.Location = new System.Drawing.Point(13, 64);
        	this.lstEntities.Name = "lstEntities";
        	this.lstEntities.Size = new System.Drawing.Size(160, 368);
        	this.lstEntities.TabIndex = 30;
        	this.lstEntities.SelectedIndexChanged += new System.EventHandler(this.lstEntities_SelectedIndexChanged);
        	// 
        	// lblCreator
        	// 
        	this.lblCreator.AutoSize = true;
        	this.lblCreator.Location = new System.Drawing.Point(184, 16);
        	this.lblCreator.Name = "lblCreator";
        	this.lblCreator.Size = new System.Drawing.Size(41, 13);
        	this.lblCreator.TabIndex = 29;
        	this.lblCreator.Text = "Creator";
        	// 
        	// txtCreator
        	// 
        	this.txtCreator.Location = new System.Drawing.Point(231, 13);
        	this.txtCreator.Name = "txtCreator";
        	this.txtCreator.Size = new System.Drawing.Size(131, 20);
        	this.txtCreator.TabIndex = 28;
        	// 
        	// lblScriptName
        	// 
        	this.lblScriptName.AutoSize = true;
        	this.lblScriptName.Location = new System.Drawing.Point(13, 16);
        	this.lblScriptName.Name = "lblScriptName";
        	this.lblScriptName.Size = new System.Drawing.Size(35, 13);
        	this.lblScriptName.TabIndex = 27;
        	this.lblScriptName.Text = "Name";
        	// 
        	// txtName
        	// 
        	this.txtName.Location = new System.Drawing.Point(54, 13);
        	this.txtName.Name = "txtName";
        	this.txtName.Size = new System.Drawing.Size(119, 20);
        	this.txtName.TabIndex = 26;
        	// 
        	// tpWalkmesh
        	// 
        	this.tpWalkmesh.Controls.Add(this.pnlTK);
        	this.tpWalkmesh.Location = new System.Drawing.Point(4, 22);
        	this.tpWalkmesh.Name = "tpWalkmesh";
        	this.tpWalkmesh.Padding = new System.Windows.Forms.Padding(3);
        	this.tpWalkmesh.Size = new System.Drawing.Size(952, 445);
        	this.tpWalkmesh.TabIndex = 1;
        	this.tpWalkmesh.Text = "Walkmesh";
        	this.tpWalkmesh.UseVisualStyleBackColor = true;
        	// 
        	// pnlTK
        	// 
        	this.pnlTK.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.pnlTK.Location = new System.Drawing.Point(3, 3);
        	this.pnlTK.Name = "pnlTK";
        	this.pnlTK.Size = new System.Drawing.Size(946, 439);
        	this.pnlTK.TabIndex = 1;
        	// 
        	// tpMIMTexture
        	// 
        	this.tpMIMTexture.Controls.Add(this.tlpTileMap);
        	this.tpMIMTexture.Location = new System.Drawing.Point(4, 22);
        	this.tpMIMTexture.Name = "tpMIMTexture";
        	this.tpMIMTexture.Padding = new System.Windows.Forms.Padding(3);
        	this.tpMIMTexture.Size = new System.Drawing.Size(952, 445);
        	this.tpMIMTexture.TabIndex = 2;
        	this.tpMIMTexture.Text = "MIM Texture";
        	this.tpMIMTexture.UseVisualStyleBackColor = true;
        	// 
        	// tlpTileMap
        	// 
        	this.tlpTileMap.ColumnCount = 1;
        	this.tlpTileMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tlpTileMap.Controls.Add(this.pbMIMTexture, 0, 1);
        	this.tlpTileMap.Controls.Add(this.panel1, 0, 0);
        	this.tlpTileMap.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tlpTileMap.Location = new System.Drawing.Point(3, 3);
        	this.tlpTileMap.Name = "tlpTileMap";
        	this.tlpTileMap.RowCount = 2;
        	this.tlpTileMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.tlpTileMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tlpTileMap.Size = new System.Drawing.Size(946, 439);
        	this.tlpTileMap.TabIndex = 0;
        	// 
        	// pbMIMTexture
        	// 
        	this.pbMIMTexture.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.pbMIMTexture.Location = new System.Drawing.Point(3, 33);
        	this.pbMIMTexture.Name = "pbMIMTexture";
        	this.pbMIMTexture.Size = new System.Drawing.Size(940, 403);
        	this.pbMIMTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pbMIMTexture.TabIndex = 1;
        	this.pbMIMTexture.TabStop = false;
        	this.pbMIMTexture.Resize += new System.EventHandler(this.PbMIMTextureResize);
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.btnNextPalette);
        	this.panel1.Controls.Add(this.btnPrevPalette);
        	this.panel1.Controls.Add(this.txtPaletteId);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel1.Location = new System.Drawing.Point(3, 3);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(940, 24);
        	this.panel1.TabIndex = 2;
        	// 
        	// btnNextPalette
        	// 
        	this.btnNextPalette.Location = new System.Drawing.Point(119, 0);
        	this.btnNextPalette.Name = "btnNextPalette";
        	this.btnNextPalette.Size = new System.Drawing.Size(16, 23);
        	this.btnNextPalette.TabIndex = 36;
        	this.btnNextPalette.Text = ">";
        	this.btnNextPalette.UseVisualStyleBackColor = true;
        	this.btnNextPalette.Click += new System.EventHandler(this.BtnNextPaletteClick);
        	// 
        	// btnPrevPalette
        	// 
        	this.btnPrevPalette.Location = new System.Drawing.Point(99, 0);
        	this.btnPrevPalette.Name = "btnPrevPalette";
        	this.btnPrevPalette.Size = new System.Drawing.Size(14, 23);
        	this.btnPrevPalette.TabIndex = 35;
        	this.btnPrevPalette.Text = "<";
        	this.btnPrevPalette.UseVisualStyleBackColor = true;
        	this.btnPrevPalette.Click += new System.EventHandler(this.BtnPrevPaletteClick);
        	// 
        	// txtPaletteId
        	// 
        	this.txtPaletteId.Enabled = false;
        	this.txtPaletteId.Location = new System.Drawing.Point(57, 0);
        	this.txtPaletteId.Name = "txtPaletteId";
        	this.txtPaletteId.Size = new System.Drawing.Size(36, 20);
        	this.txtPaletteId.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(3, 4);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(48, 20);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Palette:";
        	// 
        	// tpTileMap
        	// 
        	this.tpTileMap.Controls.Add(this.pbTileMap);
        	this.tpTileMap.Location = new System.Drawing.Point(4, 22);
        	this.tpTileMap.Name = "tpTileMap";
        	this.tpTileMap.Padding = new System.Windows.Forms.Padding(3);
        	this.tpTileMap.Size = new System.Drawing.Size(952, 445);
        	this.tpTileMap.TabIndex = 3;
        	this.tpTileMap.Text = "TileMap";
        	this.tpTileMap.UseVisualStyleBackColor = true;
        	// 
        	// pbTileMap
        	// 
        	this.pbTileMap.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.pbTileMap.Location = new System.Drawing.Point(3, 3);
        	this.pbTileMap.Name = "pbTileMap";
        	this.pbTileMap.Size = new System.Drawing.Size(946, 439);
        	this.pbTileMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pbTileMap.TabIndex = 0;
        	this.pbTileMap.TabStop = false;
        	// 
        	// frmMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(960, 495);
        	this.Controls.Add(this.tabControl1);
        	this.Controls.Add(this.menuStrip1);
        	this.KeyPreview = true;
        	this.MainMenuStrip = this.menuStrip1;
        	this.Name = "frmMain";
        	this.Text = "FF7 Viewer";
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.tabControl1.ResumeLayout(false);
        	this.tpScript.ResumeLayout(false);
        	this.tpScript.PerformLayout();
        	this.tpWalkmesh.ResumeLayout(false);
        	this.tpMIMTexture.ResumeLayout(false);
        	this.tlpTileMap.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pbMIMTexture)).EndInit();
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.tpTileMap.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pbTileMap)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblScriptName;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.ListBox lstEntities;
        private System.Windows.Forms.RichTextBox txtDialog;
        private System.Windows.Forms.TextBox txtDialogId;
        private System.Windows.Forms.Button btnPrevDialog;
        private System.Windows.Forms.Button btnNextDialog;
        private System.Windows.Forms.Label lblEntities;
        private System.Windows.Forms.Label lblDialogs;
        private System.Windows.Forms.Label lblNbDialogs;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblNbScripts;
        private System.Windows.Forms.Label lblScripts;
        private System.Windows.Forms.Button btnNextScript;
        private System.Windows.Forms.Button btnPrevScript;
        private System.Windows.Forms.TextBox txtScriptId;
        private System.Windows.Forms.ToolStripMenuItem lZSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unLZSToolStripMenuItem;
        private System.Windows.Forms.Label lblNbAKAO;
        private System.Windows.Forms.RichTextBox txtAKAOFrames;
        private System.Windows.Forms.Label lblAKAOBlocks;
        private System.Windows.Forms.Button btnNextAKAO;
        private System.Windows.Forms.Button btnPrevAKAO;
        private System.Windows.Forms.TextBox txtAKAOId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpScript;
        private System.Windows.Forms.TabPage tpWalkmesh;
        private System.Windows.Forms.Panel pnlTK;
        private System.Windows.Forms.TabPage tpMIMTexture;
        private System.Windows.Forms.PictureBox pbMIMTexture;
        private System.Windows.Forms.ToolStripMenuItem saveTilemapToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tlpTileMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaletteId;
        private System.Windows.Forms.Button btnNextPalette;
        private System.Windows.Forms.Button btnPrevPalette;
        private System.Windows.Forms.TabPage tpTileMap;
        private System.Windows.Forms.PictureBox pbTileMap;
        private System.Windows.Forms.ToolStripMenuItem saveFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMIMTextureToolStripMenuItem;
    }
}

