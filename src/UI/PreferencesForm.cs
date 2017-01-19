using System;
using System.Windows.Forms;
using Dkw.Properties;

namespace Dkw.UI
{
	public partial class PreferencesForm : Form
	{
		Settings _settings;

		private PreferencesForm() {
			InitializeComponent();
		}

		internal static DialogResult ShowDialog(IWin32Window owner, Settings settings) {
			PreferencesForm form = new PreferencesForm();
			form._settings = settings;
			return form.ShowDialog(owner);
		}

		private void inputBrowseButton_Click(object sender, EventArgs e) {
			using (var dlg = new OpenFileDialog()) {
				dlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
				switch (dlg.ShowDialog(this)) {
					case DialogResult.OK:
						inputFilenameTextbox.Text = dlg.FileName;
						break;
					case DialogResult.Cancel:
						break;
				}
			}
		}

		private void PreferencesForm_Load(object sender, EventArgs e) {
			LoadPreferences();
		}

		private void LoadPreferences() {
			inputFilenameTextbox.Text = _settings.CorpusFilename;
			characterSetTextbox.Text = _settings.CharSet;
		}

		private void SavePreferences() {
			_settings.CorpusFilename = inputFilenameTextbox.Text;
			_settings.CharSet = characterSetTextbox.Text;
		}

		private void okButton_Click(object sender, EventArgs e) {
			SavePreferences();
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
