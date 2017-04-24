/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 20/04/2017
 * Time: 12:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace FF7Viewer
{
	/// <summary>
	/// Description of Texture.
	/// </summary>
	/// 
	public class PaletteEntry
	{
		private BitVector32 vector;
		private BitVector32.Section red;
		private BitVector32.Section green;
		private BitVector32.Section blue;
		private BitVector32.Section stp;
		public PaletteEntry(UInt16 color)
		{
			vector = new BitVector32(color);
			red = BitVector32.CreateSection(31);
			green = BitVector32.CreateSection(31,red);
			blue = BitVector32.CreateSection(31,green);
			stp = BitVector32.CreateSection(1,blue);			
		}
		public UInt16 Value
		{
			get {return (UInt16)vector.Data;}
			set {vector = new BitVector32(value);}
		}
		
		public byte Red
		{
			get {return (byte)((vector[red] << 3) + (vector[red] >> 2));}
			set {vector[red] = (int)(value >> 3);}
		}
		public byte Green
		{
			get {return (byte)((vector[green] << 3) + (vector[green] >> 2));}
			set {vector[green] = (int)(value >> 3);}
		}
		public byte Blue
		{
			get {return (byte)((vector[blue] << 3) + (vector[blue] >> 2));}
			set {vector[blue] = (int)(value >> 3);}
		}
		public bool STP
		{
			get {return Convert.ToBoolean(vector[stp]);}
			set {vector[stp] = value ? 1 : 0;}
		}
		public Color Color
		{
			get 
			{
				return Color.FromArgb(255,Red,Green,Blue);
			}
			set
			{
				Red = value.R;
				Green = value.G;
				Blue = value.B;
				STP = false;
			}
		}
	}
	
	public class Palette 
	{
		public PaletteEntry[] Entries {get;set;}
		public Palette()
		{
			Entries = new PaletteEntry[256];
		}
		public Palette(int length)
		{
			Entries = new PaletteEntry[length];
		}

		public PaletteEntry this[int index]
		{
			get {return Entries[index];}
			set {Entries[index] = value;}
		}
		
	}
	
	public class CLUT
	{
		public Palette[] Palettes;
		public UInt32 Length {get;set;}
		public UInt16 X {get;set;}
		public UInt16 Y {get;set;}
		public UInt16 Width {get;set;}
		private UInt16 _height {get;set;}
		public CLUT()
		{
			Palettes = new Palette[0];
		}
		public CLUT(UInt32 length, UInt16 x, UInt16 y, UInt16 width, UInt16 height)
		{
			Palettes = new Palette[height];
			Length = length;
			X = x;
			Y = y;
			Width = width;
			_height = height;
		}
		
		public Palette this[int index]
		{
			get {return Palettes[index];}
			set {Palettes[index] = value;}
		}
		
		public UInt16 Height
		{
			get {return _height;}
			set 
			{
				_height = value;
				Palettes = new Palette[_height];
			}
		}
		
	}
	public class Texture
	{
		private UInt32 m_length;
		public UInt16[] Pixels {get;set;}
		public UInt16 X {get;set;}
		public UInt16 Y {get;set;}
		public UInt16 Width {get;set;}
		public UInt16 Height {get;set;}
		public Texture()
		{
			m_length = 0;
			Pixels = new UInt16[0];
		}
		public Texture(UInt32 length,UInt16 x, UInt16 y, UInt16 width, UInt16 height)
		{
			m_length = length;
			Pixels = new UInt16[(m_length-12)/2];
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}
		public UInt32 Length
		{
			get { return m_length;}
			set 
			{
				m_length = value;
				if(m_length>0)
				{
					Pixels = new UInt16[(m_length-12)/2];
				}
			}
		}
	}
	
	public class MIM
	{
		public CLUT Clut {get;set;}
		public List<Texture> Textures;
		public MIM()
		{
			Clut = new CLUT();
			Textures = new List<Texture>();
		}
	}
	
}
