using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF7Viewer
{
    class EntityScript
    {
		//Constructor
        public EntityScript()
        {
            Opcodes = new List<Opcode>();
        }
        
        //Auto Properties
        public List<Opcode> Opcodes { get; set;}
        
        //Methods
        public override string ToString()
        {
            string str = "";
            foreach (Opcode op in Opcodes)
            {
                str += op.ToString() + "\r\n";
            }
            return str;
        }
    }
}
