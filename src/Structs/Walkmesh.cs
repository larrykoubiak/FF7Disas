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
using OpenTK;

namespace FF7Viewer
{
	/// <summary>
	/// Description of Walkmesh.
	/// </summary>
	public class Access
	{
		public UInt16 Access1 {get;set;}
		public UInt16 Access2 {get;set;}
		public UInt16 Access3 {get;set;}		
	}
	public class Walkmesh
	{
		private UInt32 nos;
		private Sector[] sectors;
		private Access[] accesspool;
		public Walkmesh()
		{
			nos = 0;
			Sectors = new Sector[0];
		}
		public Walkmesh(UInt32 NoS)
		{
			nos = NoS;
			Sectors = new Sector[nos];
			AccessPool = new Access[nos];
		}
		public Sector[] Sectors
		{
			get { return sectors;}
			set { sectors = value;}
		}
		public Access[] AccessPool
		{
			get { return accesspool;}
			set { accesspool = value;}
		}
		public UInt32 NoS
		{
			get {return nos;}
			set 
			{
				nos = value;
				Array.Resize(ref sectors,(int)nos);
				Array.Resize(ref accesspool,(int)nos);
			}
		}
	}
}
