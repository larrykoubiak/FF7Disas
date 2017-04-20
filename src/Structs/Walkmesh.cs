/*
 * Created by SharpDevelop.
 * User: I36107
 * Date: 7/04/2017
 * Time: 17:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using TKView;

namespace FF7Viewer
{
	/// <summary>
	/// Description of Walkmesh.
	/// </summary>
	public class Walkmesh
	{
		private UInt32 nos;
		private Sector[] sectors;
		public Walkmesh()
		{
			nos = 0;
			Sectors = new Sector[0];
		}
		public Walkmesh(UInt32 NoS)
		{
			nos = NoS;
			Sectors = new Sector[nos];
		}
		public Sector[] Sectors
		{
			get { return sectors;}
			set { sectors = value;}
		}
		public UInt32 NoS
		{
			get {return nos;}
			set 
			{
				nos = value;
				Array.Resize(ref sectors,(int)nos);
			}
		}
	}
}
