/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 27/04/2017
 * Time: 17:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace TKView
{
	/// <summary>
	/// Description of ShaderProgram.
	/// </summary>
	public class ShaderProgram
	{
		public int ProgramId = -1;
		public int VShaderId = -1;
		public int FShaderId = -1;
		public int AttributeCount = 0;
		public int UniformCount = 0;
		public uint ibo_elements;
		public Dictionary<String,AttributeInfo> Attributes = new Dictionary<String, AttributeInfo>();
		public Dictionary<String,UniformInfo> Uniforms = new Dictionary<String, UniformInfo>();
		public Dictionary<String,uint> Buffers = new Dictionary<String,uint>();
		public ShaderProgram()
		{
			ProgramId = GL.CreateProgram();
		}
		public ShaderProgram(String vshader, String fshader, bool fromFile = false) : this()
		{
			if(fromFile)
			{
				LoadShaderFromFile(vshader, ShaderType.VertexShader);
				LoadShaderFromFile(fshader, ShaderType.FragmentShader);
			}
			else
			{
				LoadShaderFromString(vshader,ShaderType.VertexShader);
				LoadShaderFromString(fshader,ShaderType.FragmentShader);
			}
			Link();
			GenBuffers();
		}
		private void LoadShader(String code, ShaderType type, out int address)
		{
			address = GL.CreateShader(type);
			GL.ShaderSource(address,code);
			GL.CompileShader(address);
			GL.AttachShader(ProgramId, address);
			string info = GL.GetShaderInfoLog(address);
			Console.WriteLine(info);
		}
		public void LoadShaderFromString(String code, ShaderType type)
		{
			if(type==ShaderType.VertexShader)
			{
				LoadShader(code,type,out VShaderId);
			}
			else if(type==ShaderType.FragmentShader)
			{
				LoadShader(code,type,out FShaderId);
			}
		}
		public void LoadShaderFromFile(String filename, ShaderType type)
		{
			using(StreamReader sr = new StreamReader(filename))
			{
				if(type==ShaderType.VertexShader)
				{
					LoadShader(sr.ReadToEnd(),type,out VShaderId);					
				}
				else if(type==ShaderType.FragmentShader)
				{
					LoadShader(sr.ReadToEnd(),type,out FShaderId);
				}
			}
		}
		public void Link()
		{
			GL.LinkProgram(ProgramId);
			Console.WriteLine(GL.GetProgramInfoLog(ProgramId));
			GL.GetProgram(ProgramId,GetProgramParameterName.ActiveAttributes,out AttributeCount);
			GL.GetProgram(ProgramId,GetProgramParameterName.ActiveUniforms, out UniformCount);
			for(int i=0;i<AttributeCount;i++)
			{
				AttributeInfo info = new AttributeInfo();
				int length = 0;
				StringBuilder name = new StringBuilder();
				GL.GetActiveAttrib(ProgramId,i,256,out length,out info.Size,out info.Type,name);
				info.Name = name.ToString();
				info.Address = GL.GetAttribLocation(ProgramId,info.Name);
				Attributes.Add(name.ToString(),info);
			}
			for(int i=0;i<UniformCount;i++)
			{
				UniformInfo info = new UniformInfo();
				int length = 0;
				StringBuilder name = new StringBuilder();
				GL.GetActiveUniform(ProgramId,i,256,out length,out info.Size,out info.Type,name);
				info.Name = name.ToString();
				info.Address = GL.GetUniformLocation(ProgramId,info.Name);
				Uniforms.Add(name.ToString(),info);
			}
		}
		public void GenBuffers()
		{
			foreach(AttributeInfo info in Attributes.Values)
			{
				uint buffer = 0;
				GL.GenBuffers(1, out buffer);
				Buffers.Add(info.Name,buffer);
			}
			foreach(UniformInfo info in Uniforms.Values)
			{
				uint buffer = 0;
				GL.GenBuffers(1, out buffer);
				Buffers.Add(info.Name,buffer);
			}
			GL.GenBuffers(1, out ibo_elements);
			Buffers.Add("indices",ibo_elements);
		}
		public void EnableVertexAttribArrays()
		{
			foreach(AttributeInfo info in Attributes.Values)
			{
				GL.EnableVertexAttribArray(info.Address);
			}
		}
		public void DisableVertexAttribArrays()
		{
			foreach(AttributeInfo info in Attributes.Values)
			{
				GL.DisableVertexAttribArray(info.Address);
			}			
		}
		public int GetAttribute(string name)
		{
			if(Attributes.ContainsKey(name))
				return Attributes[name].Address;
			else
				return -1;
		}
		public int GetUniform(string name)
		{
			if(Uniforms.ContainsKey(name))
				return Uniforms[name].Address;
			else
				return -1;
		}
		public uint GetBuffer(string name)
		{
			if(Buffers.ContainsKey(name))
				return Buffers[name];
			else
				return 0;
		}
		
	}
}
