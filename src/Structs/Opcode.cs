using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF7Viewer
{
    public class Opcode
    {
    	//Auto Properties
        public byte Id {get; set;}
        public string Name {get; set;}
        public string LongName {get; set;}
        public string Description {get; set;}
        public Operand[] Operands {get; set;}

        //Custom Properties
    	public byte Size
        {
            get
            {
                byte size = 0;
                for (int i = 0; i < Operands.Length - 1; i++)
                {
                    size += Operands[i].Size;
                }
                return size;
            }
        }
    	
    	//Methods
        public override string ToString()
        {
            string str = "";
            str += LongName;
            if (Operands != null)
            {
            	str += " (";
                for (int i = 0; i < Operands.Length; i++)
                {
                	str += "[" + Operands[i].ToString() + "],";
                }
                str = str.Substring(0,str.Length-1);
            	str += ")";
            }
            return str;
        }
    }
}
