namespace Fpi.Ppg.UI
{
	partial class PreferencesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.numbersCheckBox = new System.Windows.Forms.CheckBox();
			this.numbersTextBox = new System.Windows.Forms.TextBox();
			this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
			this.passwordGenerationGroupBox = new System.Windows.Forms.GroupBox();
			this.symbolsUpDown = new System.Windows.Forms.NumericUpDown();
			this.numbersUpDown = new System.Windows.Forms.NumericUpDown();
			this.mixedCaseRadioButton = new System.Windows.Forms.RadioButton();
			this.upperCaseRadioButton = new System.Windows.Forms.RadioButton();
			this.lowerCaseRadioButton = new System.Windows.Forms.RadioButton();
			this.symbolsTextBox = new System.Windows.Forms.TextBox();
			this.characterGraphCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.newButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.characterGraphGroupBox = new System.Windows.Forms.GroupBox();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.passwordGenerationGroupBox.SuspendLayout();
			( (System.ComponentModel.ISupportInitialize)( this.symbolsUpDown ) ).BeginInit();
			( (System.ComponentModel.ISupportInitialize)( this.numbersUpDown ) ).BeginInit();
			this.characterGraphGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// numbersCheckBox
			// 
			this.numbersCheckBox.AutoSize = true;
			this.numbersCheckBox.Location = new System.Drawing.Point(9, 19);
			this.numbersCheckBox.Name = "numbersCheckBox";
			this.numbersCheckBox.Size = new System.Drawing.Size(106, 17);
			this.numbersCheckBox.TabIndex = 0;
			this.numbersCheckBox.Text = "Include Numbers";
			this.numbersCheckBox.UseVisualStyleBackColor = true;
			// 
			// numbersTextBox
			// 
			this.numbersTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
			this.numbersTextBox.Location = new System.Drawing.Point(121, 19);
			this.numbersTextBox.MaxLength = 10;
			this.numbersTextBox.Name = "numbersTextBox";
			this.numbersTextBox.Size = new System.Drawing.Size(112, 22);
			this.numbersTextBox.TabIndex = 1;
			this.numbersTextBox.Text = "0123456789";
			// 
			// symbolsCheckBox
			// 
			this.symbolsCheckBox.AutoSize = true;
			this.symbolsCheckBox.Location = new System.Drawing.Point(9, 50);
			this.symbolsCheckBox.Name = "symbolsCheckBox";
			this.symbolsCheckBox.Size = new System.Drawing.Size(103, 17);
			this.symbolsCheckBox.TabIndex = 2;
			this.symbolsCheckBox.Text = "Include Symbols";
			this.symbolsCheckBox.UseVisualStyleBackColor = true;
			// 
			// passwordGenerationGroupBox
			// 
			this.passwordGenerationGroupBox.Controls.Add(this.symbolsUpDown);
			this.passwordGenerationGroupBox.Controls.Add(this.numbersUpDown);
			this.passwordGenerationGroupBox.Controls.Add(this.mixedCaseRadioButton);
			this.passwordGenerationGroupBox.Controls.Add(this.upperCaseRadioButton);
			this.passwordGenerationGroupBox.Controls.Add(this.lowerCaseRadioButton);
			this.passwordGenerationGroupBox.Controls.Add(this.symbolsTextBox);
			this.passwordGenerationGroupBox.Controls.Add(this.symbolsCheckBox);
			this.passwordGenerationGroupBox.Controls.Add(this.numbersCheckBox);
			this.passwordGenerationGroupBox.Controls.Add(this.numbersTextBox);
			this.passwordGenerationGroupBox.Location = new System.Drawing.Point(12, 12);
			this.passwordGenerationGroupBox.Name = "passwordGenerationGroupBox";
			this.passwordGenerationGroupBox.Size = new System.Drawing.Size(291, 108);
			this.passwordGenerationGroupBox.TabIndex = 3;
			this.passwordGenerationGroupBox.TabStop = false;
			this.passwordGenerationGroupBox.Text = "Password Generation";
			// 
			// symbolsUpDown
			// 
			this.symbolsUpDown.Location = new System.Drawing.Point(239, 49);
			this.symbolsUpDown.Name = "symbolsUpDown";
			this.symbolsUpDown.Size = new System.Drawing.Size(43, 20);
			this.symbolsUpDown.TabIndex = 8;
			// 
			// numbersUpDown
			// 
			this.numbersUpDown.Location = new System.Drawing.Point(239, 21);
			this.numbersUpDown.Name = "numbersUpDown";
			this.numbersUpDown.Size = new System.Drawing.Size(43, 20);
			this.numbersUpDown.TabIndex = 7;
			// 
			// mixedCaseRadioButton
			// 
			this.mixedCaseRadioButton.AutoSize = true;
			this.mixedCaseRadioButton.Checked = true;
			this.mixedCaseRadioButton.Location = new System.Drawing.Point(190, 80);
			this.mixedCaseRadioButton.Name = "mixedCaseRadioButton";
			this.mixedCaseRadioButton.Size = new System.Drawing.Size(80, 17);
			this.mixedCaseRadioButton.TabIndex = 6;
			this.mixedCaseRadioButton.TabStop = true;
			this.mixedCaseRadioButton.Text = "Mixed Case";
			this.mixedCaseRadioButton.UseVisualStyleBackColor = true;
			// 
			// upperCaseRadioButton
			// 
			this.upperCaseRadioButton.AutoSize = true;
			this.upperCaseRadioButton.Location = new System.Drawing.Point(91, 80);
			this.upperCaseRadioButton.Name = "upperCaseRadioButton";
			this.upperCaseRadioButton.Size = new System.Drawing.Size(93, 17);
			this.upperCaseRadioButton.TabIndex = 5;
			this.upperCaseRadioButton.TabStop = true;
			this.upperCaseRadioButton.Text = "UPPER CASE";
			this.upperCaseRadioButton.UseVisualStyleBackColor = true;
			// 
			// lowerCaseRadioButton
			// 
			this.lowerCaseRadioButton.AutoSize = true;
			this.lowerCaseRadioButton.Location = new System.Drawing.Point(9, 80);
			this.lowerCaseRadioButton.Name = "lowerCaseRadioButton";
			this.lowerCaseRadioButton.Size = new System.Drawing.Size(76, 17);
			this.lowerCaseRadioButton.TabIndex = 4;
			this.lowerCaseRadioButton.TabStop = true;
			this.lowerCaseRadioButton.Text = "lower case";
			this.lowerCaseRadioButton.UseVisualStyleBackColor = true;
			// 
			// symbolsTextBox
			// 
			this.symbolsTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
			this.symbolsTextBox.Location = new System.Drawing.Point(121, 47);
			this.symbolsTextBox.MaxLength = 32768;
			this.symbolsTextBox.Name = "symbolsTextBox";
			this.symbolsTextBox.Size = new System.Drawing.Size(112, 22);
			this.symbolsTextBox.TabIndex = 3;
			this.symbolsTextBox.Text = "~!@#$%^&*()+=";
			this.symbolsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.symbolsTextBox_KeyPress);
			// 
			// characterGraphCheckedListBox
			// 
			this.characterGraphCheckedListBox.FormattingEnabled = true;
			this.characterGraphCheckedListBox.Location = new System.Drawing.Point(9, 19);
			this.characterGraphCheckedListBox.Name = "characterGraphCheckedListBox";
			this.characterGraphCheckedListBox.Size = new System.Drawing.Size(192, 94);
			this.characterGraphCheckedListBox.TabIndex = 4;
			// 
			// newButton
			// 
			this.newButton.Location = new System.Drawing.Point(207, 19);
			this.newButton.Name = "newButton";
			this.newButton.Size = new System.Drawing.Size(75, 23);
			this.newButton.TabIndex = 5;
			this.newButton.Text = "New ...";
			this.newButton.UseVisualStyleBackColor = true;
			this.newButton.Click += new System.EventHandler(this.newButton_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(207, 55);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 6;
			this.addButton.Text = "Add ...";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(207, 91);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(75, 23);
			this.removeButton.TabIndex = 7;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// characterGraphGroupBox
			// 
			this.characterGraphGroupBox.Controls.Add(this.characterGraphCheckedListBox);
			this.characterGraphGroupBox.Controls.Add(this.removeButton);
			this.characterGraphGroupBox.Controls.Add(this.newButton);
			this.characterGraphGroupBox.Controls.Add(this.addButton);
			this.characterGraphGroupBox.Location = new System.Drawing.Point(12, 126);
			this.characterGraphGroupBox.Name = "characterGraphGroupBox";
			this.characterGraphGroupBox.Size = new System.Drawing.Size(291, 123);
			this.characterGraphGroupBox.TabIndex = 8;
			this.characterGraphGroupBox.TabStop = false;
			this.characterGraphGroupBox.Text = "Character Graph";
			// 
			// okButton
			// 
			this.okButton.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.okButton.Location = new System.Drawing.Point(147, 263);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 9;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(228, 263);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 10;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// PreferencesForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(315, 298);
			this.ControlBox = false;
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.characterGraphGroupBox);
			this.Controls.Add(this.passwordGenerationGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PreferencesForm";
			this.Text = "Preferences";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PreferencesForm_FormClosed);
			this.Load += new System.EventHandler(this.PreferencesForm_Load);
			this.passwordGenerationGroupBox.ResumeLayout(false);
			this.passwordGenerationGroupBox.PerformLayout();
			( (System.ComponentModel.ISupportInitialize)( this.symbolsUpDown ) ).EndInit();
			( (System.ComponentModel.ISupportInitialize)( this.numbersUpDown ) ).EndInit();
			this.characterGraphGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox numbersCheckBox;
		private System.Windows.Forms.TextBox numbersTextBox;
		private System.Windows.Forms.CheckBox symbolsCheckBox;
		private System.Windows.Forms.GroupBox passwordGenerationGroupBox;
		private System.Windows.Forms.RadioButton mixedCaseRadioButton;
		private System.Windows.Forms.RadioButton upperCaseRadioButton;
		private System.Windows.Forms.RadioButton lowerCaseRadioButton;
		private System.Windows.Forms.TextBox symbolsTextBox;
		private System.Windows.Forms.NumericUpDown symbolsUpDown;
		private System.Windows.Forms.NumericUpDown numbersUpDown;
		private System.Windows.Forms.CheckedListBox characterGraphCheckedListBox;
		private System.Windows.Forms.Button newButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.GroupBox characterGraphGroupBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
	}
}