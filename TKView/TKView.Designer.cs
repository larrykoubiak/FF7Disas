/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 19/04/2017
 * Time: 13:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TKView
{
	partial class TKView
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private OpenTK.GLControl glControl1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox txtZPos;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtYPos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtXPos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtZOri;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtYOri;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtXOri;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtZOri = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtYOri = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtXOri = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtZPos = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtYPos = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtXPos = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.glControl1 = new OpenTK.GLControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.txtZOri);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1.Controls.Add(this.txtYOri);
			this.splitContainer1.Panel1.Controls.Add(this.label6);
			this.splitContainer1.Panel1.Controls.Add(this.txtXOri);
			this.splitContainer1.Panel1.Controls.Add(this.label7);
			this.splitContainer1.Panel1.Controls.Add(this.label8);
			this.splitContainer1.Panel1.Controls.Add(this.txtZPos);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.txtYPos);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.txtXPos);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.glControl1);
			this.splitContainer1.Size = new System.Drawing.Size(542, 421);
			this.splitContainer1.SplitterDistance = 180;
			this.splitContainer1.TabIndex = 1;
			// 
			// txtZOri
			// 
			this.txtZOri.Enabled = false;
			this.txtZOri.Location = new System.Drawing.Point(65, 172);
			this.txtZOri.Name = "txtZOri";
			this.txtZOri.Size = new System.Drawing.Size(62, 20);
			this.txtZOri.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(4, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 18);
			this.label5.TabIndex = 12;
			this.label5.Text = "Z";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtYOri
			// 
			this.txtYOri.Enabled = false;
			this.txtYOri.Location = new System.Drawing.Point(65, 146);
			this.txtYOri.Name = "txtYOri";
			this.txtYOri.Size = new System.Drawing.Size(62, 20);
			this.txtYOri.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(4, 149);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "Y";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtXOri
			// 
			this.txtXOri.Enabled = false;
			this.txtXOri.Location = new System.Drawing.Point(65, 120);
			this.txtXOri.Name = "txtXOri";
			this.txtXOri.Size = new System.Drawing.Size(62, 20);
			this.txtXOri.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(4, 123);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 18);
			this.label7.TabIndex = 8;
			this.label7.Text = "X";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 101);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(124, 18);
			this.label8.TabIndex = 7;
			this.label8.Text = "Camera Orientation";
			// 
			// txtZPos
			// 
			this.txtZPos.Enabled = false;
			this.txtZPos.Location = new System.Drawing.Point(65, 71);
			this.txtZPos.Name = "txtZPos";
			this.txtZPos.Size = new System.Drawing.Size(62, 20);
			this.txtZPos.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(4, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 18);
			this.label4.TabIndex = 5;
			this.label4.Text = "Z";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtYPos
			// 
			this.txtYPos.Enabled = false;
			this.txtYPos.Location = new System.Drawing.Point(65, 45);
			this.txtYPos.Name = "txtYPos";
			this.txtYPos.Size = new System.Drawing.Size(62, 20);
			this.txtYPos.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(4, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Y";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtXPos
			// 
			this.txtXPos.Enabled = false;
			this.txtXPos.Location = new System.Drawing.Point(65, 19);
			this.txtXPos.Name = "txtXPos";
			this.txtXPos.Size = new System.Drawing.Size(62, 20);
			this.txtXPos.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "X";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Camera Position";
			// 
			// glControl1
			// 
			this.glControl1.BackColor = System.Drawing.Color.Black;
			this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glControl1.Location = new System.Drawing.Point(0, 0);
			this.glControl1.Name = "glControl1";
			this.glControl1.Size = new System.Drawing.Size(358, 421);
			this.glControl1.TabIndex = 1;
			this.glControl1.VSync = false;
			// 
			// TKView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "TKView";
			this.Size = new System.Drawing.Size(542, 421);
			this.Load += new System.EventHandler(this.GlControl1Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl1Paint);
			this.Resize += new System.EventHandler(this.GlControl1Resize);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
