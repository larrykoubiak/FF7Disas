/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 27/04/2017
 * Time: 17:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using OpenTK.Graphics.OpenGL;

namespace TKView
{
	/// <summary>
	/// Description of UniformInfo.
	/// </summary>
	public class UniformInfo
	{
		public String Name = "";
		public int Address = -1;
		public int Size= 0;
		public ActiveUniformType Type;
		public UniformInfo()
		{
		}
	}
}
