using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF7Viewer
{
    class Script
    {
        //variables
        private UInt16 unknown;
        private byte nEntities;
        private byte nModels;
        private UInt16 wStringOffset;
        private UInt16 nAkaoOffsets;
        private UInt16 scale;
        private UInt16[] blank;
        private string szCreator;
        private string szName;
        private string[] szEntities;
        private UInt32[] dwAkaoOffsets;
        private UInt16[,] vEntityScripts;
        private EntityScript[,] eScripts;
        private UInt16 nDialogs;
        private UInt16[] wDialogOffsets;
        private string[] szDialogs;
        //constructor
        public Script()
        {
            blank = new UInt16[3];
        }
        //Properties
        public UInt16 Unknown
        {
            get { return unknown; }
            set { unknown = value; }
        }
        public byte NbEntities
        {
            get { return nEntities; }
            set
            {
                nEntities = value;
                szEntities = new string[nEntities];
                vEntityScripts = new UInt16[nEntities, 32];
                eScripts = new EntityScript[nEntities, 32];
            }
        }
        public byte NbModels
        {
            get { return nModels; }
            set { nModels = value; }
        }
        public UInt16 StringOffset
        {
            get { return wStringOffset; }
            set { wStringOffset = value; }
        }
        public UInt16 NbAkaoOffsets
        {
            get { return nAkaoOffsets; }
            set
            {
                nAkaoOffsets = value;
                dwAkaoOffsets = new UInt32[nAkaoOffsets];
            }
        }
        public UInt16 Scale
        {
            get { return scale; }
            set { scale = value; }
        }
        public UInt16[] Blank
        {
            get { return blank; }
            set { blank = value; }
        }
        public string Creator
        {
            get { return szCreator; }
            set { szCreator = value; }
        }
        public string Name
        {
            get { return szName; }
            set { szName = value; }
        }
        public string[] Entities
        {
            get { return szEntities; }
            set { szEntities = value; }
        }
        public UInt32[] AkaoOffsets
        {
            get { return dwAkaoOffsets; }
            set { dwAkaoOffsets = value; }
        }
        public UInt16[,] EntityScripts
        {
            get { return vEntityScripts; }
            set { vEntityScripts = value; }
        }
        public EntityScript[,] Scripts
        {
            get { return eScripts; }
            set { eScripts = value; }
        }
        public UInt16 NbDialogs
        {
            get { return nDialogs; }
            set 
            { 
                nDialogs = value;
                wDialogOffsets = new UInt16[nDialogs];
                szDialogs = new string[nDialogs];
            }
        }
        public UInt16[] DialogOffsets
        {
            get { return wDialogOffsets; }
            set { wDialogOffsets = value; }
        }
        public string[] Dialogs
        {
            get { return szDialogs; }
            set { szDialogs = value; }
        }
    }
}
