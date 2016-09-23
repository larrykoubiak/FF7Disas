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
        //variables
        private UInt32[] offsets;
        private Script script;
        //constructor
        public Field()
        {
            offsets = new UInt32[7];
        }
        //properties
        public UInt32[] Offsets
        {
            get { return offsets; }
            set { offsets = value; }
        }
        public Script Script
        {
            get { return script; }
            set { script = value; }
        }
    }
}
