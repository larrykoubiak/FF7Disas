using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace FF7Viewer
{
    class Field
    {
        public enum Offset
        {
            Script,
            Walkmesh,
            Tilemap,
            Camera_Matrix,
            Triggers,
            Encounter,
            Model
        }
        //Constructor
        public Field()
        {
            Offsets = new UInt32[7];
        }
        //Auto properties
        public UInt32[] Offsets {get; set; }
        public Script Script {get; set; }
    }
}
