namespace GOOOOOOOOOOOOOOL {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			EnableBox = new CheckBox();
			ChanceBar = new TrackBar();
			ChanceLabel = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)ChanceBar).BeginInit();
			SuspendLayout();
			// 
			// EnableBox
			// 
			EnableBox.AutoSize = true;
			EnableBox.Location = new Point(12, 12);
			EnableBox.Name = "EnableBox";
			EnableBox.Size = new Size(81, 19);
			EnableBox.TabIndex = 0;
			EnableBox.Text = "Включить";
			EnableBox.UseVisualStyleBackColor = true;
			EnableBox.CheckedChanged += EnableBox_CheckedChanged;
			// 
			// ChanceBar
			// 
			ChanceBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ChanceBar.Location = new Point(12, 37);
			ChanceBar.Maximum = 100;
			ChanceBar.Minimum = 1;
			ChanceBar.Name = "ChanceBar";
			ChanceBar.Size = new Size(364, 45);
			ChanceBar.TabIndex = 1;
			ChanceBar.Value = 10;
			ChanceBar.Scroll += ChanceBar_Scroll;
			// 
			// ChanceLabel
			// 
			ChanceLabel.AutoSize = true;
			ChanceLabel.Enabled = false;
			ChanceLabel.Location = new Point(12, 85);
			ChanceLabel.Name = "ChanceLabel";
			ChanceLabel.Size = new Size(65, 15);
			ChanceLabel.TabIndex = 2;
			ChanceLabel.Text = "Шанс: 10%";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.Enabled = false;
			label1.ForeColor = SystemColors.WindowText;
			label1.Location = new Point(12, 100);
			label1.Name = "label1";
			label1.Size = new Size(364, 79);
			label1.TabIndex = 3;
			label1.Text = resources.GetString("label1.Text");
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(388, 188);
			Controls.Add(label1);
			Controls.Add(ChanceLabel);
			Controls.Add(ChanceBar);
			Controls.Add(EnableBox);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimumSize = new Size(404, 227);
			Name = "Form1";
			Text = "ГОООООООООООЛ";
			((System.ComponentModel.ISupportInitialize)ChanceBar).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox EnableBox;
		private TrackBar ChanceBar;
		private Label ChanceLabel;
		private Label label1;
	}
}
