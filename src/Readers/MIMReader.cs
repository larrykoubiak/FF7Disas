/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 20/04/2017
 * Time: 12:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace FF7Viewer
{
	/// <summary>
	/// Description of MIMReader.
	/// </summary>
	class MIMReader
	{
		private BinaryReader reader;
		public MIM ReadMIMFile(MemoryStream stream)
		{
			MIM mim = new MIM();
			reader = new BinaryReader(stream);
			mim.Clut = ReadCLUT();
			reader.Close();
			return mim;
		}
		public CLUT ReadCLUT()
		{
			CLUT clut = new CLUT();
			reader.BaseStream.Seek(0, SeekOrigin.Begin);
			clut.Length = reader.ReadUInt32();
			clut.X = reader.ReadUInt16();
			clut.Y = reader.ReadUInt16();
			clut.Width = reader.ReadUInt16();
			clut.Height = reader.ReadUInt16();
			for(int i=0;i<clut.Height;i++)
			{
				Palette palette = new Palette(clut.Width);
				for(int j=0;j<clut.Width;j++)
				{
					palette[j] = new PaletteEntry(reader.ReadUInt16());
				}
				clut[i] = palette;
			}
			return clut;
		}
	}
}
