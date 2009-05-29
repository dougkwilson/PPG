using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Fpi.Ppg.UI
{
	public partial class SplashForm : Form
	{
		private const int TIMER_INTERVAL = 40;

		private static Fpi.Ppg.UI.SplashForm ms_splashForm;
		private static Thread ms_splashThread;

		private static String ms_strApplicationName = String.Empty;
		private static String ms_strApplicationVersion = String.Empty;
		private static String ms_strApplicationCopyright = "Copyright © Fridge Productions 2006";
		private static String ms_strStatus = "Initializing Application";
		private static Boolean ms_bAllowClose = false;

		private Double m_dblOpacityIncrement = .1;
		private Double m_dblOpacityDecrement = .1;


		static SplashForm()
		{
			Assembly myAssembly = Assembly.GetExecutingAssembly();
			AssemblyName myName = myAssembly.GetName();
			ms_strApplicationVersion = myName.Version.ToString();

			Object[] objects = myAssembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
			if ( objects.Length > 0 )
			{
				AssemblyProductAttribute apa = objects[0] as AssemblyProductAttribute;
				if ( null != apa )
				{
					ms_strApplicationName = apa.Product;
				}
			}
		}
		
		private SplashForm()
		{
			InitializeComponent();

			closeLabel.Visible = ms_bAllowClose;

			this.Opacity = .0;
			fadeTimer.Interval = TIMER_INTERVAL;
			fadeTimer.Start();
		}

		static private void ShowForm()
		{
			ms_splashForm = new SplashForm();
			ms_splashForm.applicationNameLabel.Text = ms_strApplicationName;
			ms_splashForm.versionLabel.Text = ms_strApplicationVersion;
			ms_splashForm.copyrightLabel.Text = ms_strApplicationCopyright;

			System.Windows.Forms.Application.Run(ms_splashForm);
		}

		static public void CloseSplashScreen()
		{
			if ( ms_splashForm != null )
			{
				// Make it start going away.
				ms_splashForm.m_dblOpacityIncrement = -ms_splashForm.m_dblOpacityDecrement;
			}
			ms_splashThread = null;  // we do not need these any more.
			ms_splashForm = null;
		}

		static public void ShowSplashScreen(Boolean allowClose)
		{
			// Make sure it is only launched once.
			if ( ms_splashForm != null )
				return;

			ms_bAllowClose = allowClose;			
			ms_splashThread = new Thread(new ThreadStart(SplashForm.ShowForm));
			ms_splashThread.IsBackground = true;
			ms_splashThread.TrySetApartmentState(ApartmentState.STA);
			ms_splashThread.Start();

		}

		static public void ShowSplashScreen(Boolean allowClose, String applicationName, String version, String copyright)
		{
			// Override defaults
			ms_strApplicationName = applicationName;
			ms_strApplicationVersion = version;
			ms_strApplicationCopyright = copyright;

			ShowSplashScreen(allowClose);
		}

		static public void SetStatus(String status)
		{
			ms_strStatus = status;
		}

		private void fadeTimer_Tick(object sender, EventArgs e)
		{
			StatusLabel.Text = ms_strStatus;

			if ( m_dblOpacityIncrement > 0 )
			{
				// Fading In
				if ( this.Opacity < 1 )
				{
					this.Opacity += m_dblOpacityIncrement;
				}
				else
				{

				}
			}
			else
			{
				// Fading Out
				if ( this.Opacity > 0 )
				{
					this.Opacity += m_dblOpacityIncrement;
				}
				else
				{
					fadeTimer.Enabled = false;
					this.Close();
				}
			}
		}

		private void SplashForm_Click(object sender, EventArgs e)
		{
			if ( ms_bAllowClose )
				CloseSplashScreen();
		}

	}
}