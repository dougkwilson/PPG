using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Fpi.Properties;

namespace Fpi.Ppg.UI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadPreferences();
			opacityTrackBar.Value = Convert.ToInt32(this.Opacity * 100.0);
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
		}

		private void MainForm_Click(object sender, EventArgs e)
		{
			SplashForm.CloseSplashScreen();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			passwordTextBox.Text = Fpi.Security.GraphManager.Generate(Convert.ToInt32(lengthUpDown.Value));
		}

		private void opacityTrackBar_ValueChanged(object sender, EventArgs e)
		{
		}

		private void opacityTrackBar_Scroll(object sender, EventArgs e)
		{
			Double opacity = Convert.ToDouble(opacityTrackBar.Value) / 100.0;
			if (opacity < 0.05)
				opacity = 0.05;
			this.Opacity = opacity;
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			SplashForm.ShowSplashScreen(true);
		}

		private void copyButton_Click(object sender, EventArgs e)
		{
			// Save the existing selection
			Int32 start = passwordTextBox.SelectionStart;
			Int32 length = passwordTextBox.SelectionLength;
			
			if (length == 0)
				passwordTextBox.SelectAll();

			passwordTextBox.Copy();
			
			// Restore the previous selection
			passwordTextBox.SelectionStart = start;
			passwordTextBox.SelectionLength = length;
		}

		private void preferencesMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = PreferencesForm.ShowDialog(this, Settings.Default);
			switch ( result )
			{
				case DialogResult.OK:
					Settings.Default.Save();
					break;
			};
		}
		
		private void LoadPreferences()
		{
			this.Size = Settings.Default.MainFormSize;
			this.Location = Settings.Default.MainFormLocation;
			this.Opacity = Settings.Default.MainFormOpacity;
			this.lengthUpDown.Value = Settings.Default.PasswordLength;
		}

		private void SavePreferences()
		{
			// Copy window size to app settings
			if ( this.WindowState == FormWindowState.Normal )
			{
				Settings.Default.MainFormSize = this.Size;
			}
			else
			{
				Settings.Default.MainFormSize = this.RestoreBounds.Size;
			}
			Settings.Default.MainFormLocation = this.Location;
			Settings.Default.MainFormOpacity = this.Opacity;
			Settings.Default.PasswordLength = lengthUpDown.Value;
			Settings.Default.Save();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SavePreferences();
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}