/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 21/04/2017
 * Time: 11:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace FF7Viewer
{
	public class LayerInfo
	{
		public UInt16 Type {get;set;}
		public UInt16 TilePos {get;set;}
		public UInt16 TileCount {get;set;}
		public LayerInfo(UInt16 type, UInt16 pos, UInt16 count)
		{
			Type = type;
			TilePos = pos;
			TileCount = count;
		}
	}
	public class TileInfo
	{
		public Int16 DestinationX {get;set;}
		public Int16 DestinationY {get;set;}
		public byte TexPageSourceX {get;set;}
		public byte TexPageSourceY {get;set;}
		public UInt16 TileClutData {get;set;}
		public TileInfo(Int16 destx,Int16 desty,byte pgsrcx,byte pgsrcy,UInt16 clut)
		{
			DestinationX = destx;
			DestinationY = desty;
			TexPageSourceX = pgsrcx;
			TexPageSourceY = pgsrcy;
			TileClutData = clut;
		}
		public byte ClutNumber
		{
			get {return (byte)((TileClutData & 0x3C0) >> 6);}
			set {TileClutData = (UInt16)((TileClutData ^ 0x3C0) | (value << 6));}
		}
	}
	public class TexturePageInfo
	{
		private BitVector32 vector;
		private BitVector32.Section page_x;
		private BitVector32.Section page_y;
		private BitVector32.Section blending_mode;
		private BitVector32.Section depth;
		public TexturePageInfo()
		{
			vector = new BitVector32(0);
			page_x = BitVector32.CreateSection(15);
			page_y = BitVector32.CreateSection(1,page_x);
			blending_mode = BitVector32.CreateSection(3,page_y);
			depth = BitVector32.CreateSection(3,blending_mode);			
		}
		public TexturePageInfo(UInt16 value) : this()
		{
			vector = new BitVector32(value);
		}
		public UInt16 Value 
		{
			get {return (UInt16)vector.Data;}
			set {vector = new BitVector32(value);}
		}
		public byte PageX
		{
			get {return (byte)vector[page_x];}
			set {vector[page_x] = (int)(value);}
		}
		public byte PageY
		{
			get {return (byte)vector[page_y];}
			set {vector[page_y] = (int)(value);}
		}
		public byte BlendingMode
		{
			get {return (byte)vector[blending_mode];}
			set {vector[blending_mode] = (int)(value);}
		}
		public byte Depth
		{
			get {return (byte)vector[depth];}
			set {vector[depth] = (int)(value);}
		}
	}
	public class SpriteInfo
	{
		public TileInfo SpriteTI {get;set;}
		public TexturePageInfo SpriteTP_Blend {get;set;}
		public UInt16 Group {get;set;}
		public byte Parameter {get;set;}
		public byte State {get;set;}
		public SpriteInfo(TileInfo ti, TexturePageInfo tpi, UInt16 group, byte param, byte state)
		{
			SpriteTI = ti;
			SpriteTP_Blend = tpi;
			Group = group;
			Parameter = param;
			State = state;
		}
	}
	/// <summary>
	/// Description of TileMap.
	/// </summary>
	public class TileMap
	{
		public UInt32[] Offsets {get;set;}
		public List<LayerInfo> TileLayers {get;set;}
		public List<TileInfo> BackgroundTiles {get;set;}
		public List<TexturePageInfo> TexturePageInfos {get;set;}
		public List<SpriteInfo> SpriteInfos {get;set;}
		public TileMap()
		{
			Offsets = new UInt32[4];
			TileLayers = new List<LayerInfo>();
			BackgroundTiles = new List<TileInfo>();
			TexturePageInfos = new List<TexturePageInfo>();
			SpriteInfos = new List<SpriteInfo>();
		}		
	}
}
