/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 7/04/2017
 * Time: 17:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FF7Viewer
{
	/// <summary>
	/// Description of Geometry.
	/// </summary>
	public class Vertex_3S
	{
		public Int16 X {get;set;}
		public Int16 Y {get;set;}
		public Int16 Z {get;set;}
		public Int16 Res {get;set;}
		public Vertex_3S()
		{
			X = 0;
			Y = 0;
			Z = 0;
			Res = 0;
		}
		public Vertex_3S(Int16 x, Int16 y, Int16 z)
		{
			X = x;
			Y = y;
			Z = z;
			Res = z;
		}
	}
	public class Sector
	{
		public Vertex_3S[] Vertices {get;set;}
		public Sector()
		{
			Vertices = new Vertex_3S[3];
		}
		public Sector(Vertex_3S v0, Vertex_3S v1, Vertex_3S v2) : this()
		{
			Vertices[0] = v0;
			Vertices[1] = v1;
			Vertices[2] = v2;
		}
		public Sector(Vertex_3S[] vertices) : this()
		{
			Vertices = vertices;
		}
			
	}
}
