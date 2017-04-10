using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace FF7Viewer
{
    public partial class frmMain : Form
    {
    #region Fields + Constructor
    	bool loaded;
        Field field;
        int DialogId;
        int ScriptId;
        int EntityId;
        int AkaoId;
        public frmMain()
        {
            InitializeComponent();
            DialogId = 0;
            ScriptId = 0;
            AkaoId = 0;
        }
    #endregion
    #region Events
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDatFile();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UnLZSToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				MemoryStream stream;
				FileStream fstream = new FileStream("unLZS_" + openFileDialog1.SafeFileName, FileMode.Create);
				stream = LZS.unLZS(openFileDialog1.FileName);
				stream.WriteTo(fstream);
				fstream.Close();
				stream.Close();
			}
		}
        private void btnPrevDialog_Click(object sender, EventArgs e)
        {
            this.DialogId -= 1;
            RefreshDialog();
        }
        private void btnNextDialog_Click(object sender, EventArgs e)
        {
            this.DialogId += 1;
            RefreshDialog();
        }
        private void lstEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntityId = this.lstEntities.SelectedIndex;
            ScriptId = 0;
            RefreshScript();
        }      
        private void btnPrevScript_Click(object sender, EventArgs e)
        {
            this.ScriptId -= 1;
            RefreshScript();
        }
        private void btnNextScript_Click(object sender, EventArgs e)
        {
            this.ScriptId += 1;
            RefreshScript();
        }
		void BtnPrevAKAOClick(object sender, EventArgs e)
		{
			this.AkaoId -=1;
			RefreshAKAO();
		}
		void BtnNextAKAOClick(object sender, EventArgs e)
		{
			this.AkaoId +=1;
			RefreshAKAO();
		}
		void GlControl1Load(object sender, EventArgs e)
		{
			loaded = true;
			GL.ClearColor(Color.CornflowerBlue);
			SetupViewport();
		}
		void GlControl1Resize(object sender, EventArgs e)
		{
			if(!loaded)
				return;
		}
		void GlControl1Paint(object sender, PaintEventArgs e)
		{
			if(!loaded)
				return;
			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
			GL.MatrixMode(MatrixMode.Modelview);
			GL.LoadIdentity();
			GL.Color3(Color.Yellow);
			GL.Begin(PrimitiveType.Triangles);
			GL.Vertex2(10,20);
			GL.Vertex2(100,20);
			GL.Vertex2(100,50);
			GL.End();
			glControl1.SwapBuffers();
		}
    #endregion
    #region Methods
        private void OpenDatFile()
        {
            MemoryStream stream;
            FieldReader reader;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DialogId = 0;
                EntityId = 0;
                ScriptId = 0;
                stream = LZS.unLZS(openFileDialog1.FileName);
                reader = new FieldReader();
                field = reader.ReadFieldFile(stream);
                this.txtName.Text = field.Script.Name;
                this.txtCreator.Text = field.Script.Creator;
                this.lblNbDialogs.Text = "/" + field.Script.NbDialogs.ToString();
                this.lblNbAKAO.Text = "/" + field.Script.NbAkaoOffsets.ToString();
                this.lstEntities.Items.Clear();
                for (int i = 0; i < field.Script.NbEntities; i++)
                {
                    this.lstEntities.Items.Add(field.Script.Entities[i]);
                }
                this.txtDescription.Text = "";
                RefreshDialog();
                RefreshAKAO();
                RefreshWalkmesh();
                if (field.Script.NbEntities > 0)
                {
                    this.lstEntities.SelectedItem = this.lstEntities.Items[0];
                    RefreshScript();
                }
                else
                {
                    btnPrevScript.Enabled = false;
                    btnNextScript.Enabled = false;
                }
            }
        }
        private void RefreshDialog()
        {
            //check if dialogid exists
            if (this.DialogId >= Math.Max(0,field.Script.NbDialogs - 1))
            { // end of dialogs
                this.btnNextDialog.Enabled = false;
                this.DialogId = Math.Max(0,field.Script.NbDialogs - 1);
            }
            else
            {
                this.btnNextDialog.Enabled = true;
            }
            if (this.DialogId <= 0)
            { // end of dialogs
                this.btnPrevDialog.Enabled = false;
                this.DialogId = 0;
            }
            else
            {
                this.btnPrevDialog.Enabled = true;
            }
            if (this.DialogId < field.Script.NbDialogs && this.DialogId >= 0)
            {
                string text = field.Script.Dialogs[this.DialogId];
                this.txtDialog.Text = text;
                this.txtDialogId.Text = (this.DialogId + 1).ToString("00");
            }
        }
        private void RefreshScript()
        {
            if (this.ScriptId >= 31)
            {
                this.btnNextScript.Enabled = false;
                this.ScriptId = 31;
            }
            else
            {
                this.btnNextScript.Enabled = true;
            }
            if (this.ScriptId <= 0)
            {
                this.btnPrevScript.Enabled = false;
                this.ScriptId = 0;
            }
            else
            {
                this.btnPrevScript.Enabled = true;
            }
            if (this.ScriptId < 32 && this.ScriptId >= 0)
            {
                this.txtDescription.Text = field.Script.Scripts[EntityId, ScriptId].ToString();
                this.txtScriptId.Text = (this.ScriptId + 1).ToString("00");
            }            
        }
        private void RefreshAKAO()
        {

        	if (this.AkaoId >= Math.Max(0,field.Script.NbAkaoOffsets -1))
        	{
        		this.btnNextAKAO.Enabled = false;
        		this.AkaoId = Math.Max(0,field.Script.NbAkaoOffsets -1);
        	}
        	else
        	{
        		this.btnNextAKAO.Enabled = true;
        	}
        	if (this.AkaoId <= 0)
        	{
        		this.btnPrevAKAO.Enabled = false;
        		this.AkaoId = 0;
        	}
        	else
        	{
        		this.btnPrevAKAO.Enabled = true;
        	}
        	if (this.AkaoId < field.Script.NbAkaoOffsets && this.AkaoId >= 0)
        	{
        		this.txtAKAOFrames.Text = field.Script.Akaos[this.AkaoId].ToString();
        		this.txtAKAOId.Text = (this.AkaoId + 1).ToString("00");
        	}        	
        }
        private void RefreshWalkmesh()
        {
        	int idx = 0;
        	dgvWalkMesh.Rows.Clear();
        	for(int i=0; i <field.Walkmesh.NoS;i++)
        	{
        		string[] items = new string[9];
        		for(int j=0; j < 3;j++)
        		{
        			items[(3*j)+0] = field.Walkmesh.Sectors[i].Vertices[j].X.ToString();
        			items[(3*j)+1] = field.Walkmesh.Sectors[i].Vertices[j].Y.ToString();      			
        			items[(3*j)+2] = field.Walkmesh.Sectors[i].Vertices[j].Z.ToString();
        		}
        		idx = dgvWalkMesh.Rows.Add(items);
        		dgvWalkMesh.Rows[idx].HeaderCell.Value = i.ToString();
        	}
        	glControl1.Invalidate();
        }
	    private void SetupViewport()
	    {
	      int w = glControl1.Width;
	      int h = glControl1.Height;
	      GL.MatrixMode(MatrixMode.Projection);
	      GL.LoadIdentity();
	      GL.Ortho(0, w, 0, h, -1, 1); // Bottom-left corner pixel has coordinate (0, 0)
	      GL.Viewport(0, 0, w, h); // Use all of the glControl painting area
	    }
        #endregion
    }
}
