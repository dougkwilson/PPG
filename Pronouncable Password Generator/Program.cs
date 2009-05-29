using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

using Fpi.Ppg.UI;

namespace Fpi.Ppg
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if ( DateTime.Now <= new DateTime(2009, 12, 31) )
			{
				System.Windows.Forms.Application.EnableVisualStyles();
				System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

				System.Windows.Forms.Application.Run(new Fpi.Ppg.UI.MainForm());
			}
			else
			{
				MessageBox.Show("This version has expired.  Please contact the author for a new one.", "Expired!");
			}
		}

		public static String GeneratePassword()
		{
			return String.Empty;
		}
	}
}