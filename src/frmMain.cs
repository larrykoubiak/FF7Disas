using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using TKView;
using OpenTK;

namespace FF7Viewer
{
    public partial class frmMain : Form
    {
    #region Fields + Constructor
    	//Data fields
        Field field;
        MIM mim;
        Bitmap tilemap;
        int DialogId;
        int ScriptId;
        int EntityId;
        int AkaoId;
        TKView.TKView tv;
        Random rand;
        //Constructor
        public frmMain()
        {
            InitializeComponent();
            DialogId = 0;
            ScriptId = 0;
            AkaoId = 0;	
            rand = new Random();
            tv = new TKView.TKView();
            tv.Dock = DockStyle.Fill;
            pnlTK.Controls.Add(tv);
        }
    #endregion
    #region Methods
        private void OpenDatFile()
        {
            MemoryStream fieldStream;
            FieldReader fieldReader;
            MemoryStream mimStream;
            MIMReader mimReader;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DialogId = 0;
                EntityId = 0;
                ScriptId = 0;
                string fieldFilename = openFileDialog1.FileName;
                string mimFileName = Path.Combine(Path.GetDirectoryName(fieldFilename),Path.GetFileNameWithoutExtension(fieldFilename) + ".MIM");
                fieldStream = LZS.unLZS(fieldFilename);
                fieldReader = new FieldReader();
                field = fieldReader.ReadFieldFile(fieldStream);
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
                if(File.Exists(mimFileName))
                {
	                mimStream = LZS.unLZS(mimFileName);
	                mimReader = new MIMReader();
	                mim = mimReader.ReadMIMFile(mimStream);
	                RefreshTileMap();
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
        	tv.objects.Clear();
        	for(int i=0; i <field.Walkmesh.NoS;i++)
        	{
        		Sector s = field.Walkmesh.Sectors[i];
        		string[] items = new string[9];
        		for(int j=0; j < 3;j++)
        		{
        			items[(3*j)+0] = s.Vertices[j].X.ToString();
        			items[(3*j)+1] = s.Vertices[j].Y.ToString();      			
        			items[(3*j)+2] = s.Vertices[j].Z.ToString();
        			s.Vertices[j].Z *= -1;
        			s.Vertices[j] *= 0.001f;
        		}
        		idx = dgvWalkMesh.Rows.Add(items);        		
        		dgvWalkMesh.Rows[idx].HeaderCell.Value = i.ToString();
        		s.Position = Vector3.One;
        		tv.objects.Add(s);
        	}
        }
        private void RefreshTileMap()
        {
        	Brush brush;
        	Color color;
        	tilemap = new Bitmap(1024,512,PixelFormat.Format32bppArgb);
        	Graphics gBmp = Graphics.FromImage(tilemap);
        	gBmp.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
        	gBmp.FillRectangle(Brushes.Black,0,0,1024,512);
        	gBmp.Dispose();
        	//draw CLUT
        	for(int i=0;i<mim.Clut.Height;i++)
        	{
        		for(int j=0;j<mim.Clut[i].Entries.Length;j++)
        		{
        			color = mim.Clut[i].Entries[j].Color;
        			tilemap.SetPixel(mim.Clut.X+j,mim.Clut.Y+i,color);
        		}
        	}
        	//draw textures
        	foreach(Texture t in mim.Textures)
        	{
        		for(int y =0;y<t.Height;y++)
        		{
        			for(int x=0;x<t.Width;x++)
        			{
        				color = mim.Clut[1].Entries[t.Pixels[(y*t.Width) + x] & 0xFF].Color;
        				tilemap.SetPixel(t.X + x,t.Y + y,color);
        			}
        		}
        	}
        	pbTileMap.Image = tilemap;
        	pbTileMap.Invalidate();
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
		void SaveTilemapToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				tilemap.Save(saveFileDialog1.FileName);
			}
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
		private void BtnPrevAKAOClick(object sender, EventArgs e)
		{
			this.AkaoId -=1;
			RefreshAKAO();
		}
		private void BtnNextAKAOClick(object sender, EventArgs e)
		{
			this.AkaoId +=1;
			RefreshAKAO();
		}
		void PbTileMapPaint(object sender, PaintEventArgs e)
		{
/*        	if(mim !=null)
        	{
        		pbTileMap.Image = tilemap;
        		e.Graphics.DrawImage(tilemap,0,0);
        		pbTileMap.SizeMode = PictureBoxSizeMode.Zoom;
        	}*/
		}
		void PbTileMapResize(object sender, EventArgs e)
		{
			pbTileMap.Invalidate();
		}


	#endregion

    }
}
