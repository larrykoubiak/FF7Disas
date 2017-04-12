using System;
using OpenTK;

namespace FF7Viewer
{
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
	
	public abstract class Volume
    {
        public Vector3 Position = Vector3.Zero;
        public Vector3 Rotation = Vector3.Zero;
        public Vector3 Scale = Vector3.One;
 
        public int VertCount;
        public int IndiceCount;
        public int ColorDataCount;
        public Matrix4 ModelMatrix = Matrix4.Identity;
        public Matrix4 ViewProjectionMatrix = Matrix4.Identity;
        public Matrix4 ModelViewProjectionMatrix = Matrix4.Identity;
 
        public abstract Vector3[] GetVerts();
        public abstract int[] GetIndices(int offset = 0);
        public abstract Vector3[] GetColorData();
        public abstract void CalculateModelMatrix();
    }
	
	public class Cube : Volume
	{
        public Cube()
        {
            VertCount = 8;
            IndiceCount = 36;
            ColorDataCount = 8;
        }
        public override Vector3[] GetVerts()
        {
            return new Vector3[] {
        		new Vector3(-0.5f, -0.5f,  -0.5f),
                new Vector3(0.5f, -0.5f,  -0.5f),
                new Vector3(0.5f, 0.5f,  -0.5f),
                new Vector3(-0.5f, 0.5f,  -0.5f),
                new Vector3(-0.5f, -0.5f,  0.5f),
                new Vector3(0.5f, -0.5f,  0.5f),
                new Vector3(0.5f, 0.5f,  0.5f),
                new Vector3(-0.5f, 0.5f,  0.5f),
            };
        }
        public override int[] GetIndices(int offset = 0)
        {
            int[] inds = new int[] {
                //left
                0, 2, 1,
                0, 3, 2,
                //back
                1, 2, 6,
                6, 5, 1,
                //right
                4, 5, 6,
                6, 7, 4,
                //top
                2, 3, 6,
                6, 3, 7,
                //front
                0, 7, 3,
                0, 4, 7,
                //bottom
                0, 1, 5,
                0, 5, 4
            };
 
            if (offset != 0)
            {
                for (int i = 0; i < inds.Length; i++)
                {
                    inds[i] += offset;
                }
            }
 
            return inds;
        }
        public override Vector3[] GetColorData()
        {
            return new Vector3[] {
                new Vector3( 1f, 0f, 0f),
                new Vector3( 0f, 0f, 1f),
                new Vector3( 0f, 1f, 0f),
                new Vector3( 1f, 0f, 0f),
                new Vector3( 0f, 0f, 1f),
                new Vector3( 0f, 1f, 0f),
                new Vector3( 1f, 0f, 0f),
                new Vector3( 0f, 0f, 1f)
            };
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
