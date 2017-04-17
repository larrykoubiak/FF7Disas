using System;
using OpenTK;
using System.Collections.Generic;

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
	
	public class ColorCube : Cube
	{
		Vector3 Color = new Vector3(1,1,1);
		
		public ColorCube(Vector3 color) : base() {
			Color = color;
		}
		
		public override Vector3[] GetColorData()
		{
			return new Vector3[] {
				Color,
				Color,
				Color,
				Color,
				Color,
				Color,
				Color,
				Color
			};
		}
	}
	
	public class Tetra : Volume
	{
		Vector3 PointApex;
		Vector3 PointA;
		Vector3 PointB;
		Vector3 PointC;
		
		public Tetra(Vector3 apex, Vector3 a, Vector3 b, Vector3 c)
		{
			PointApex = apex;
			PointA = a;
			PointB = b;
			PointC = c;
			
			VertCount = 4;
			IndiceCount = 12;
			ColorDataCount = 4;
		}
		
		public List<Tetra> Divide(int n=0)
		{
			if(n==0)
			{
				return new List<Tetra>(new Tetra[] { this });
			}
			else
			{
				Vector3 halfa = (PointApex + PointA) / 2.0f;
				Vector3 halfb = (PointApex + PointB) / 2.0f;
				Vector3 halfc = (PointApex + PointC) / 2.0f;
				
				Vector3 halfab = (PointA + PointB) / 2.0f;
				Vector3 halfbc = (PointB + PointC) / 2.0f;
				Vector3 halfac = (PointA + PointC) / 2.0f;
				
				Tetra t1 = new Tetra(PointApex, halfa,halfb,halfc);
				Tetra t2 = new Tetra(halfa, PointA, halfab, halfac);
				Tetra t3 = new Tetra(halfb,halfab,PointB, halfbc);
				Tetra t4 = new Tetra(halfc,halfac, halfbc, PointC);
				
				List<Tetra> output = new List<Tetra>();
				
				output.AddRange(t1.Divide(n-1));
				output.AddRange(t2.Divide(n-1));
				output.AddRange(t3.Divide(n-1));
				output.AddRange(t4.Divide(n-1));
				
				return output;
			}
		}
		
		public override Vector3[] GetVerts()
		{
			return new Vector3[] {PointApex,PointA,PointB,PointC};
		}
		
		public override int[] GetIndices(int offset = 0)
		{
			int[] inds = new int[] {
				1,3,2,
				0,1,2,
				0,2,3,
				0,3,1
			};
			
			if(offset != 0)
			{
				for(int i=0;i<inds.Length;i++)
				{
					inds[i] += offset;
				}
			}
			
			return inds;
		}
		
		public override Vector3[] GetColorData()
		{
			return new Vector3[] {new Vector3(1f,0f,0f), new Vector3(0f,1f,0f), new Vector3(0f,0f,1f), new Vector3(1f,1f,0f) };
		}
		
		public override void CalculateModelMatrix()
		{
			ModelMatrix = 
				Matrix4.CreateScale(Scale) * 
				Matrix4.CreateRotationX(Rotation.X) * 
				Matrix4.CreateRotationY(Rotation.Y) * 
				Matrix4.CreateRotationZ(Rotation.Z) *
				Matrix4.CreateTranslation(Position);
		}
	}

	public class Sierpinski : Volume
	{
		private List<Vector3> verts = new List<Vector3>();
		private List<int> indices = new List<int>();
		private List<Vector3> colors = new List<Vector3>();
		
		public Sierpinski(int numSubdivisions = 1)
		{
			int NumTris = (int)Math.Pow(4,numSubdivisions + 1);
			VertCount = NumTris;
			ColorDataCount = NumTris;
			IndiceCount = 3 * NumTris;
			
			Tetra twhole = new Tetra(
				new Vector3(0.0f,0.0f,1.0f),
				new Vector3(0.943f,0.0f, -0.333f),
				new Vector3(-0.471f,0.816f,-0.333f),
				new Vector3(-0.471f,-0.816f,-0.333f));
			
			List<Tetra> allTets = twhole.Divide(numSubdivisions);
			
			int offset=0;
			foreach (Tetra t in allTets) {
				verts.AddRange(t.GetVerts());
				indices.AddRange(t.GetIndices(offset * 4));
				colors.AddRange(t.GetColorData());
				offset++;
			}
		}
		
		public override Vector3[] GetVerts()
		{
			return verts.ToArray();
		}
		
		public override Vector3[] GetColorData()
		{
			return colors.ToArray();
		}
		
		public override int[] GetIndices(int offset = 0)
		{
			int[] inds = indices.ToArray();
			
			if(offset !=0)
			{
				for(int i=0; i< inds.Length; i++)
				{
					inds[i] += offset;
				}
			}
			
			return inds;
		}
		
		public override void CalculateModelMatrix()
		{
			ModelMatrix = 
				Matrix4.CreateScale(Scale) *
				Matrix4.CreateRotationX(Rotation.X) *
				Matrix4.CreateRotationY(Rotation.Y) * 
				Matrix4.CreateRotationZ(Rotation.Z) *
				Matrix4.CreateTranslation(Position);
		}
	}
}
