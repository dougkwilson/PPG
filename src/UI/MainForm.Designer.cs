namespace Dkw.UI
{
	partial class MainForm
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
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.generateButton = new System.Windows.Forms.Button();
			this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
			this.copyButton = new System.Windows.Forms.Button();
			this.formMenuStrip = new System.Windows.Forms.MenuStrip();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferencesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
			this.formMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.Location = new System.Drawing.Point(60, 31);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(133, 22);
			this.passwordTextBox.TabIndex = 0;
			// 
			// generateButton
			// 
			this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.generateButton.Location = new System.Drawing.Point(199, 31);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(59, 23);
			this.generateButton.TabIndex = 1;
			this.generateButton.Text = "Generate";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// lengthUpDown
			// 
			this.lengthUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lengthUpDown.Location = new System.Drawing.Point(12, 32);
			this.lengthUpDown.Maximum = new decimal(new int[] {
						20,
						0,
						0,
						0});
			this.lengthUpDown.Minimum = new decimal(new int[] {
						5,
						0,
						0,
						0});
			this.lengthUpDown.Name = "lengthUpDown";
			this.lengthUpDown.Size = new System.Drawing.Size(42, 20);
			this.lengthUpDown.TabIndex = 3;
			this.lengthUpDown.Value = new decimal(new int[] {
						8,
						0,
						0,
						0});
			// 
			// copyButton
			// 
			this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.copyButton.Location = new System.Drawing.Point(264, 31);
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(59, 23);
			this.copyButton.TabIndex = 4;
			this.copyButton.Text = "Copy";
			this.copyButton.UseVisualStyleBackColor = true;
			this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// formMenuStrip
			// 
			this.formMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.aboutMenuItem,
						this.preferencesMenuItem});
			this.formMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.formMenuStrip.Name = "formMenuStrip";
			this.formMenuStrip.Size = new System.Drawing.Size(335, 24);
			this.formMenuStrip.TabIndex = 5;
			this.formMenuStrip.Text = "menuStrip1";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutMenuItem.Text = "&About";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// preferencesMenuItem
			// 
			this.preferencesMenuItem.Name = "preferencesMenuItem";
			this.preferencesMenuItem.Size = new System.Drawing.Size(80, 20);
			this.preferencesMenuItem.Text = "&Preferences";
			this.preferencesMenuItem.Click += new System.EventHandler(this.preferencesMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 87);
			this.Controls.Add(this.copyButton);
			this.Controls.Add(this.lengthUpDown);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.formMenuStrip);
			this.MaximumSize = new System.Drawing.Size(377, 126);
			this.MinimumSize = new System.Drawing.Size(266, 126);
			this.Name = "MainForm";
			this.Text = "Pronounceable Password Generator";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.Click += new System.EventHandler(this.MainForm_Click);
			((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
			this.formMenuStrip.ResumeLayout(false);
			this.formMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.NumericUpDown lengthUpDown;
		private System.Windows.Forms.Button copyButton;
		private System.Windows.Forms.MenuStrip formMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preferencesMenuItem;
	}
}

