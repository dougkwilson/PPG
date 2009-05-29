using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fpi.Ppg.UI
{
	public partial class PreferencesForm : Form
	{
		Fpi.Properties.Settings _settings;

		private PreferencesForm()
		{
			InitializeComponent();
		}

		internal static DialogResult ShowDialog(IWin32Window owner, Fpi.Properties.Settings settings)
		{
			PreferencesForm form = new PreferencesForm();
			form._settings = settings;
			return form.ShowDialog(owner);
		}

		private void symbolsTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ( Fpi.Security.GraphManager.Symbols.IndexOf(e.KeyChar) < 0 )
				e.Handled = true;
		}

		private void PreferencesForm_Load(object sender, EventArgs e)
		{
			LoadPreferences();
		}

		private void PreferencesForm_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		private void LoadPreferences()
		{
			numbersCheckBox.Checked = _settings.IncludeNumbers;
			numbersUpDown.Value = _settings.NumberFrequency;
			numbersTextBox.Text = _settings.NumberCharacters;

			symbolsCheckBox.Checked = _settings.IncludeSymbols;
			symbolsUpDown.Value = _settings.SymbolFrequency;
			symbolsTextBox.Text = _settings.SymbolCharacters;

			switch ( _settings.CharacterCase )
			{
				case CharacterCase.LowerCase:
					lowerCaseRadioButton.Checked = true;
					break;
				case CharacterCase.UpperCase:
					upperCaseRadioButton.Checked = true;
					break;
				case CharacterCase.MixedCase:
					mixedCaseRadioButton.Checked = true;
					break;
			}
		}

		private void SavePreferences()
		{
			_settings.IncludeNumbers = numbersCheckBox.Checked;
			_settings.NumberFrequency = Convert.ToInt32(numbersUpDown.Value);
			_settings.NumberCharacters = numbersTextBox.Text;

			_settings.IncludeSymbols = symbolsCheckBox.Checked;
			_settings.SymbolFrequency = Convert.ToInt32(symbolsUpDown.Value);
			_settings.SymbolCharacters = symbolsTextBox.Text;

			if (lowerCaseRadioButton.Checked)
				_settings.CharacterCase = CharacterCase.LowerCase;
			else if (upperCaseRadioButton.Checked)
				_settings.CharacterCase = CharacterCase.UpperCase;
			else if (mixedCaseRadioButton.Checked)
				_settings.CharacterCase = CharacterCase.MixedCase;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			SavePreferences();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void newButton_Click(object sender, EventArgs e)
		{
			CharacterGraphForm frm = new CharacterGraphForm();
			frm.ShowDialog(this);
		}

		private void addButton_Click(object sender, EventArgs e)
		{

		}

		private void removeButton_Click(object sender, EventArgs e)
		{

		}

	}
}