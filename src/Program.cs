using System;
using System.Windows.Forms;
using Dkw.Properties;
using Dkw.UI;

namespace Dkw
{
	internal static class Program
	{
		public static Settings Settings { get; } = new Settings();

		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}