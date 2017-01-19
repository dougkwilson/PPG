using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Dkw.UI
{
	public partial class SplashForm : Form
	{
		private const int TIMER_INTERVAL = 40;

		private static SplashForm ms_splashForm;
		private static Thread ms_splashThread;
		private static String ms_strApplicationName = $"Pronounceable{Environment.NewLine}Password{Environment.NewLine}Generator";
		private static String ms_strApplicationVersion = String.Empty;
		private static String ms_strApplicationCopyright = $"Copyright © 2006-{DateTime.Now.Year} Doug Wilson";
		private static String ms_strStatus = "Initializing Application";
		private static Boolean ms_bAllowClose = false;

		private Double m_dblOpacityIncrement = .1;
		private Double m_dblOpacityDecrement = .1;


		static SplashForm() {
			Assembly myAssembly = Assembly.GetExecutingAssembly();
			AssemblyName myName = myAssembly.GetName();
			ms_strApplicationVersion = myName.Version.ToString();

			//Object[] objects = myAssembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
			//if (objects.Length > 0) {
			//	var assemblyProductAttribute = objects[0] as AssemblyProductAttribute;
			//	if (null != assemblyProductAttribute) {
			//		ms_strApplicationName = assemblyProductAttribute.Product;
			//	}
			//}
		}

		private static DateTime _compiledDate;
		public static DateTime DateCompiled {
			get {
				if (_compiledDate == DateTime.MinValue) {

					// Assumes that in AssemblyInfo.cs the version is specified as 1.0.*
					// The remaining numbers are generated from the date.
					// This routine decodes them.

					Version v = Assembly.GetExecutingAssembly().GetName().Version;

					// v.Build is days since Jan. 1, 2000
					// v.Revision*2 is seconds since local midnight
					// (NEVER daylight saving time)

					_compiledDate = new DateTime(v.Build * TimeSpan.TicksPerDay + v.Revision * TimeSpan.TicksPerSecond * 2);
					_compiledDate = _compiledDate.AddYears(1999).AddDays(-1);
				}

				return _compiledDate;
			}
		}

		private SplashForm() {
			InitializeComponent();

			closeLabel.Visible = ms_bAllowClose;

			Opacity = .0;
			fadeTimer.Interval = TIMER_INTERVAL;
			fadeTimer.Start();
		}

		static private void ShowForm() {
			ms_splashForm = new SplashForm();
			ms_splashForm.applicationNameLabel.Text = ms_strApplicationName;
			ms_splashForm.versionLabel.Text = String.Format("v{0} ({1})", ms_strApplicationVersion, DateCompiled.ToString("yyyy/MM/dd"));
			ms_splashForm.copyrightLabel.Text = ms_strApplicationCopyright;

			Application.Run(ms_splashForm);
		}

		static public void CloseSplashScreen() {
			if (ms_splashForm != null) {
				// Make it start going away.
				ms_splashForm.m_dblOpacityIncrement = -ms_splashForm.m_dblOpacityDecrement;
			}
			ms_splashThread = null;  // we do not need these any more.
			ms_splashForm = null;
		}

		static public void ShowSplashScreen(Boolean allowClose) {
			ShowSplashScreen(allowClose, String.Empty);
		}

		static public void ShowSplashScreen(Boolean allowClose, String status) {
			// Make sure it is only launched once.
			if (ms_splashForm != null)
				return;

			ms_bAllowClose = allowClose;
			ms_strStatus = status;
			ms_splashThread = new Thread(new ThreadStart(ShowForm));
			ms_splashThread.IsBackground = true;
			ms_splashThread.TrySetApartmentState(ApartmentState.STA);
			ms_splashThread.Start();
		}

		static public void ShowSplashScreen(Boolean allowClose, String applicationName, String version, String copyright, String status) {
			// Override defaults
			ms_strApplicationName = applicationName;
			ms_strApplicationVersion = version;
			ms_strApplicationCopyright = copyright;

			ShowSplashScreen(allowClose, status);
		}

		static public void SetStatus(String status) {
			ms_strStatus = status;
		}

		private void fadeTimer_Tick(object sender, EventArgs e) {
			StatusLabel.Text = ms_strStatus;

			if (m_dblOpacityIncrement > 0) {
				// Fading In
				if (Opacity < 1) {
					Opacity += m_dblOpacityIncrement;
				} else {

				}
			} else {
				// Fading Out
				if (Opacity > 0) {
					Opacity += m_dblOpacityIncrement;
				} else {
					fadeTimer.Enabled = false;
					Close();
				}
			}
		}

		private void SplashForm_Click(object sender, EventArgs e) {
			if (ms_bAllowClose)
				CloseSplashScreen();
		}

	}
}