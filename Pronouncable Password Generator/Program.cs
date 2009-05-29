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
			if ( DateTime.Now <= DateCompiled.AddMonths(6) )
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

		private static DateTime _compiledDate;
		public static DateTime DateCompiled
		{
			get
			{
				if ( _compiledDate == DateTime.MinValue ) {

					// Assumes that in AssemblyInfo.cs the version is specified as 1.0.*
					// The remaining numbers are generated from the date.
					// This routine decodes them.

					Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

					// v.Build is days since Jan. 1, 2000
					// v.Revision*2 is seconds since local midnight
					// (NEVER daylight saving time)

					_compiledDate = new DateTime(v.Build * TimeSpan.TicksPerDay + v.Revision * TimeSpan.TicksPerSecond * 2).AddYears(1999);
				}

				return _compiledDate;
			}
		}


	}
}