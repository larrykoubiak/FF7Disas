using System;
using OpenTK;

namespace TKView
{
	public class Sector : Volume
	{
		public Vector3[] Vertices {get;set;}
		public Vector3 Color{get;set;}
		public Sector()
		{
			VertCount = 3;
			IndiceCount = 3;
			ColorDataCount = 3;
			Color = new Vector3(0f,0f,0f);
			Vertices = new Vector3[VertCount];
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
		public override Vector3[] GetVerts()
		{
			return Vertices;
		}
        public override int[] GetIndices(int offset = 0)
        {
        	return new int[]{0+offset,1+offset,2+offset};
        }
        
        public override Vector3[] GetColorData()
        {
        	return new Vector3[]{Color};
        }
		public override void CalculateModelMatrix()
        {
            ModelMatrix = Matrix4.CreateScale(Scale) 
            			* Matrix4.CreateRotationX(Rotation.X) 
            			* Matrix4.CreateRotationY(Rotation.Y) 
            			* Matrix4.CreateRotationZ(Rotation.Z) 
            			* Matrix4.CreateTranslation(Position);
        }
	}
}