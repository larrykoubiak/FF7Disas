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
        	this.components = new System.ComponentModel.Container();
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.lZSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.unLZSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        	this.tabControl1 = new System.Windows.Forms.TabControl();
        	this.tpScript = new System.Windows.Forms.TabPage();
        	this.lblNbAKAO = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.btnNextAKAO = new System.Windows.Forms.Button();
        	this.btnPrevAKAO = new System.Windows.Forms.Button();
        	this.txtAKAOId = new System.Windows.Forms.TextBox();
        	this.txtAKAOFrames = new System.Windows.Forms.RichTextBox();
        	this.lblNbScripts = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.btnNextScript = new System.Windows.Forms.Button();
        	this.btnPrevScript = new System.Windows.Forms.Button();
        	this.txtScriptId = new System.Windows.Forms.TextBox();
        	this.txtDescription = new System.Windows.Forms.TextBox();
        	this.lblNbDialogs = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.btnNextDialog = new System.Windows.Forms.Button();
        	this.btnPrevDialog = new System.Windows.Forms.Button();
        	this.txtDialogId = new System.Windows.Forms.TextBox();
        	this.txtDialog = new System.Windows.Forms.RichTextBox();
        	this.lstEntities = new System.Windows.Forms.ListBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.txtCreator = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtName = new System.Windows.Forms.TextBox();
        	this.tpWalkmesh = new System.Windows.Forms.TabPage();
        	this.scWalkMesh = new System.Windows.Forms.SplitContainer();
        	this.dgvWalkMesh = new System.Windows.Forms.DataGridView();
        	this.pnlTK = new System.Windows.Forms.Panel();
        	this.glControl1 = new OpenTK.GLControl();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.v0x = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.v0y = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.v0z = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.v1x = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.v1y = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.v1z = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.v2x = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.v2y = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.v2z = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.menuStrip1.SuspendLayout();
        	this.tabControl1.SuspendLayout();
        	this.tpScript.SuspendLayout();
        	this.tpWalkmesh.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.scWalkMesh)).BeginInit();
        	this.scWalkMesh.Panel1.SuspendLayout();
        	this.scWalkMesh.Panel2.SuspendLayout();
        	this.scWalkMesh.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvWalkMesh)).BeginInit();
        	this.pnlTK.SuspendLayout();
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
			this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// openToolStripMenuItem
        	// 
        	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        	this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
        	this.openToolStripMenuItem.Text = "&Open";
        	this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
        	this.exitToolStripMenuItem.Text = "&Exit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
        	this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tabControl1.Location = new System.Drawing.Point(0, 24);
        	this.tabControl1.Name = "tabControl1";
        	this.tabControl1.SelectedIndex = 0;
        	this.tabControl1.Size = new System.Drawing.Size(960, 471);
        	this.tabControl1.TabIndex = 1;
        	// 
        	// tpScript
        	// 
        	this.tpScript.Controls.Add(this.lblNbAKAO);
        	this.tpScript.Controls.Add(this.label7);
        	this.tpScript.Controls.Add(this.btnNextAKAO);
        	this.tpScript.Controls.Add(this.btnPrevAKAO);
        	this.tpScript.Controls.Add(this.txtAKAOId);
        	this.tpScript.Controls.Add(this.txtAKAOFrames);
        	this.tpScript.Controls.Add(this.lblNbScripts);
        	this.tpScript.Controls.Add(this.label6);
        	this.tpScript.Controls.Add(this.btnNextScript);
        	this.tpScript.Controls.Add(this.btnPrevScript);
        	this.tpScript.Controls.Add(this.txtScriptId);
        	this.tpScript.Controls.Add(this.txtDescription);
        	this.tpScript.Controls.Add(this.lblNbDialogs);
        	this.tpScript.Controls.Add(this.label4);
        	this.tpScript.Controls.Add(this.label3);
        	this.tpScript.Controls.Add(this.btnNextDialog);
        	this.tpScript.Controls.Add(this.btnPrevDialog);
        	this.tpScript.Controls.Add(this.txtDialogId);
        	this.tpScript.Controls.Add(this.txtDialog);
        	this.tpScript.Controls.Add(this.lstEntities);
        	this.tpScript.Controls.Add(this.label2);
        	this.tpScript.Controls.Add(this.txtCreator);
        	this.tpScript.Controls.Add(this.label1);
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
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(573, 46);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(71, 13);
        	this.label7.TabIndex = 48;
        	this.label7.Text = "AKAO Blocks";
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
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(191, 250);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(39, 13);
        	this.label6.TabIndex = 42;
        	this.label6.Text = "Scripts";
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
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(191, 46);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(42, 13);
        	this.label4.TabIndex = 36;
        	this.label4.Text = "Dialogs";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(13, 46);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(41, 13);
        	this.label3.TabIndex = 35;
        	this.label3.Text = "Entities";
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
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(184, 16);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(41, 13);
        	this.label2.TabIndex = 29;
        	this.label2.Text = "Creator";
        	// 
        	// txtCreator
        	// 
        	this.txtCreator.Location = new System.Drawing.Point(231, 13);
        	this.txtCreator.Name = "txtCreator";
        	this.txtCreator.Size = new System.Drawing.Size(131, 20);
        	this.txtCreator.TabIndex = 28;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(13, 16);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(35, 13);
        	this.label1.TabIndex = 27;
        	this.label1.Text = "Name";
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
        	this.tpWalkmesh.Controls.Add(this.scWalkMesh);
        	this.tpWalkmesh.Location = new System.Drawing.Point(4, 22);
        	this.tpWalkmesh.Name = "tpWalkmesh";
        	this.tpWalkmesh.Padding = new System.Windows.Forms.Padding(3);
        	this.tpWalkmesh.Size = new System.Drawing.Size(952, 445);
        	this.tpWalkmesh.TabIndex = 1;
        	this.tpWalkmesh.Text = "Walkmesh";
        	this.tpWalkmesh.UseVisualStyleBackColor = true;
        	// 
        	// scWalkMesh
        	// 
        	this.scWalkMesh.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.scWalkMesh.Location = new System.Drawing.Point(3, 3);
        	this.scWalkMesh.Name = "scWalkMesh";
        	// 
        	// scWalkMesh.Panel1
        	// 
        	this.scWalkMesh.Panel1.Controls.Add(this.dgvWalkMesh);
        	// 
        	// scWalkMesh.Panel2
        	// 
        	this.scWalkMesh.Panel2.Controls.Add(this.pnlTK);
        	this.scWalkMesh.Size = new System.Drawing.Size(946, 439);
        	this.scWalkMesh.SplitterDistance = 503;
        	this.scWalkMesh.TabIndex = 1;
        	// 
        	// dgvWalkMesh
        	// 
        	dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        	dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
        	dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        	dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.dgvWalkMesh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        	this.dgvWalkMesh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgvWalkMesh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.v0x,
			this.v0y,
			this.v0z,
			this.v1x,
			this.v1y,
			this.v1z,
			this.v2x,
			this.v2y,
			this.v2z});
        	this.dgvWalkMesh.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.dgvWalkMesh.Location = new System.Drawing.Point(0, 0);
        	this.dgvWalkMesh.Name = "dgvWalkMesh";
        	dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        	dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
        	dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
        	dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.dgvWalkMesh.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
        	this.dgvWalkMesh.RowHeadersWidth = 55;
        	dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        	this.dgvWalkMesh.RowsDefaultCellStyle = dataGridViewCellStyle3;
        	this.dgvWalkMesh.Size = new System.Drawing.Size(503, 439);
        	this.dgvWalkMesh.TabIndex = 1;
        	// 
        	// pnlTK
        	// 
        	this.pnlTK.Controls.Add(this.glControl1);
        	this.pnlTK.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.pnlTK.Location = new System.Drawing.Point(0, 0);
        	this.pnlTK.Name = "pnlTK";
        	this.pnlTK.Size = new System.Drawing.Size(439, 439);
        	this.pnlTK.TabIndex = 0;
        	// 
        	// glControl1
        	// 
        	this.glControl1.BackColor = System.Drawing.Color.Black;
        	this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.glControl1.Location = new System.Drawing.Point(0, 0);
        	this.glControl1.Name = "glControl1";
        	this.glControl1.Size = new System.Drawing.Size(439, 439);
        	this.glControl1.TabIndex = 0;
        	this.glControl1.VSync = true;
        	this.glControl1.Load += new System.EventHandler(this.GlControl1Load);
        	this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl1Paint);
        	this.glControl1.Resize += new System.EventHandler(this.GlControl1Resize);
        	// 
        	// timer1
        	// 
        	this.timer1.Interval = 20;
        	this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
        	// 
        	// v0x
        	// 
        	this.v0x.HeaderText = "v0x";
        	this.v0x.Name = "v0x";
        	this.v0x.Width = 50;
        	// 
        	// v0y
        	// 
        	this.v0y.HeaderText = "v0y";
        	this.v0y.Name = "v0y";
        	this.v0y.Width = 50;
        	// 
        	// v0z
        	// 
        	this.v0z.DividerWidth = 2;
        	this.v0z.HeaderText = "v0z";
        	this.v0z.Name = "v0z";
        	this.v0z.Width = 50;
        	// 
        	// v1x
        	// 
        	this.v1x.HeaderText = "v1x";
        	this.v1x.Name = "v1x";
        	this.v1x.Width = 50;
        	// 
        	// v1y
        	// 
        	this.v1y.HeaderText = "v1y";
        	this.v1y.Name = "v1y";
        	this.v1y.Width = 50;
        	// 
        	// v1z
        	// 
        	this.v1z.DividerWidth = 2;
        	this.v1z.HeaderText = "v1z";
        	this.v1z.Name = "v1z";
        	this.v1z.Width = 50;
        	// 
        	// v2x
        	// 
        	this.v2x.HeaderText = "v2x";
        	this.v2x.Name = "v2x";
        	this.v2x.Width = 50;
        	// 
        	// v2y
        	// 
        	this.v2y.HeaderText = "v2y";
        	this.v2y.Name = "v2y";
        	this.v2y.Width = 50;
        	// 
        	// v2z
        	// 
        	this.v2z.HeaderText = "v2z";
        	this.v2z.Name = "v2z";
        	this.v2z.Width = 50;
        	// 
        	// frmMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(960, 495);
        	this.Controls.Add(this.tabControl1);
        	this.Controls.Add(this.menuStrip1);
        	this.MainMenuStrip = this.menuStrip1;
        	this.Name = "frmMain";
        	this.Text = "FF7 Viewer";
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.tabControl1.ResumeLayout(false);
        	this.tpScript.ResumeLayout(false);
        	this.tpScript.PerformLayout();
        	this.tpWalkmesh.ResumeLayout(false);
        	this.scWalkMesh.Panel1.ResumeLayout(false);
        	this.scWalkMesh.Panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.scWalkMesh)).EndInit();
        	this.scWalkMesh.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.dgvWalkMesh)).EndInit();
        	this.pnlTK.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstEntities;
        private System.Windows.Forms.RichTextBox txtDialog;
        private System.Windows.Forms.TextBox txtDialogId;
        private System.Windows.Forms.Button btnPrevDialog;
        private System.Windows.Forms.Button btnNextDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNbDialogs;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblNbScripts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNextScript;
        private System.Windows.Forms.Button btnPrevScript;
        private System.Windows.Forms.TextBox txtScriptId;
        private System.Windows.Forms.ToolStripMenuItem lZSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unLZSToolStripMenuItem;
        private System.Windows.Forms.Label lblNbAKAO;
        private System.Windows.Forms.RichTextBox txtAKAOFrames;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNextAKAO;
        private System.Windows.Forms.Button btnPrevAKAO;
        private System.Windows.Forms.TextBox txtAKAOId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpScript;
        private System.Windows.Forms.TabPage tpWalkmesh;
        private System.Windows.Forms.DataGridView dgvWalkMesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn v0x;
        private System.Windows.Forms.DataGridViewTextBoxColumn v0y;
        private System.Windows.Forms.DataGridViewTextBoxColumn v0z;
        private System.Windows.Forms.DataGridViewTextBoxColumn v1x;
        private System.Windows.Forms.DataGridViewTextBoxColumn v1y;
        private System.Windows.Forms.DataGridViewTextBoxColumn v1z;
        private System.Windows.Forms.DataGridViewTextBoxColumn v2x;
        private System.Windows.Forms.DataGridViewTextBoxColumn v2y;
        private System.Windows.Forms.DataGridViewTextBoxColumn v2z;
        private System.Windows.Forms.SplitContainer scWalkMesh;
        private System.Windows.Forms.Panel pnlTK;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Timer timer1;
    }
}

