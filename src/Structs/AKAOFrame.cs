/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 23/09/2016
 * Time: 14:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FF7Viewer
{
	/// <summary>
	/// Description of AKAOFrame.
	/// </summary>
	public class AKAOFrame
	{
		public string Magic {get; set;} //AKAO
		public UInt16 Id {get; set;}
		public UInt16 Length {get; set;}
		public byte[] Unknown {get; set;}
		
		public AKAOFrame()
		{
			Unknown = new byte[4];
		}
        public override string ToString()
        {
        	return String.Format("Magic: {0}\nId: {1}\nLength: {2}\nUnknown: {3}",Magic,Id,Length,BitConverter.ToString(Unknown));
        }
	}
}
