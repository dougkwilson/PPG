namespace Dkw.UI
{
	partial class SplashForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
			this.WarningLabel = new System.Windows.Forms.Label();
			this.LogoPictureBox = new System.Windows.Forms.PictureBox();
			this.applicationNameLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.fadeTimer = new System.Windows.Forms.Timer(this.components);
			this.StatusLabel = new System.Windows.Forms.Label();
			this.closeLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// WarningLabel
			// 
			this.WarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.WarningLabel.Location = new System.Drawing.Point(12, 198);
			this.WarningLabel.Name = "WarningLabel";
			this.WarningLabel.Size = new System.Drawing.Size(419, 54);
			this.WarningLabel.TabIndex = 6;
			this.WarningLabel.Text = resources.GetString("WarningLabel.Text");
			this.WarningLabel.Click += new System.EventHandler(this.SplashForm_Click);
			// 
			// LogoPictureBox
			// 
			this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
			this.LogoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.InitialImage")));
			this.LogoPictureBox.Location = new System.Drawing.Point(12, 19);
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.LogoPictureBox.Size = new System.Drawing.Size(100, 100);
			this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.LogoPictureBox.TabIndex = 1;
			this.LogoPictureBox.TabStop = false;
			this.LogoPictureBox.Click += new System.EventHandler(this.SplashForm_Click);
			// 
			// applicationNameLabel
			// 
			this.applicationNameLabel.AutoSize = true;
			this.applicationNameLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.applicationNameLabel.Location = new System.Drawing.Point(118, 19);
			this.applicationNameLabel.Name = "applicationNameLabel";
			this.applicationNameLabel.Size = new System.Drawing.Size(214, 96);
			this.applicationNameLabel.TabIndex = 2;
			this.applicationNameLabel.Text = "Pronounceable\r\nPassword\r\nGenerator";
			this.applicationNameLabel.Click += new System.EventHandler(this.SplashForm_Click);
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(121, 115);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(46, 13);
			this.versionLabel.TabIndex = 3;
			this.versionLabel.Text = "v1.0.0.0";
			this.versionLabel.Click += new System.EventHandler(this.SplashForm_Click);
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Location = new System.Drawing.Point(121, 137);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(51, 13);
			this.copyrightLabel.TabIndex = 4;
			this.copyrightLabel.Text = "Copyright";
			this.copyrightLabel.Click += new System.EventHandler(this.SplashForm_Click);
			// 
			// fadeTimer
			// 
			this.fadeTimer.Tick += new System.EventHandler(this.fadeTimer_Tick);
			// 
			// StatusLabel
			// 
			this.StatusLabel.AutoEllipsis = true;
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.Location = new System.Drawing.Point(121, 173);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(0, 13);
			this.StatusLabel.TabIndex = 2;
			this.StatusLabel.Click += new System.EventHandler(this.SplashForm_Click);
			// 
			// closeLabel
			// 
			this.closeLabel.AutoSize = true;
			this.closeLabel.Location = new System.Drawing.Point(396, 254);
			this.closeLabel.Name = "closeLabel";
			this.closeLabel.Size = new System.Drawing.Size(33, 13);
			this.closeLabel.TabIndex = 7;
			this.closeLabel.Text = "Close";
			this.closeLabel.Visible = false;
			this.closeLabel.Click += new System.EventHandler(this.SplashForm_Click);
			// 
			// SplashForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(443, 276);
			this.ControlBox = false;
			this.Controls.Add(this.closeLabel);
			this.Controls.Add(this.LogoPictureBox);
			this.Controls.Add(this.applicationNameLabel);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.StatusLabel);
			this.Controls.Add(this.WarningLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SplashForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jadeia";
			this.TopMost = true;
			this.Click += new System.EventHandler(this.SplashForm_Click);
			((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox LogoPictureBox;
		private System.Windows.Forms.Label copyrightLabel;
		private System.Windows.Forms.Label applicationNameLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label WarningLabel;
		private System.Windows.Forms.Timer fadeTimer;
		private System.Windows.Forms.Label StatusLabel;
		private System.Windows.Forms.Label closeLabel;

	}
}