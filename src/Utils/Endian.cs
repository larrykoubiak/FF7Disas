using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF7Viewer
{
    public static class Endian
    {
        public static UInt32 SwapEndian(UInt32 value)
        {
            UInt32 val = 0;
            byte[] buff = BitConverter.GetBytes(value);
            Array.Reverse(buff);
            val = BitConverter.ToUInt32(buff, 0);
            return val;
        }
        public static UInt16 SwapEndian(UInt16 value)
        {
            UInt16 val = 0;
            byte[] buff = BitConverter.GetBytes(value);
            Array.Reverse(buff);
            val = BitConverter.ToUInt16(buff, 0);
            return val;
        }
    }
}
