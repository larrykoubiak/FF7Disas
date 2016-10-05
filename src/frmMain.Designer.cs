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
        	this.lZSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.unLZSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        	this.txtName = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtCreator = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.lstEntities = new System.Windows.Forms.ListBox();
        	this.txtDialog = new System.Windows.Forms.RichTextBox();
        	this.txtDialogId = new System.Windows.Forms.TextBox();
        	this.btnPrevDialog = new System.Windows.Forms.Button();
        	this.btnNextDialog = new System.Windows.Forms.Button();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.lblNbDialogs = new System.Windows.Forms.Label();
        	this.txtDescription = new System.Windows.Forms.TextBox();
        	this.lblNbScripts = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.btnNextScript = new System.Windows.Forms.Button();
        	this.btnPrevScript = new System.Windows.Forms.Button();
        	this.txtScriptId = new System.Windows.Forms.TextBox();
        	this.txtAKAOFrames = new System.Windows.Forms.RichTextBox();
        	this.lblNbAKAO = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.btnNextAKAO = new System.Windows.Forms.Button();
        	this.btnPrevAKAO = new System.Windows.Forms.Button();
        	this.txtAKAOId = new System.Windows.Forms.TextBox();
        	this.menuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.lZSToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(970, 24);
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
        	// txtName
        	// 
        	this.txtName.Location = new System.Drawing.Point(53, 37);
        	this.txtName.Name = "txtName";
        	this.txtName.Size = new System.Drawing.Size(119, 20);
        	this.txtName.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(12, 40);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(35, 13);
        	this.label1.TabIndex = 2;
        	this.label1.Text = "Name";
        	// 
        	// txtCreator
        	// 
        	this.txtCreator.Location = new System.Drawing.Point(230, 37);
        	this.txtCreator.Name = "txtCreator";
        	this.txtCreator.Size = new System.Drawing.Size(131, 20);
        	this.txtCreator.TabIndex = 3;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(183, 40);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(41, 13);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "Creator";
        	// 
        	// lstEntities
        	// 
        	this.lstEntities.FormattingEnabled = true;
        	this.lstEntities.Location = new System.Drawing.Point(12, 88);
        	this.lstEntities.Name = "lstEntities";
        	this.lstEntities.Size = new System.Drawing.Size(160, 368);
        	this.lstEntities.TabIndex = 5;
        	this.lstEntities.SelectedIndexChanged += new System.EventHandler(this.lstEntities_SelectedIndexChanged);
        	// 
        	// txtDialog
        	// 
        	this.txtDialog.Location = new System.Drawing.Point(190, 90);
        	this.txtDialog.Name = "txtDialog";
        	this.txtDialog.Size = new System.Drawing.Size(376, 169);
        	this.txtDialog.TabIndex = 6;
        	this.txtDialog.Text = "";
        	// 
        	// txtDialogId
        	// 
        	this.txtDialogId.Enabled = false;
        	this.txtDialogId.Location = new System.Drawing.Point(238, 67);
        	this.txtDialogId.Name = "txtDialogId";
        	this.txtDialogId.Size = new System.Drawing.Size(38, 20);
        	this.txtDialogId.TabIndex = 7;
        	// 
        	// btnPrevDialog
        	// 
        	this.btnPrevDialog.Location = new System.Drawing.Point(325, 65);
        	this.btnPrevDialog.Name = "btnPrevDialog";
        	this.btnPrevDialog.Size = new System.Drawing.Size(14, 23);
        	this.btnPrevDialog.TabIndex = 8;
        	this.btnPrevDialog.Text = "<";
        	this.btnPrevDialog.UseVisualStyleBackColor = true;
        	this.btnPrevDialog.Click += new System.EventHandler(this.btnPrevDialog_Click);
        	// 
        	// btnNextDialog
        	// 
        	this.btnNextDialog.Location = new System.Drawing.Point(345, 65);
        	this.btnNextDialog.Name = "btnNextDialog";
        	this.btnNextDialog.Size = new System.Drawing.Size(16, 23);
        	this.btnNextDialog.TabIndex = 9;
        	this.btnNextDialog.Text = ">";
        	this.btnNextDialog.UseVisualStyleBackColor = true;
        	this.btnNextDialog.Click += new System.EventHandler(this.btnNextDialog_Click);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(12, 70);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(41, 13);
        	this.label3.TabIndex = 10;
        	this.label3.Text = "Entities";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(190, 70);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(42, 13);
        	this.label4.TabIndex = 11;
        	this.label4.Text = "Dialogs";
        	// 
        	// lblNbDialogs
        	// 
        	this.lblNbDialogs.AutoSize = true;
        	this.lblNbDialogs.Location = new System.Drawing.Point(282, 70);
        	this.lblNbDialogs.Name = "lblNbDialogs";
        	this.lblNbDialogs.Size = new System.Drawing.Size(12, 13);
        	this.lblNbDialogs.TabIndex = 12;
        	this.lblNbDialogs.Text = "/";
        	// 
        	// txtDescription
        	// 
        	this.txtDescription.Location = new System.Drawing.Point(190, 295);
        	this.txtDescription.Multiline = true;
        	this.txtDescription.Name = "txtDescription";
        	this.txtDescription.Size = new System.Drawing.Size(375, 160);
        	this.txtDescription.TabIndex = 13;
        	// 
        	// lblNbScripts
        	// 
        	this.lblNbScripts.AutoSize = true;
        	this.lblNbScripts.Location = new System.Drawing.Point(282, 274);
        	this.lblNbScripts.Name = "lblNbScripts";
        	this.lblNbScripts.Size = new System.Drawing.Size(24, 13);
        	this.lblNbScripts.TabIndex = 19;
        	this.lblNbScripts.Text = "/32";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(190, 274);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(39, 13);
        	this.label6.TabIndex = 18;
        	this.label6.Text = "Scripts";
        	// 
        	// btnNextScript
        	// 
        	this.btnNextScript.Location = new System.Drawing.Point(345, 269);
        	this.btnNextScript.Name = "btnNextScript";
        	this.btnNextScript.Size = new System.Drawing.Size(16, 23);
        	this.btnNextScript.TabIndex = 17;
        	this.btnNextScript.Text = ">";
        	this.btnNextScript.UseVisualStyleBackColor = true;
        	this.btnNextScript.Click += new System.EventHandler(this.btnNextScript_Click);
        	// 
        	// btnPrevScript
        	// 
        	this.btnPrevScript.Location = new System.Drawing.Point(325, 269);
        	this.btnPrevScript.Name = "btnPrevScript";
        	this.btnPrevScript.Size = new System.Drawing.Size(14, 23);
        	this.btnPrevScript.TabIndex = 16;
        	this.btnPrevScript.Text = "<";
        	this.btnPrevScript.UseVisualStyleBackColor = true;
        	this.btnPrevScript.Click += new System.EventHandler(this.btnPrevScript_Click);
        	// 
        	// txtScriptId
        	// 
        	this.txtScriptId.Enabled = false;
        	this.txtScriptId.Location = new System.Drawing.Point(238, 271);
        	this.txtScriptId.Name = "txtScriptId";
        	this.txtScriptId.Size = new System.Drawing.Size(38, 20);
        	this.txtScriptId.TabIndex = 15;
        	// 
        	// txtAKAOFrames
        	// 
        	this.txtAKAOFrames.Location = new System.Drawing.Point(572, 90);
        	this.txtAKAOFrames.Name = "txtAKAOFrames";
        	this.txtAKAOFrames.Size = new System.Drawing.Size(376, 365);
        	this.txtAKAOFrames.TabIndex = 20;
        	this.txtAKAOFrames.Text = "";
        	// 
        	// lblNbAKAO
        	// 
        	this.lblNbAKAO.AutoSize = true;
        	this.lblNbAKAO.Location = new System.Drawing.Point(693, 70);
        	this.lblNbAKAO.Name = "lblNbAKAO";
        	this.lblNbAKAO.Size = new System.Drawing.Size(12, 13);
        	this.lblNbAKAO.TabIndex = 25;
        	this.lblNbAKAO.Text = "/";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(572, 70);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(71, 13);
        	this.label7.TabIndex = 24;
        	this.label7.Text = "AKAO Blocks";
        	// 
        	// btnNextAKAO
        	// 
        	this.btnNextAKAO.Location = new System.Drawing.Point(756, 65);
        	this.btnNextAKAO.Name = "btnNextAKAO";
        	this.btnNextAKAO.Size = new System.Drawing.Size(16, 23);
        	this.btnNextAKAO.TabIndex = 23;
        	this.btnNextAKAO.Text = ">";
        	this.btnNextAKAO.UseVisualStyleBackColor = true;
        	this.btnNextAKAO.Click += new System.EventHandler(this.BtnNextAKAOClick);
        	// 
        	// btnPrevAKAO
        	// 
        	this.btnPrevAKAO.Location = new System.Drawing.Point(736, 65);
        	this.btnPrevAKAO.Name = "btnPrevAKAO";
        	this.btnPrevAKAO.Size = new System.Drawing.Size(14, 23);
        	this.btnPrevAKAO.TabIndex = 22;
        	this.btnPrevAKAO.Text = "<";
        	this.btnPrevAKAO.UseVisualStyleBackColor = true;
        	this.btnPrevAKAO.Click += new System.EventHandler(this.BtnPrevAKAOClick);
        	// 
        	// txtAKAOId
        	// 
        	this.txtAKAOId.Enabled = false;
        	this.txtAKAOId.Location = new System.Drawing.Point(649, 67);
        	this.txtAKAOId.Name = "txtAKAOId";
        	this.txtAKAOId.Size = new System.Drawing.Size(38, 20);
        	this.txtAKAOId.TabIndex = 21;
        	// 
        	// frmMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(970, 467);
        	this.Controls.Add(this.lblNbAKAO);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.btnNextAKAO);
        	this.Controls.Add(this.btnPrevAKAO);
        	this.Controls.Add(this.txtAKAOId);
        	this.Controls.Add(this.txtAKAOFrames);
        	this.Controls.Add(this.lblNbScripts);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.btnNextScript);
        	this.Controls.Add(this.btnPrevScript);
        	this.Controls.Add(this.txtScriptId);
        	this.Controls.Add(this.txtDescription);
        	this.Controls.Add(this.lblNbDialogs);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.btnNextDialog);
        	this.Controls.Add(this.btnPrevDialog);
        	this.Controls.Add(this.txtDialogId);
        	this.Controls.Add(this.txtDialog);
        	this.Controls.Add(this.lstEntities);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.txtCreator);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.txtName);
        	this.Controls.Add(this.menuStrip1);
        	this.MainMenuStrip = this.menuStrip1;
        	this.Name = "frmMain";
        	this.Text = "FF7 Viewer";
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
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
    }
}

