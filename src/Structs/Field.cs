﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace FF7Viewer
{
    public class Field
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
       //Auto properties
        public UInt32[] Offsets {get; set; }
        public Script Script {get; set; }
        public Walkmesh Walkmesh {get; set;}
        public TileMap TileMap {get; set;}
    	//Constructor
        public Field()
        {
            Offsets = new UInt32[7];
        }
 
    }
}
