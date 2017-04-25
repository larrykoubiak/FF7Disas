using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.IO;
using OpenTK;
using TKView;
namespace FF7Viewer
{
    class FieldReader
    {
        private BinaryReader reader;
        public Field ReadFieldFile(MemoryStream stream)
        {
            Field field = new Field();
            reader = new BinaryReader(stream);
            //parse file
            field.Offsets = ReadOffsets();
            field.Script = ReadScript(field.Offsets[(int)Field.Offset.Script], field.Offsets[(int)Field.Offset.Walkmesh]);
            field.Walkmesh = ReadWalkMesh(field.Offsets[(int)Field.Offset.Walkmesh], field.Offsets[(int)Field.Offset.Tilemap]);
            field.TileMap = ReadTileMap(field.Offsets[(int)Field.Offset.Tilemap],field.Offsets[(int)Field.Offset.Camera_Matrix]);
            //cleanup
            reader.Close();
            return field;
        }
        private UInt32[] ReadOffsets()
        {
            UInt32 buff;
            UInt32 memoryoffset = 0;
            UInt32[] offsets = new UInt32[7];
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            for (int i = 0; i < 7; i++)
            {
                buff = reader.ReadUInt32();
                if (memoryoffset == 0)
                {
                    memoryoffset = buff;
                }
                offsets[i] = (buff - memoryoffset + 28);
            }
            return offsets;
        }
        private Script ReadScript(UInt32 offset, UInt32 nextoffset)
        {
            Script script;
            int i;
            //go to first offset
            reader.BaseStream.Seek(offset, SeekOrigin.Begin);
            script = new Script();
            //read header
            script.Unknown = reader.ReadUInt16();
            script.NbEntities = reader.ReadByte();
            script.NbModels = reader.ReadByte();
            script.StringOffset = reader.ReadUInt16();
            script.NbAkaoOffsets = reader.ReadUInt16();
            script.Scale = reader.ReadUInt16();
            for (i = 0; i < 3; i++)
            {
                script.Blank[i] = reader.ReadUInt16();
            }
            script.Creator = Encoding.Default.GetString(reader.ReadBytes(8));
            script.Name = Encoding.Default.GetString(reader.ReadBytes(8));
            for (i = 0; i < script.NbEntities; i++)
            {
                script.Entities[i] = Encoding.Default.GetString(reader.ReadBytes(8));
            }
            //read offsets
            for (i= 0; i < script.NbAkaoOffsets; i++)
            {
                script.AkaoOffsets[i] = reader.ReadUInt32();
            }
            for (i = 0; i < script.NbEntities; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    script.EntityScripts[i, j] = Convert.ToUInt16(reader.ReadUInt16());
                }
            }
            //read scripts
            for (i = 0; i < script.NbEntities; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    byte code;
                    EntityScript sc = new EntityScript();
                    Opcode op;
                    reader.BaseStream.Seek((UInt32)script.EntityScripts[i, j] + offset, SeekOrigin.Begin);
                    do
                    {
                        code = reader.ReadByte(); // read opcode
                        op = Opcodes.List[code]; // assign opcode from known list
                        byte count = 0;
                        byte[] buff;
                        if (op.Operands != null)
                        {
                            while (count < (byte)op.Operands.Length)
                            {
                                Operand oper = op.Operands[count];
                                if(oper.Size < 8)
                                {
                                	//prepare BitVector sections
                                	int len = 0;
                                	int secidx = 0;
                                	List<BitVector32.Section> sections = new List<BitVector32.Section>();
                                	while(oper.Size < 8 && len <=32)
                                	{
                                		BitVector32.Section sec;
                                		if(secidx == 0) {
                                			sec = BitVector32.CreateSection((short)((1 << oper.Size)-1));
                                		} else {
                                			sec = BitVector32.CreateSection((short)((1 << oper.Size)-1),sections[secidx-1]);
                                		}
                                		sections.Add(sec);
                                		len += oper.Size;
                                		secidx++;
                                		if((count+secidx)>=op.Operands.Length)
                                			break;
                                		else
                                			oper = op.Operands[count+secidx];
                                	}
                                	//assign values from byte array
                                	buff = reader.ReadBytes((int)(len/8));
                                	int valuetoparse = 0;
                                	for(int k=0;k<buff.Length;k++)
                                	{
                                		valuetoparse += (buff[k] << (k*8));
                                	}
                                	BitVector32 bv = new BitVector32(valuetoparse);
                                	for(int idx=0;idx<secidx;idx++)
                                	{
                                		oper = op.Operands[count];
                                		oper.Value = new byte[1];
                                		oper.Value[0] = (byte)bv[sections[idx]];
                                		count++;
                                	}                                	
                                }                                
                                else
                                {
                                	buff = reader.ReadBytes((int)oper.Size/8);
                                	oper.Value = buff;
                                    count++;
                                }
                            }
                        }
                        sc.Opcodes.Add(op);
                    } while (code != 0);
                    script.Scripts[i, j] = sc;
                }
            }
            
            //read dialogs
            reader.BaseStream.Seek((UInt32)script.StringOffset + offset, SeekOrigin.Begin);
            script.NbDialogs = reader.ReadUInt16();
            for (i = 0; i < script.NbDialogs; i++)
            {
                script.DialogOffsets[i] = Convert.ToUInt16(reader.ReadUInt16() + script.StringOffset);
            }
            for (i = 0; i < script.NbDialogs; i++)
            {
                byte[] dialog;
                int size;
                if ((i + 1) < script.NbDialogs)
                {
                    size = script.DialogOffsets[i + 1] - script.DialogOffsets[i];
                }
                else
                {
                    UInt32 next = script.NbAkaoOffsets == 0 ? nextoffset : script.AkaoOffsets[0];
                    size = Convert.ToInt32(next - script.DialogOffsets[i]);
                }
                dialog = new byte[size];
                reader.BaseStream.Seek(script.DialogOffsets[i] + offset, SeekOrigin.Begin);
                dialog = reader.ReadBytes(size);
                script.Dialogs[i] = FF7Text.DecodeBytes(dialog, size);
                dialog = null;
            }
            
            //read akao
            for (i = 0; i < script.NbAkaoOffsets; i++)
            {
            	AKAOFrame frm = new AKAOFrame();
            	reader.BaseStream.Seek((UInt32)script.AkaoOffsets[i] + offset, SeekOrigin.Begin);
            	frm.Magic = Encoding.Default.GetString(reader.ReadBytes(4));
            	frm.Id = reader.ReadUInt16();
            	frm.Length = reader.ReadUInt16();
            	frm.Unknown = reader.ReadBytes(8);
            	script.Akaos[i] = frm;
            }
            return script;
        }
        private Walkmesh ReadWalkMesh(UInt32 offset, UInt32 nextoffset) {
            Walkmesh walkmesh;
            int i,j;
            UInt32 nb;
            Int16 x,y,z,res;
            //go to first offset
            reader.BaseStream.Seek(offset, SeekOrigin.Begin);
            nb = reader.ReadUInt32();
            walkmesh = new Walkmesh(nb);
            for(i = 0;i < nb;i++)
            {
            	Sector sector = new Sector();
            	for(j=0;j<3;j++) {
	            	x = reader.ReadInt16();
	            	y = reader.ReadInt16();
	            	z = reader.ReadInt16();
	            	res = reader.ReadInt16();
	            	Vector3 vertex = new Vector3((float)x,(float)y,(float)z);
	            	sector.Vertices[j] = vertex;
            	}
            	walkmesh.Sectors[i] = sector;
            }
            for(i=0;i<nb;i++)
            {
            	Access access = new Access();
            	access.Access1 = reader.ReadUInt16();
            	access.Access2 = reader.ReadUInt16();
            	access.Access3 = reader.ReadUInt16();
            	walkmesh.AccessPool[i] = access;
            }
            return walkmesh;
        }
        private TileMap ReadTileMap(UInt32 offset, UInt32 nextoffset)
        {
        	UInt16 type,pos,count;        	
    		Int16 destx, desty;
    		byte pgsrcx, pgsrcy;
    		UInt16 clut;
        	UInt16 textinfo;
        	UInt16 group;
        	byte parameter;
        	byte state;
    		TileMap map = new TileMap();
        	int i;
        	Int16 mindestx = 0,mindesty = 0;
        	Int16 maxdestx = 0,maxdesty = 0;
        	reader.BaseStream.Seek(offset, SeekOrigin.Begin);
        	for(i=0;i<4;i++)
        	{
        		map.Offsets[i] = reader.ReadUInt32();
        	}
        	//read LayerInfos
        	Layer layer = new Layer();
        	while(reader.BaseStream.Position < offset + map.Offsets[0])
        	{
        		type = reader.ReadUInt16();
        		if(type==0x7FFE) 
        		{
        			//End of layer
	        		pos = reader.ReadUInt16();
	        		count = reader.ReadUInt16();
	        		layer.TexturePageId = pos;
	        		map.Layers.Add(layer);
	        		layer = new Layer();
        		}
        		else if(type==0x7FFF)
        		{
        			//end of layer infos
        			break;
        		}
        		else
        		{
	        		pos = reader.ReadUInt16();
	        		count = reader.ReadUInt16();
	        		LayerInfo li = new LayerInfo(type,pos,count);
	        		layer.LayerInfos.Add(li);
        		}
        	}
        	//read TileInfos
        	reader.BaseStream.Position = offset + map.Offsets[0];
        	foreach(Layer l in map.Layers)
        	{
        		foreach(LayerInfo li in l.LayerInfos)
        		{
        			for(int tilenum=0;tilenum<li.TileCount;tilenum++)
        			{
		        		destx = reader.ReadInt16();
		        		desty = reader.ReadInt16();
		        		mindestx = Math.Min(mindestx,destx);
		        		mindesty = Math.Min(mindesty,desty);
		        		maxdestx = Math.Max(maxdestx,destx);
		        		maxdesty = Math.Max(maxdesty,desty);		        		
		        		pgsrcx = reader.ReadByte();
		        		pgsrcy = reader.ReadByte();
		        		clut = reader.ReadUInt16();
		        		TileInfo tile = new TileInfo(destx,desty,pgsrcx,pgsrcy,clut);
		        		li.Tiles.Add(tile);
        			}
        		}
        	}
        	//read TextureInfos
        	reader.BaseStream.Position = offset + map.Offsets[1];
        	while(reader.BaseStream.Position < offset + map.Offsets[2])
        	{
        		textinfo = reader.ReadUInt16();
        		TexturePageInfo ti = new TexturePageInfo(textinfo);
        		map.TexturePageInfos.Add(ti);
        	}
        	//read SpriteInfos
        	reader.BaseStream.Position = offset + map.Offsets[2];
        	while(reader.BaseStream.Position < offset + map.Offsets[3])
        	{
        		destx = reader.ReadInt16();
        		desty = reader.ReadInt16();
        		mindestx = Math.Min(mindestx,destx);
        		mindesty = Math.Min(mindesty,desty);
        		maxdestx = Math.Max(maxdestx,destx);
        		maxdesty = Math.Max(maxdesty,desty);
        		pgsrcx = reader.ReadByte();
        		pgsrcy = reader.ReadByte();
        		clut = reader.ReadUInt16();
        		TileInfo ti = new TileInfo(destx,desty,pgsrcx,pgsrcy,clut);
        		textinfo = reader.ReadUInt16();
        		TexturePageInfo tpi = new TexturePageInfo(textinfo);
        		group = reader.ReadUInt16();
        		parameter = reader.ReadByte();
        		state = reader.ReadByte();
        		SpriteInfo si = new SpriteInfo(ti,tpi,group,parameter,state);
        		map.SpriteInfos.Add(si);
        	}
        	map.Width = (UInt16)((maxdestx - mindestx)+32);
        	map.Height = (UInt16)((maxdesty - mindesty)+32);

        	return map;
        }
    }
}
