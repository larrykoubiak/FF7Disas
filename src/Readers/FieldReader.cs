using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
                                double size = (double)oper.Size;
                                int nb = (int)Math.Ceiling(size / 8);
                                oper.Value = new byte[nb];
                                buff = reader.ReadBytes(nb);
                                if (size < 8)
                                {
                                    byte towrite = 8;
                                    while (towrite > 0 || count < (byte)op.Operands.Length)
                                    {
                                        int mask = 0;
                                        //create mask
                                        for (byte m = 0; m < size; m++)
                                        {
                                            mask = mask | ((byte)128 >> m);
                                            mask = mask >> (8 - towrite);
                                        }
                                        byte val = (byte)((buff[0] & mask) >> (towrite - (byte)size));
                                        oper.Value[0] = val;
                                        towrite -= (byte)size;
                                        count++;
                                    }
                                }
                                else
                                {
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
            //dialogs
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
            return script;
        }
    }
}
