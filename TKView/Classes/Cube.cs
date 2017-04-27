using System;
using OpenTK;
namespace TKView
{
	/// <summary>
	/// Description of Cube.
	/// </summary>
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
        public override Vector2[] GetTextureCoords()
        {
        	return new Vector2[]{};
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
	
	public class TexturedCube : Cube
	{
		public TexturedCube() : base()
		{
			VertCount = 24;
			IndiceCount = 36;
			TextureCoordCount = 24;
		}
		
	    public override Vector2[] GetTextureCoords()
	    {
	        return new Vector2[] {
	            // left
	            new Vector2(0.0f, 0.0f),
	            new Vector2(-1.0f, 1.0f),
	            new Vector2(-1.0f, 0.0f),
	            new Vector2(0.0f, 1.0f),
	 
	            // back
	            new Vector2(0.0f, 0.0f),
	            new Vector2(0.0f, 1.0f),
	            new Vector2(-1.0f, 1.0f),
	            new Vector2(-1.0f, 0.0f),
	 
	            // right
	            new Vector2(-1.0f, 0.0f),
	            new Vector2(0.0f, 0.0f),
	            new Vector2(0.0f, 1.0f),
	            new Vector2(-1.0f, 1.0f),
	 
	            // top
	            new Vector2(0.0f, 0.0f),
	            new Vector2(0.0f, 1.0f),
	            new Vector2(-1.0f, 0.0f),
	            new Vector2(-1.0f, 1.0f),
	 
	            // front
	            new Vector2(0.0f, 0.0f),
	            new Vector2(1.0f, 1.0f),
	            new Vector2(0.0f, 1.0f),
	            new Vector2(1.0f, 0.0f),
	 
	            // bottom
	            new Vector2(0.0f, 0.0f),
	            new Vector2(0.0f, 1.0f),
	            new Vector2(-1.0f, 1.0f),
	            new Vector2(-1.0f, 0.0f)
	        };
	    }
	}
}
