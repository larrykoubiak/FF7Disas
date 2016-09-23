using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF7Viewer
{
    class EntityScript
    {
        private List<Opcode> opcodes ;
        public EntityScript()
        {
            opcodes = new List<Opcode>();
        }
        public List<Opcode> Opcodes
        {
            get { return opcodes; }
            set { opcodes = value; }
        }
        public override string ToString()
        {
            string str = "";
            foreach (Opcode op in opcodes)
            {
                str += op.ToString() + "\r\n";
            }
            return str;
        }
    }
}
