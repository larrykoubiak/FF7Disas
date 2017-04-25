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
		private System.Windows.Forms.Label lblPositionZ;
		private System.Windows.Forms.TextBox txtYPos;
		private System.Windows.Forms.Label lblPositionY;
		private System.Windows.Forms.TextBox txtXPos;
		private System.Windows.Forms.Label lblPositionX;
		private System.Windows.Forms.Label lblCameraPosition;
		private System.Windows.Forms.TextBox txtZOri;
		private System.Windows.Forms.Label lblOrientationZ;
		private System.Windows.Forms.TextBox txtYOri;
		private System.Windows.Forms.Label lblOrientationY;
		private System.Windows.Forms.TextBox txtXOri;
		private System.Windows.Forms.Label lblOrientationX;
		private System.Windows.Forms.Label lblCameraOrientation;
		
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
			this.lblOrientationZ = new System.Windows.Forms.Label();
			this.txtYOri = new System.Windows.Forms.TextBox();
			this.lblOrientationY = new System.Windows.Forms.Label();
			this.txtXOri = new System.Windows.Forms.TextBox();
			this.lblOrientationX = new System.Windows.Forms.Label();
			this.lblCameraOrientation = new System.Windows.Forms.Label();
			this.txtZPos = new System.Windows.Forms.TextBox();
			this.lblPositionZ = new System.Windows.Forms.Label();
			this.txtYPos = new System.Windows.Forms.TextBox();
			this.lblPositionY = new System.Windows.Forms.Label();
			this.txtXPos = new System.Windows.Forms.TextBox();
			this.lblPositionX = new System.Windows.Forms.Label();
			this.lblCameraPosition = new System.Windows.Forms.Label();
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
			this.splitContainer1.Panel1.Controls.Add(this.lblOrientationZ);
			this.splitContainer1.Panel1.Controls.Add(this.txtYOri);
			this.splitContainer1.Panel1.Controls.Add(this.lblOrientationY);
			this.splitContainer1.Panel1.Controls.Add(this.txtXOri);
			this.splitContainer1.Panel1.Controls.Add(this.lblOrientationX);
			this.splitContainer1.Panel1.Controls.Add(this.lblCameraOrientation);
			this.splitContainer1.Panel1.Controls.Add(this.txtZPos);
			this.splitContainer1.Panel1.Controls.Add(this.lblPositionZ);
			this.splitContainer1.Panel1.Controls.Add(this.txtYPos);
			this.splitContainer1.Panel1.Controls.Add(this.lblPositionY);
			this.splitContainer1.Panel1.Controls.Add(this.txtXPos);
			this.splitContainer1.Panel1.Controls.Add(this.lblPositionX);
			this.splitContainer1.Panel1.Controls.Add(this.lblCameraPosition);
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
			// lblOrientationZ
			// 
			this.lblOrientationZ.Location = new System.Drawing.Point(4, 175);
			this.lblOrientationZ.Name = "lblOrientationZ";
			this.lblOrientationZ.Size = new System.Drawing.Size(55, 18);
			this.lblOrientationZ.TabIndex = 12;
			this.lblOrientationZ.Text = "Z";
			this.lblOrientationZ.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtYOri
			// 
			this.txtYOri.Enabled = false;
			this.txtYOri.Location = new System.Drawing.Point(65, 146);
			this.txtYOri.Name = "txtYOri";
			this.txtYOri.Size = new System.Drawing.Size(62, 20);
			this.txtYOri.TabIndex = 11;
			// 
			// lblOrientationY
			// 
			this.lblOrientationY.Location = new System.Drawing.Point(4, 149);
			this.lblOrientationY.Name = "lblOrientationY";
			this.lblOrientationY.Size = new System.Drawing.Size(55, 18);
			this.lblOrientationY.TabIndex = 10;
			this.lblOrientationY.Text = "Y";
			this.lblOrientationY.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtXOri
			// 
			this.txtXOri.Enabled = false;
			this.txtXOri.Location = new System.Drawing.Point(65, 120);
			this.txtXOri.Name = "txtXOri";
			this.txtXOri.Size = new System.Drawing.Size(62, 20);
			this.txtXOri.TabIndex = 9;
			// 
			// lblOrientationX
			// 
			this.lblOrientationX.Location = new System.Drawing.Point(4, 123);
			this.lblOrientationX.Name = "lblOrientationX";
			this.lblOrientationX.Size = new System.Drawing.Size(55, 18);
			this.lblOrientationX.TabIndex = 8;
			this.lblOrientationX.Text = "X";
			this.lblOrientationX.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCameraOrientation
			// 
			this.lblCameraOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCameraOrientation.Location = new System.Drawing.Point(3, 101);
			this.lblCameraOrientation.Name = "lblCameraOrientation";
			this.lblCameraOrientation.Size = new System.Drawing.Size(124, 18);
			this.lblCameraOrientation.TabIndex = 7;
			this.lblCameraOrientation.Text = "Camera Orientation";
			// 
			// txtZPos
			// 
			this.txtZPos.Enabled = false;
			this.txtZPos.Location = new System.Drawing.Point(65, 71);
			this.txtZPos.Name = "txtZPos";
			this.txtZPos.Size = new System.Drawing.Size(62, 20);
			this.txtZPos.TabIndex = 6;
			// 
			// lblPositionZ
			// 
			this.lblPositionZ.Location = new System.Drawing.Point(4, 74);
			this.lblPositionZ.Name = "lblPositionZ";
			this.lblPositionZ.Size = new System.Drawing.Size(55, 18);
			this.lblPositionZ.TabIndex = 5;
			this.lblPositionZ.Text = "Z";
			this.lblPositionZ.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtYPos
			// 
			this.txtYPos.Enabled = false;
			this.txtYPos.Location = new System.Drawing.Point(65, 45);
			this.txtYPos.Name = "txtYPos";
			this.txtYPos.Size = new System.Drawing.Size(62, 20);
			this.txtYPos.TabIndex = 4;
			// 
			// lblPositionY
			// 
			this.lblPositionY.Location = new System.Drawing.Point(4, 48);
			this.lblPositionY.Name = "lblPositionY";
			this.lblPositionY.Size = new System.Drawing.Size(55, 18);
			this.lblPositionY.TabIndex = 3;
			this.lblPositionY.Text = "Y";
			this.lblPositionY.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtXPos
			// 
			this.txtXPos.Enabled = false;
			this.txtXPos.Location = new System.Drawing.Point(65, 19);
			this.txtXPos.Name = "txtXPos";
			this.txtXPos.Size = new System.Drawing.Size(62, 20);
			this.txtXPos.TabIndex = 2;
			// 
			// lblPositionX
			// 
			this.lblPositionX.Location = new System.Drawing.Point(4, 22);
			this.lblPositionX.Name = "lblPositionX";
			this.lblPositionX.Size = new System.Drawing.Size(55, 18);
			this.lblPositionX.TabIndex = 1;
			this.lblPositionX.Text = "X";
			this.lblPositionX.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCameraPosition
			// 
			this.lblCameraPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCameraPosition.Location = new System.Drawing.Point(3, 0);
			this.lblCameraPosition.Name = "lblCameraPosition";
			this.lblCameraPosition.Size = new System.Drawing.Size(124, 18);
			this.lblCameraPosition.TabIndex = 0;
			this.lblCameraPosition.Text = "Camera Position";
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
