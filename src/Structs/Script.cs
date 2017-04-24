using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF7Viewer
{
    public class Script
    {
    	//variables
        private byte nEntities;
        private UInt16 nDialogs;
        private UInt16 nAkaoOffsets;

        //constructor
        public Script()
        {
            Blank = new UInt16[3];
        }
       
		//Auto Properties
        public UInt16 Unknown {get; set;}
        public byte NbModels {get; set;}
        public UInt16 StringOffset {get; set;}
        public UInt16 Scale {get; set;}
        public UInt16[] Blank {get; set;}
        public string Creator {get; set;}
        public string Name {get; set;}
        public string[] Entities {get; set;}
        public UInt16[,] EntityScripts  {get; set;}
        public EntityScript[,] Scripts {get; set;}        
        public UInt16[] DialogOffsets {get; set;}
        public string[] Dialogs {get; set;}
        public UInt32[] AkaoOffsets {get; set;}
        public AKAOFrame[] Akaos {get; set;}
        
        //Custom Properties
        public byte NbEntities
        {
            get { return nEntities; }
            set
            {
                nEntities = value;
                Entities = new string[nEntities];
                EntityScripts = new UInt16[nEntities, 32];
                Scripts = new EntityScript[nEntities, 32];
            }
        }

        public UInt16 NbDialogs
        {
            get { return nDialogs; }
            set 
            { 
                nDialogs = value;
                DialogOffsets = new UInt16[nDialogs];
                Dialogs = new string[nDialogs];
            }
        }        
        
        public UInt16 NbAkaoOffsets
        {
            get { return nAkaoOffsets; }
            set
            {
                nAkaoOffsets = value;
                AkaoOffsets = new UInt32[nAkaoOffsets];
                Akaos = new AKAOFrame[nAkaoOffsets];
            }
        }
        
    }
}
