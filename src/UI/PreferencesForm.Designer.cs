namespace Dkw.UI
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
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.characterGraphGroupBox = new System.Windows.Forms.GroupBox();
			this.inputLabel = new System.Windows.Forms.Label();
			this.inputBrowseButton = new System.Windows.Forms.Button();
			this.inputFilenameTextbox = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.characterSetLabel = new System.Windows.Forms.Label();
			this.characterSetTextbox = new System.Windows.Forms.TextBox();
			this.characterGraphGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// characterGraphGroupBox
			// 
			this.characterGraphGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.characterGraphGroupBox.Controls.Add(this.characterSetLabel);
			this.characterGraphGroupBox.Controls.Add(this.characterSetTextbox);
			this.characterGraphGroupBox.Controls.Add(this.inputLabel);
			this.characterGraphGroupBox.Controls.Add(this.inputBrowseButton);
			this.characterGraphGroupBox.Controls.Add(this.inputFilenameTextbox);
			this.characterGraphGroupBox.Location = new System.Drawing.Point(12, 12);
			this.characterGraphGroupBox.Name = "characterGraphGroupBox";
			this.characterGraphGroupBox.Size = new System.Drawing.Size(410, 114);
			this.characterGraphGroupBox.TabIndex = 8;
			this.characterGraphGroupBox.TabStop = false;
			this.characterGraphGroupBox.Text = "Character Frequency";
			// 
			// inputLabel
			// 
			this.inputLabel.AutoSize = true;
			this.inputLabel.Location = new System.Drawing.Point(11, 20);
			this.inputLabel.Name = "inputLabel";
			this.inputLabel.Size = new System.Drawing.Size(74, 13);
			this.inputLabel.TabIndex = 5;
			this.inputLabel.Text = "Input Text File";
			// 
			// inputBrowseButton
			// 
			this.inputBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.inputBrowseButton.Location = new System.Drawing.Point(323, 34);
			this.inputBrowseButton.Name = "inputBrowseButton";
			this.inputBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.inputBrowseButton.TabIndex = 4;
			this.inputBrowseButton.Text = "Browse";
			this.inputBrowseButton.UseVisualStyleBackColor = true;
			this.inputBrowseButton.Click += new System.EventHandler(this.inputBrowseButton_Click);
			// 
			// inputFilenameTextbox
			// 
			this.inputFilenameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.inputFilenameTextbox.Location = new System.Drawing.Point(11, 36);
			this.inputFilenameTextbox.Name = "inputFilenameTextbox";
			this.inputFilenameTextbox.Size = new System.Drawing.Size(306, 20);
			this.inputFilenameTextbox.TabIndex = 3;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(266, 136);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 9;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(347, 136);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 10;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// characterSetLabel
			// 
			this.characterSetLabel.AutoSize = true;
			this.characterSetLabel.Location = new System.Drawing.Point(11, 59);
			this.characterSetLabel.Name = "characterSetLabel";
			this.characterSetLabel.Size = new System.Drawing.Size(72, 13);
			this.characterSetLabel.TabIndex = 7;
			this.characterSetLabel.Text = "Character Set";
			// 
			// characterSetTextbox
			// 
			this.characterSetTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.characterSetTextbox.Location = new System.Drawing.Point(11, 75);
			this.characterSetTextbox.Name = "characterSetTextbox";
			this.characterSetTextbox.Size = new System.Drawing.Size(387, 20);
			this.characterSetTextbox.TabIndex = 6;
			// 
			// PreferencesForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(434, 171);
			this.ControlBox = false;
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.characterGraphGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PreferencesForm";
			this.Text = "Preferences";
			this.Load += new System.EventHandler(this.PreferencesForm_Load);
			this.characterGraphGroupBox.ResumeLayout(false);
			this.characterGraphGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox characterGraphGroupBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label inputLabel;
		private System.Windows.Forms.Button inputBrowseButton;
		private System.Windows.Forms.TextBox inputFilenameTextbox;
		private System.Windows.Forms.Label characterSetLabel;
		private System.Windows.Forms.TextBox characterSetTextbox;
	}
}