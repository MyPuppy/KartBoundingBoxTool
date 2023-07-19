using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KartRider
{
	internal class Program
	{
		public static KartBoundingBox KartBoundingBoxForm;

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			KartBoundingBox KartBoundingBox = new KartBoundingBox();
			Program.KartBoundingBoxForm = KartBoundingBox;
			Application.Run(KartBoundingBox);
		}
	}
}