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
    	//Data fields
        Field field;
        int DialogId;
        int ScriptId;
        int EntityId;
        int AkaoId;
        //OpenTK variables
    	bool loaded;
        int pgmId;
        int vsId;
        int fsId;
        int attribute_vcol;
        int attribute_vpos;
        int uniform_mview;
        int vbo_position;
        int vbo_color;
        int ibo_elements;
        int vbo_mview;
        Vector3[] vertdata;
        Vector3[] coldata;
		List<Volume> objects = new List<Volume>();
        int[] indicedata;
        float time = 0.0f;
        //Constructor
        public frmMain()
        {
            InitializeComponent();
            DialogId = 0;
            ScriptId = 0;
            AkaoId = 0;
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
	    private void InitProgram()
	    {
			objects.Add(new Cube());
            objects.Add(new Cube());            
	    	pgmId = GL.CreateProgram();
	    	LoadShader(@"Shaders\vs.glsl",ShaderType.VertexShader,pgmId, out vsId);
	    	LoadShader(@"Shaders\fs.glsl",ShaderType.FragmentShader,pgmId, out fsId);
	    	GL.LinkProgram(pgmId);
	    	Console.WriteLine(GL.GetProgramInfoLog(pgmId));
	    	attribute_vpos = GL.GetAttribLocation(pgmId, "vPosition");
	    	attribute_vcol = GL.GetAttribLocation(pgmId, "vColor");
	    	uniform_mview = GL.GetUniformLocation(pgmId, "modelview");
			if (attribute_vpos == -1 || attribute_vcol == -1 || uniform_mview == -1)
            {
                Console.WriteLine("Error binding attributes");
            }
			GL.GenBuffers(1, out vbo_position);
			GL.GenBuffers(1, out vbo_color);
			GL.GenBuffers(1, out vbo_mview);
			GL.GenBuffers(1, out ibo_elements);
	    }
	    private void LoadShader(String filename, ShaderType type, int program, out int address)
	    {
	    	address = GL.CreateShader(type);
	    	using(StreamReader sr = new StreamReader(filename))
	    	{
	    		GL.ShaderSource(address, sr.ReadToEnd());
	    	}
	    	GL.CompileShader(address);
	    	GL.AttachShader(program,address);
	    	Console.WriteLine(GL.GetShaderInfoLog(address));
	    }
	    private void UpdateFrame()
	    {
	    	if(!loaded)
	    		return;
            List<Vector3> verts = new List<Vector3>();
            List<int> inds = new List<int>();
            List<Vector3> colors = new List<Vector3>();
            int vertcount = 0;
            foreach (Volume v in objects)
            {
                verts.AddRange(v.GetVerts().ToList());
                inds.AddRange(v.GetIndices(vertcount).ToList());
                colors.AddRange(v.GetColorData().ToList());
                vertcount += v.VertCount;
            }
            vertdata = verts.ToArray();
            indicedata = inds.ToArray();
            coldata = colors.ToArray();

	    	GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_position);
	    	GL.BufferData<Vector3>(BufferTarget.ArrayBuffer,(IntPtr)(vertdata.Length * Vector3.SizeInBytes),vertdata,BufferUsageHint.StaticDraw);
	    	GL.VertexAttribPointer(attribute_vpos,3,VertexAttribPointerType.Float,false,0,0);
	    	
	    	GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_color);
	    	GL.BufferData<Vector3>(BufferTarget.ArrayBuffer,(IntPtr)(coldata.Length * Vector3.SizeInBytes),coldata,BufferUsageHint.StaticDraw);
	    	GL.VertexAttribPointer(attribute_vcol,3,VertexAttribPointerType.Float,true,0,0);

	    	GL.BindBuffer(BufferTarget.ElementArrayBuffer, ibo_elements);
	    	GL.BufferData(BufferTarget.ElementArrayBuffer,(IntPtr)(indicedata.Length * sizeof(int)),indicedata,BufferUsageHint.StaticDraw);
	    	
	    	time += 0.2f;
			objects[0].Position = new Vector3(0.3f, -0.5f + (float) Math.Sin(time/4), -3.0f);
            objects[0].Rotation = new Vector3(0.55f * time, 0.25f * time, 0);
            objects[0].Scale = new Vector3(0.1f, 0.1f, 0.1f);
 
            objects[1].Position = new Vector3(-1f, 0.5f + (float)Math.Cos(time/4), -2.0f);
            objects[1].Rotation = new Vector3(-0.25f * time, -0.35f * time, 0);
            objects[1].Scale = new Vector3(0.25f, 0.25f, 0.25f);
            
	    	foreach (Volume v in objects)
            {
                v.CalculateModelMatrix();
                v.ViewProjectionMatrix = Matrix4.CreatePerspectiveFieldOfView(1.3f, ClientSize.Width / (float)ClientSize.Height, 1.0f, 40.0f);
                v.ModelViewProjectionMatrix = v.ModelMatrix * v.ViewProjectionMatrix;
            }
	    	GL.UseProgram(pgmId);
	    	GL.BindBuffer(BufferTarget.ArrayBuffer,0);
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
		private void GlControl1Load(object sender, EventArgs e)
		{
			InitProgram();
			loaded = true;
			timer1.Enabled = true;
			timer1.Start();
			UpdateFrame();
			GL.ClearColor(Color.CornflowerBlue);
			GL.PointSize(5f);
		}
		private void GlControl1Resize(object sender, EventArgs e)
		{
			if(!loaded)
				return;
		}
		private void GlControl1Paint(object sender, PaintEventArgs e)
		{
			if(!loaded)
				return;
			GL.Viewport(0,0,glControl1.Width,glControl1.Height);
			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
			GL.Enable(EnableCap.DepthTest);
			GL.EnableVertexAttribArray(attribute_vpos);
			GL.EnableVertexAttribArray(attribute_vcol);
			int indiceat = 0;
			foreach(Volume v in objects)
			{
				GL.UniformMatrix4(uniform_mview,false,ref v.ModelViewProjectionMatrix);
				GL.DrawElements(PrimitiveType.Triangles, v.IndiceCount, DrawElementsType.UnsignedInt, indiceat * sizeof(uint));
				indiceat += v.IndiceCount;
			}
			GL.DrawElements(PrimitiveType.Triangles,indicedata.Length,DrawElementsType.UnsignedInt,0);
			GL.DisableVertexAttribArray(attribute_vpos);
			GL.DisableVertexAttribArray(attribute_vcol);
			GL.Flush();
			glControl1.SwapBuffers();
		}
		private void Timer1Tick(object sender, EventArgs e)
		{
			UpdateFrame();
			glControl1.Invalidate();
		}
	#endregion

    }
}
