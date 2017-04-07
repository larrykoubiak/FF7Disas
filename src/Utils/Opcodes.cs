using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
namespace FF7Viewer
{
    public static class Opcodes
    {
        public static Opcode[] List;
        static Opcodes()
        {
            List = new Opcode[256];
            XmlSerializer serializer = new XmlSerializer(List.GetType());
            FileStream stream = new FileStream("FieldScriptOpcodes.xml", FileMode.Open);
            List = (Opcode[])serializer.Deserialize(stream);
            stream.Close();
            serializer = null;
        }
    }
}
