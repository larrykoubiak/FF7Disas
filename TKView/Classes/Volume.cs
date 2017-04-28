using System;
using OpenTK;
using System.Collections.Generic;

namespace TKView
{	
	public abstract class Volume
    {
        public Vector3 Position = Vector3.Zero;
        public Vector3 Rotation = Vector3.Zero;
        public Vector3 Scale = Vector3.One;
        public Matrix4 ModelMatrix = Matrix4.Identity;
        public Matrix4 ViewProjectionMatrix = Matrix4.Identity;
        public Matrix4 ModelViewProjectionMatrix = Matrix4.Identity;
        
        public virtual int VertCount {get;set;}
        public virtual int IndiceCount {get;set;}
        public virtual int ColorDataCount {get;set;}
        public bool IsTextured = false;
        public int TextureId;
        public int TextureCoordCount;
     
        public abstract Vector3[] GetVerts();
        public abstract int[] GetIndices(int offset = 0);
        public abstract Vector3[] GetColorData();
        public abstract void CalculateModelMatrix();
        public abstract Vector2[] GetTextureCoords();
    }
}
