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
    	//Variables
        private byte size;

        //Auto properties
    	public string Name {get; set;}
        public string Description {get; set;}
        public byte[] Value {get; set;}

        
        //Custom Properties
        public byte Size
        {
            get { return size; }
            set 
            { 
                size = value;
                Value = new byte[(int)Math.Ceiling((decimal)size / 8)];
            }
        }
        
    }
    public class UByte : Operand
    {
        public UByte()
        {
            Value = new byte[1];
        }
        public override string ToString()
        {
            string str = "";
            if(Value.Length > 0) str = this.Name + ":=" + Value[0].ToString();
            return str;
        }
    }
    public class UShort : Operand
    {
        public UShort()
        {
            Value = new byte[2];
        }
        public override string ToString()
        {
            string str = "";
            if (Value.Length > 0)
            {
                UInt16 opValue = BitConverter.ToUInt16(Value, 0);
                str = this.Name + ":=" + opValue.ToString();
            }
            return str;
        }
    }
    public class ULong : Operand
    {
        public ULong()
        {
            Value = new byte[4];
        }
        public override string ToString()
        {
            string str = "";
            if (Value.Length > 0)
            {
                UInt32 opValue = BitConverter.ToUInt32(Value, 0);
                str = this.Name + ":=" + opValue.ToString();
            }
            return str;
        }
    }
}
