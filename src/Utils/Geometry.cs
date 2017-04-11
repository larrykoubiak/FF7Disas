/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 7/04/2017
 * Time: 17:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using OpenTK;

namespace FF7Viewer
{
	/// <summary>
	/// Description of Geometry.
	/// </summary>
	public class Sector
	{
		public Vector3[] Vertices {get;set;}
		public Sector()
		{
			Vertices = new Vector3[3];
		}
		public Sector(Vector3 v0, Vector3 v1, Vector3 v2) : this()
		{
			Vertices[0] = v0;
			Vertices[1] = v1;
			Vertices[2] = v2;
		}
		public Sector(Vector3[] vertices)
		{
			Vertices = vertices;
		}
	}
}
