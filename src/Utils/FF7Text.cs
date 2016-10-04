using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF7Viewer
{
    public static class FF7Text
    {
        //variables
        private readonly static string[] ff_chars = new string[]
        {
            " "," !","\"","#","$"," %","&","'","(",")","*","+",",","-",".","/",
            "0","1","2","3","4","5","6","7","8","9"," :"," ;","<","=",">"," ?",
            "@","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O",
            "P","Q","R","S","T","U","V","W","X","Y","Z","[","\\","]","^","_",
            "`","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o",
            "p","q","r","s","t","u","v","w","x","y","z","{","|","}","~","",
            "Ä","Á","Ç","É","Ñ","Ö","Ü","á","à","â","ä","ã","å","ç","é","è",
            "ê","ë","í","ì","î","ï","ñ","ó","ò","ô","ö","õ","ú","ù","û","ü",
            "⌘","°","¢","£","Ù","Û","¶","ß","®","©","™","´","¨","≠","Æ","Ø",
            "∞","±","≤","≥","¥","µ","∂","Σ","Π","π","⌡","ª","º","Ω","æ","ø",
            "¿","¡","¬","√","ƒ","≈","∆","«","»","…","{NOTHING}","À","Ã","Õ","Œ","œ",
            "–","—","“","”","‘","’","÷","◊","ÿ","Ÿ","⁄","¤","‹","›","ﬁ","ﬂ",
            "■","▪","‚","„","‰","Â","Ê","Ë","Á","È","í","î","ï","ì","Ó","Ô",
            "{SPACE}","Ò","Ù","Û","","","","","","","","","","","","",
            "{Choice}","{Tab}",",",".\"","...\"","","","{EOL}","{New Scr}","{New Scr?}","{Cloud}","{Barret}","{Tifa}","{Aerith}","{Red XIII}","{Yuffie}",
            "{Cait Sith}","{Vincent}","{Cid}","{Party #1}","{Party #2}","{Party #3}","〇","△","☐","✕","","","","","{FUNC}","{END}"
        };
        public static string DecodeBytes(byte[] input, int size)
        {
            StringBuilder sb = new StringBuilder();
            byte ffchar;
            for (int i = 0; i < size; i++)
            {
                ffchar = input[i];
                sb.Append(ff_chars[ffchar]);
            }
            return sb.ToString();
        }
    }
}
