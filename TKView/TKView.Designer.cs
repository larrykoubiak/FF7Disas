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
			this.glControl1 = new OpenTK.GLControl();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// glControl1
			// 
			this.glControl1.BackColor = System.Drawing.Color.Black;
			this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glControl1.Location = new System.Drawing.Point(0, 0);
			this.glControl1.Name = "glControl1";
			this.glControl1.Size = new System.Drawing.Size(542, 421);
			this.glControl1.TabIndex = 0;
			this.glControl1.VSync = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// TKView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.glControl1);
			this.Name = "TKView";
			this.Size = new System.Drawing.Size(542, 421);
			this.Load += new System.EventHandler(this.GlControl1Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl1Paint);
			this.Resize += new System.EventHandler(this.GlControl1Resize);
			this.ResumeLayout(false);

		}
	}
}
