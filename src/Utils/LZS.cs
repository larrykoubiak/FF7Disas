using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace FF7Viewer
{
    public static class LZS
    {
        //variables
        private static int size = 4096;
        private static int start;
        private static int count;
        private static byte[] elems = new byte[4096];
        //properties
        private static bool IsEmpty
        {
            get { return count == 0; }
        }
        private static bool IsFull
        {
            get { return count == size; }
        }
        //private functions
        private static void ReadCb(int offset, int size, ref byte[] elem)
        {
            int realoffset;
            int i = 0;
            int writeoffset = 0;
            realoffset = (offset + 18) & 0xFFF;
            int end = (start + count) & 0xFFF;
            if ((realoffset + size) > end && realoffset < end)
            {
                byte value;
                int max_read = end - realoffset;
                while (writeoffset < size)
                {
                    value = elems[realoffset + i];
                    elem[writeoffset] = value;
                    writeoffset++;
                    i++;
                    if (i == max_read) i = 0;
                }
            }
            else
            {
                for (i = 0; i < size; i++)
                {
                    elem[writeoffset] = elems[(realoffset + i) & 0xFFF];
                    writeoffset++;
                }
            }
        }
        private static void WriteCb(byte elem)
        {
            int end = (start + count) & 0xFFF;
            elems[end] = elem;
            if (IsFull)
            {
                start = (start + 1) & 0xFFF;
            }
            else
            {
                count++;
            }
        }
        //main function
        public static MemoryStream unLZS(string input_path)
        {
            //variables
            UInt32 filesize;
            byte[] bytebuff;
            byte bControl;
            byte literal;
            byte[] offsetsize;
            UInt16 offset;
            byte size;
            int mask;
            MemoryStream stream;
            BinaryReader reader;
            BinaryWriter writer;
            //init
            start = 0;
            count = 0;
            Array.Clear(elems, 0, 4096);
            bytebuff = new byte[18];
            offsetsize = new byte[2];
            reader = new BinaryReader(new FileStream(input_path, FileMode.Open,FileAccess.Read));
            //main code
            filesize = reader.ReadUInt32();
            stream = new MemoryStream((int)filesize);
            writer = new BinaryWriter(stream);
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                bControl = reader.ReadByte();
                for (int i = 0; i < 8; i++)
                {
                    if (reader.BaseStream.Position == reader.BaseStream.Length)
                    {
                        break;
                    }
                    else
                    {
                        mask = 1 << i;
                        if ((mask & bControl) > 0)
                        { // literal
                            literal = reader.ReadByte();
                            WriteCb(literal);
                            writer.Write(literal);
                        }
                        else
                        { //offset
                            offsetsize = reader.ReadBytes(2);
                            size = (byte)((offsetsize[1] & 0x0F)+3);
                            offset = (UInt16)(offsetsize[0] + ((offsetsize[1] & 0xF0) << 4));
                            ReadCb(offset, size, ref bytebuff);
                            for (int j = 0; j < size; j++)
                            {
                                WriteCb(bytebuff[j]);
                            }
                            writer.Write(bytebuff, 0, size);
                        }
                    }
                }
            }
            reader.Close();
            writer.Flush();
            return stream;
        }
    }
}
