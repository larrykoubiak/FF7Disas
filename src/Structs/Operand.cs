using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
namespace FF7Viewer
{
    [XmlInclude(typeof(UByte))]
    [XmlInclude(typeof(UShort))]
    [XmlInclude(typeof(ULong))]
    public class Operand
    {
        private string name;
        private byte size;
        private string desc;
        protected byte[] val;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public byte Size
        {
            get { return size; }
            set 
            { 
                size = value;
                val = new byte[(int)Math.Ceiling((decimal)size / 8)];
            }
        }
        public string Description
        {
            get { return desc; }
            set { desc = value; }
        }
        public byte[] Value
        {
            get { return val; }
            set { val = value; }
        }
    }
    public class UByte : Operand
    {
        public UByte()
        {
            val = new byte[1];
        }
        public override string ToString()
        {
            string str = "";
            if(val.Length > 0) str = this.Name + ":=" + val[0].ToString();
            return str;
        }
    }
    public class UShort : Operand
    {
        public UShort()
        {
            val = new byte[2];
        }
        public override string ToString()
        {
            string str = "";
            if (val.Length > 0)
            {
                UInt16 opval = BitConverter.ToUInt16(val, 0);
                str = this.Name + ":=" + opval.ToString();
            }
            return str;
        }
    }
    public class ULong : Operand
    {
        public ULong()
        {
            val = new byte[4];
        }
        public override string ToString()
        {
            string str = "";
            if (val.Length > 0)
            {
                UInt32 opval = BitConverter.ToUInt32(val, 0);
                str = this.Name + ":=" + opval.ToString();
            }
            return str;
        }
    }
}
