using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF7Viewer
{
    public class Opcode
    {
        private byte opcode;
        private string shortname;
        private string longname;
        private string desc;
        private Operand[] operands;
        public byte Id
        {
            get { return opcode; }
            set { opcode = value; }
        }
        public string Name
        {
            get { return shortname; }
            set { shortname = value; }
        }
        public string LongName
        {
            get { return longname; }
            set { longname = value; }
        }
        public string Description
        {
            get { return desc; }
            set { desc = value; }
        }
        public Operand[] Operands
        {
            get { return operands; }
            set { operands = value; }
        }
        public byte Size
        {
            get
            {
                byte size = 0;
                for (int i = 0; i < operands.Length - 1; i++)
                {
                    size += operands[i].Size;
                }
                return size;
            }
        }
        public override string ToString()
        {
            string str = "";
            str += LongName;
            if (operands != null)
            {
            	str += " (";
                for (int i = 0; i < operands.Length; i++)
                {
                	str += "[" + operands[i].ToString() + "],";
                }
                str = str.Substring(0,str.Length-1);
            	str += ")";
            }
            return str;
        }
    }
}
