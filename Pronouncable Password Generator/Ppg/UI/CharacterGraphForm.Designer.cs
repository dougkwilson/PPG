namespace Fpi.Ppg.UI
{
	partial class CharacterGraphForm
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
			this.filenameTextBox = new System.Windows.Forms.TextBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.textFileLabel = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.createButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// filenameTextBox
			// 
			this.filenameTextBox.Location = new System.Drawing.Point(12, 25);
			this.filenameTextBox.Name = "filenameTextBox";
			this.filenameTextBox.Size = new System.Drawing.Size(187, 20);
			this.filenameTextBox.TabIndex = 0;
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(205, 23);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(75, 23);
			this.browseButton.TabIndex = 1;
			this.browseButton.Text = "Browse";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// textFileLabel
			// 
			this.textFileLabel.AutoSize = true;
			this.textFileLabel.Location = new System.Drawing.Point(12, 9);
			this.textFileLabel.Name = "textFileLabel";
			this.textFileLabel.Size = new System.Drawing.Size(47, 13);
			this.textFileLabel.TabIndex = 2;
			this.textFileLabel.Text = "Text File";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 51);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(268, 23);
			this.progressBar.TabIndex = 3;
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(124, 80);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(75, 23);
			this.createButton.TabIndex = 4;
			this.createButton.Text = "Create";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(205, 80);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// CharacterGraphForm
			// 
			this.AcceptButton = this.createButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(292, 108);
			this.ControlBox = false;
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.textFileLabel);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.filenameTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "CharacterGraphForm";
			this.Text = "CharacterGraphForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox filenameTextBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Label textFileLabel;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.Button cancelButton;
	}
}