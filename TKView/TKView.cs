using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace TKView
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class TKView : UserControl
	{
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
		public Camera Camera = new Camera();
        int[] indicedata;
        float time = 0.0f;
        Vector2 lastMousePos = new Vector2();
        KeyboardState prevkstate;
        MouseState prevmstate;
        bool CaptureControls = false;
		public List<Volume> objects = new List<Volume>();
        public TKView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	    private void InitProgram()
	    {
	    	if(LicenseManager.UsageMode == LicenseUsageMode.Runtime)
	    	{
		    	pgmId = GL.CreateProgram();
		    	if(File.Exists(@"Shaders\vs.glsl") && File.Exists(@"Shaders\vs.glsl"))
		    	{
			    	LoadShader(@"Shaders\vs.glsl",ShaderType.VertexShader,pgmId, out vsId);
			    	LoadShader(@"Shaders\fs.glsl",ShaderType.FragmentShader,pgmId, out fsId);
			    	GL.LinkProgram(pgmId);
			    	attribute_vpos = GL.GetAttribLocation(pgmId, "vPosition");
			    	attribute_vcol = GL.GetAttribLocation(pgmId, "vColor");
			    	uniform_mview = GL.GetUniformLocation(pgmId, "modelview");
					if (attribute_vpos == -1 || attribute_vcol == -1 || uniform_mview == -1)
		            {
						MessageBox.Show("Error binding attributes","",MessageBoxButtons.OK,MessageBoxIcon.Error);
		            }		    		
		    	}
				GL.GenBuffers(1, out vbo_position);
				GL.GenBuffers(1, out vbo_color);
				GL.GenBuffers(1, out vbo_mview);
				GL.GenBuffers(1, out ibo_elements);	    		
	    	}
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
	    }
	    private void UpdateFrame()
	    {
	    	if(!loaded)
	    		return;
	    	else
	    	{
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
		    	foreach (Volume v in objects)
	            {
		    		v.CalculateModelMatrix();
		    		v.ViewProjectionMatrix = Camera.GetViewMatrix() * Matrix4.CreatePerspectiveFieldOfView(1.3f, ClientSize.Width / (float)ClientSize.Height, 1.0f, 100.0f);
	                v.ModelViewProjectionMatrix = v.ModelMatrix * v.ViewProjectionMatrix;
	            }
		    	GL.UseProgram(pgmId);
		    	GL.BindBuffer(BufferTarget.ArrayBuffer,0);
		    	KeyboardState kstate = Keyboard.GetState();
		    	MouseState mstate = Mouse.GetState();
		    	Point p = glControl1.PointToScreen(Point.Empty);
				if(kstate.IsKeyDown(Key.F12) && !prevkstate.IsKeyDown(Key.F12))
				{
					CaptureControls = !CaptureControls;
					if(CaptureControls)
					{
						Cursor.Hide();
						resetCursor();						
					}
					else
					{
						Cursor.Show();						
					}
				}
		    	if(CaptureControls)
		    	{
		    		//Mouse
		    		Vector2 delta = new Vector2(prevmstate.X,prevmstate.Y) - new Vector2(mstate.X, mstate.Y);
		    		Camera.AddRotation(delta.X,delta.Y);
		    		resetCursor();
					//Keyboard
	
					if(kstate.IsKeyDown(Key.W))
					{
						Camera.Move(0f,0.1f, 0f);
					}
					else if(kstate.IsKeyDown(Key.S))
					{
						Camera.Move(0f,-0.1f,0f);
					}
					if(kstate.IsKeyDown(Key.A))
					{
						Camera.Move(-0.1f,0f,0f);
					}
					else if(kstate.IsKeyDown(Key.D))
					{
						Camera.Move(0.1f,0f,0f);
					}
					if(kstate.IsKeyDown(Key.Q))
					{
						Camera.Move(0f,0f,0.1f);
					}
					else if(kstate.IsKeyDown(Key.E))
					{
						Camera.Move(0f,0f,-0.1f);
					}
		    	}
		    	prevkstate = kstate;
		    	prevmstate = mstate;
		    	txtXPos.Text = Camera.Position.X.ToString();
		    	txtYPos.Text = Camera.Position.Y.ToString();
		    	txtZPos.Text = Camera.Position.Z.ToString();
		    	txtXOri.Text = Camera.Orientation.X.ToString();
		    	txtYOri.Text = Camera.Orientation.Y.ToString();
		    	txtZOri.Text = Camera.Orientation.Z.ToString();
	    	}

	    } 
	    private void resetCursor()
	    {
	    	OpenTK.Input.Mouse.SetPosition(glControl1.PointToScreen(Point.Empty).X + (glControl1.Bounds.Width / 2),
	    	                               glControl1.PointToScreen(Point.Empty).Y + (glControl1.Bounds.Height / 2));
	    	lastMousePos = new Vector2(OpenTK.Input.Mouse.GetState().X, OpenTK.Input.Mouse.GetState().Y);
	    }

		private void GlControl1Load(object sender, EventArgs e)
		{
			if(LicenseManager.UsageMode == LicenseUsageMode.Runtime)
			{
				InitProgram();
				loaded = true;
				timer1.Enabled = true;
				timer1.Start();
				UpdateFrame();
				GL.ClearColor(Color.CornflowerBlue);
				GL.PointSize(5f);				
			}
		}
		private void GlControl1Resize(object sender, EventArgs e)
		{
			if(!loaded)
				return;
			else
				glControl1.Invalidate();			
		}
		private void GlControl1Paint(object sender, PaintEventArgs e)
		{
			if(!loaded)
				return;
			else
			{
				GL.Viewport(0,0,glControl1.Width,glControl1.Height);
				GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
				GL.Enable(EnableCap.DepthTest);
				GL.EnableVertexAttribArray(attribute_vpos);
				GL.EnableVertexAttribArray(attribute_vcol);
				GL.PolygonMode(MaterialFace.FrontAndBack,PolygonMode.Line);
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
		}
		private void Timer1Tick(object sender, EventArgs e)
		{
			if(!loaded)
				return;
			else
			{
				UpdateFrame();
				this.Invalidate();				
			}
		}
	}
}