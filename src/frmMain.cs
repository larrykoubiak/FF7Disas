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
        public Field field;
        MIM mim;
        Bitmap mimtexture;
        Bitmap tilemap;
        int DialogId;
        int ScriptId;
        int EntityId;
        int AkaoId;
        int PaletteId;

        Random rand;
        //Constructor
        public frmMain()
        {
            InitializeComponent();
            DialogId = 0;
            ScriptId = 0;
            AkaoId = 0;
            PaletteId = 0;
            rand = new Random();
         
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
                AkaoId = 0;
                PaletteId = 0;
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
	                RefreshMIMTexture();
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
        	tabControl1.SelectedTab = tabControl1.TabPages["tpWalkmesh"];
        	tv.objects.Clear();
        	tv.ActiveShader = "default";
        	tv.Camera.Position = Vector3.Zero;
        	tv.Camera.Orientation = new Vector3((float)Math.PI,0f,0f);
        	for(int i=0; i <field.Walkmesh.NoS;i++)
        	{
        		Sector s = field.Walkmesh.Sectors[i];
        		for(int j=0; j < 3;j++)
        		{
        			s.Vertices[j].Z *= -1;
        			s.Vertices[j] = Vector3.Divide(s.Vertices[j],4096f);
        		}
        		s.Position = Vector3.Zero;
        		tv.objects.Add(s);
        	}
        }
        private void RefreshMIMTexture()
        {
        	Color color;
        	mimtexture = new Bitmap(1664,512,PixelFormat.Format32bppArgb);
        	Graphics gBmp = Graphics.FromImage(mimtexture);
        	gBmp.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
        	gBmp.FillRectangle(Brushes.Black,0,0,1664,512);
        	gBmp.Dispose();
        	PaletteId = Math.Max(0,PaletteId);
        	PaletteId = Math.Min(mim.Clut.Palettes.Length-1,PaletteId);
        	txtPaletteId.Text = PaletteId.ToString("00");
        	//draw CLUT
        	for(int i=0;i<mim.Clut.Height;i++)
        	{
        		for(int j=0;j<mim.Clut[i].Entries.Length;j++)
        		{
        			color = mim.Clut[i].Entries[j].Color;
        			mimtexture.SetPixel(mim.Clut.X+j,mim.Clut.Y+i,color);
        		}
        	}
        	//draw textures
        	foreach(Texture t in mim.Textures)
        	{
        		for(int y =0;y<t.Height;y++)
        		{
        			for(int x=0;x<t.Width;x++)
        			{
        				int pixelidx = (y*t.Width) + x;
        				color = mim.Clut[PaletteId].Entries[t.Pixels[pixelidx] & 0xFF].Color;
        				mimtexture.SetPixel(t.X + (x*2),t.Y + y,color);
        				color = mim.Clut[PaletteId].Entries[t.Pixels[pixelidx] >> 8].Color;
        				mimtexture.SetPixel(t.X + (x*2) + 1,t.Y + y,color);
        			}
        		}
        	}
        	pbMIMTexture.Image = mimtexture;
        	pbMIMTexture.Invalidate();
        }
        private void RefreshTileMap()
        {
        	tilemap = new Bitmap(field.TileMap.Width,field.TileMap.Height,PixelFormat.Format32bppArgb);
        	Graphics gBmp = Graphics.FromImage(tilemap);
        	gBmp.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
        	gBmp.FillRectangle(Brushes.Black,0,0,field.TileMap.Width,field.TileMap.Height);
        	gBmp.Dispose();
        	Color transparentcolor = Color.FromArgb(255,0,0,0);
        	bool transparent;
        	if(chkBackground.Checked)
        	{
        		foreach(LayerPage l in field.TileMap.Layers[0].LayerPages)
	        	{
	        		TexturePageInfo tpi = field.TileMap.TexturePageInfos[l.TexturePageId];
	        		foreach(LayerInfo li in l.LayerInfos)
	        		{
	        			foreach(TileInfo ti in li.Tiles)
	        			{        				
			        		PaletteId = ti.ClutNumber;
			        		for(int offsety=0;offsety<16;offsety++)
			        		{
			        			for(int offsetx=0;offsetx<16;offsetx+=2)
			        			{
			        				Texture t = mim.Textures[tpi.PageY];
			        				int sourcey = ti.TexPageSourceY+offsety;
			        				int sourcex = (ti.TexPageSourceX+offsetx) / 2 + ((tpi.PageX*64)-t.X);
			        				int destx = ti.DestinationX - field.TileMap.OriginX + offsetx;
			        				int desty = ti.DestinationY - field.TileMap.OriginY + offsety;
			        				int pixelidx = (sourcey*t.Width) + sourcex;
			        				int pixel1 = t.Pixels[pixelidx] & 0xFF;
			        				int pixel2 = t.Pixels[pixelidx] >> 8;
			        				Color color1 = mim.Clut[PaletteId].Entries[pixel1].Color;
			        				Color color2 = mim.Clut[PaletteId].Entries[pixel2].Color;
			        				transparent = color1.Equals(transparentcolor) ^ mim.Clut[PaletteId].Entries[pixel1].STP;
			        				if(!transparent)
			        					tilemap.SetPixel(destx,desty,color1);
			        				transparent = color2.Equals(transparentcolor) ^ mim.Clut[PaletteId].Entries[pixel2].STP;
			        				if(!transparent)
			        					tilemap.SetPixel(destx + 1,desty,color2);			        					
			        			}
			        		}        				
	        			}
	        		}
	        	}        		
        	}
        	if(chkSprites.Checked)
        	{
				foreach(SpriteTileInfo si in field.TileMap.SpriteTileInfos)
				{        				
	        		PaletteId = si.ClutNumber;
	        		TexturePageInfo tpi = si.SpriteTP_Blend;
	        		for(int offsety=0;offsety<16;offsety++)
	        		{
	        			for(int offsetx=0;offsetx<16;offsetx+=2)
	        			{
	        				Texture t = mim.Textures[tpi.PageY];
	        				int sourcey = si.TexPageSourceY+offsety;
	        				int sourcex = (si.TexPageSourceX+offsetx) / 2 + ((tpi.PageX*64)-t.X);
							int destx = si.DestinationX - field.TileMap.OriginX  + offsetx;
							int desty = si.DestinationY - field.TileMap.OriginY + offsety;
	        				int pixelidx = (sourcey*t.Width) + sourcex;
	        				int pixel1 = t.Pixels[pixelidx] & 0xFF;
	        				int pixel2 = t.Pixels[pixelidx] >> 8;
	        				Color color1 = mim.Clut[PaletteId].Entries[pixel1].Color;
	        				Color color2 = mim.Clut[PaletteId].Entries[pixel2].Color;
	        				if((si.Parameter & 0x80)==0x80)
	        				{
	        					Color oldcolor1 = tilemap.GetPixel(destx,desty);
	        					Color oldcolor2 = tilemap.GetPixel(destx +1,desty);
	        					Color newcolor1 = Color.Black, newcolor2 = Color.Black;
	        					if(tpi.BlendingMode==1 || tpi.BlendingMode == 3)
	        					{
		        					newcolor1 = Color.FromArgb(255,
	        						                           Math.Min(255,oldcolor1.R + color1.R),
		    					                               Math.Min(255,oldcolor1.G + color1.G),
		    					                               Math.Min(255,oldcolor1.B + color1.B));
		        					newcolor2 = Color.FromArgb(255,
		        					                           Math.Min(255,oldcolor2.R + color2.R),
		        					                           Math.Min(255,oldcolor2.G + color2.G),
		        					                           Math.Min(255,oldcolor2.B + color2.B));
	        					}
	        					else if (tpi.BlendingMode==2)
	        					{
		        					newcolor1 = Color.FromArgb(255,
		        					                           Math.Max(0,oldcolor1.R - color1.R),
		        					                           Math.Max(0,oldcolor1.G - color1.G),
		        					                           Math.Max(0,oldcolor1.B - color1.B));
		        					newcolor2 = Color.FromArgb(255,
		        					                           Math.Max(0,oldcolor2.R - color2.R),
		        					                           Math.Max(0,oldcolor2.G - color2.G),
		        					                           Math.Max(0,oldcolor2.B - color2.B));        						
	        					}
	        					tilemap.SetPixel(destx,desty,newcolor1);
	        					tilemap.SetPixel(destx + 1,desty,newcolor2);      						
	        				}
	        				else
	        				{
		        				transparent = color1.Equals(transparentcolor) ^ mim.Clut[PaletteId].Entries[pixel1].STP;
		        				if(!transparent)
		        					tilemap.SetPixel(destx,desty,color1);
		        				transparent = color2.Equals(transparentcolor) ^ mim.Clut[PaletteId].Entries[pixel2].STP;
		        				if(!transparent)
		        					tilemap.SetPixel(destx + 1,desty,color2);
	        				}
	        			}
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

        void SaveFieldToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "XML Files|*.xml";
			if(saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				XmlSerializer serial = new XmlSerializer(typeof(TileMap));
				FileStream stream = new FileStream(saveFileDialog1.FileName,FileMode.Create);
				serial.Serialize(stream,this.field.TileMap);
				stream.Close();
			}			
		}
		void SaveMIMTextureToolStripMenuItemClick(object sender, EventArgs e)
		{
			string filename;
			Color color;
			saveFileDialog1.Filter = "PNG Images|*.png";
			if(saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				for(int i=0;i<mim.Clut.Palettes.Length;i++)
				{
		        	mimtexture = new Bitmap(1664,512,PixelFormat.Format32bppArgb);
		        	Graphics gBmp = Graphics.FromImage(mimtexture);
		        	gBmp.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
		        	gBmp.FillRectangle(Brushes.Black,0,0,1664,512);
		        	gBmp.Dispose();
					foreach(Texture t in mim.Textures)
		        	{
		        		for(int y =0;y<t.Height;y++)
		        		{
		        			for(int x=0;x<t.Width;x++)
		        			{
		        				int pixelidx = (y*t.Width) + x;
		        				color = mim.Clut[i].Entries[t.Pixels[pixelidx] & 0xFF].Color;
		        				mimtexture.SetPixel(t.X + (x*2),t.Y + y,color);
		        				color = mim.Clut[i].Entries[t.Pixels[pixelidx] >> 8].Color;
		        				mimtexture.SetPixel(t.X + (x*2) + 1,t.Y + y,color);
		        			}
		        		}
		        	}
					filename = Path.Combine(Path.GetDirectoryName(saveFileDialog1.FileName),Path.GetFileNameWithoutExtension(saveFileDialog1.FileName) + i.ToString("00") + ".png");
					mimtexture.Save(filename);			
				}
			}
			RefreshMIMTexture();
		}

        void SaveTilemapToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "PNG Images|*.png";
			if(saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				tilemap.Save(saveFileDialog1.FileName);
			}
		}
		void SaveCLUTToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "XML Files|*.xml";
			if(saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				XmlSerializer serial = new XmlSerializer(typeof(CLUT));
				FileStream stream = new FileStream(saveFileDialog1.FileName,FileMode.Create);
				serial.Serialize(stream,this.mim.Clut);
				stream.Close();
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
		
		void PbMIMTextureResize(object sender, EventArgs e)
		{
			pbMIMTexture.Invalidate();
		}
		void BtnPrevPaletteClick(object sender, EventArgs e)
		{
			this.PaletteId -=1;
			RefreshMIMTexture();
		}
		void BtnNextPaletteClick(object sender, EventArgs e)
		{
			this.PaletteId +=1;
			RefreshMIMTexture();
		}
		void ChkBackgroundCheckedChanged(object sender, EventArgs e)
		{
			RefreshTileMap();
		}
		void ChkSpritesCheckedChanged(object sender, EventArgs e)
		{
			RefreshTileMap();
		}




	#endregion

    }
}
