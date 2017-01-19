using System;
using System.Windows.Forms;
using Dkw.Ppg;

namespace Dkw.UI
{
	public partial class MainForm : Form
	{

		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			LoadPreferences();
		}

		private void MainForm_Shown(object sender, EventArgs e) {
		}

		private void MainForm_Click(object sender, EventArgs e) {
			SplashForm.CloseSplashScreen();
		}

		private void generateButton_Click(object sender, EventArgs e) {
			var pg = new PasswordGenerator(Program.Settings.FrequencyTable);
			passwordTextBox.Text = pg.Generate(Convert.ToInt32(lengthUpDown.Value));
		}

		private void aboutMenuItem_Click(object sender, EventArgs e) {
			SplashForm.ShowSplashScreen(true);
		}

		private void copyButton_Click(object sender, EventArgs e) {
			CopyPassword();
		}

		private void CopyPassword() {
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

		private void preferencesMenuItem_Click(object sender, EventArgs e) {
			DialogResult result = PreferencesForm.ShowDialog(this, Program.Settings);
			switch (result) {
				case DialogResult.OK:
					Program.Settings.Save();
					break;
			}
		}

		private void LoadPreferences() {
			Size = Program.Settings.MainFormSize;
			Location = Program.Settings.MainFormLocation;
			lengthUpDown.Value = Program.Settings.PasswordLength;
		}

		private void SavePreferences(Boolean exiting) {
			// Copy window size to app settings
			if (WindowState == FormWindowState.Normal) {
				Program.Settings.MainFormSize = Size;
			} else {
				Program.Settings.MainFormSize = RestoreBounds.Size;
			}
			Program.Settings.MainFormLocation = Location;
			Program.Settings.PasswordLength = lengthUpDown.Value;
			Program.Settings.Save(exiting);
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
			SavePreferences(true);
		}
	}
}