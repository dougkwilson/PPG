using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fpi.Ppg.UI
{
	public partial class CharacterGraphForm : Form
	{
		public CharacterGraphForm()
		{
			InitializeComponent();
		}

		private void browseButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			switch ( dlg.ShowDialog(this) )
			{
				case DialogResult.OK:
					filenameTextBox.Text = dlg.FileName;
					break;
				case DialogResult.Cancel:
					break;
			}
		}

		private void createButton_Click(object sender, EventArgs e)
		{

		}
	}
}