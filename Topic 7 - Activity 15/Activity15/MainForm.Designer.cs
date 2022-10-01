
namespace Activity15
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
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.holiday_comboBox = new System.Windows.Forms.ComboBox();
			this.nextQuestion_comboBox = new System.Windows.Forms.ComboBox();
			this.getNumbers_button = new System.Windows.Forms.Button();
			this.exit_button = new System.Windows.Forms.Button();
			this.holiday_label = new System.Windows.Forms.Label();
			this.nextQuestion_label = new System.Windows.Forms.Label();
			this.title_label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// holiday_comboBox
			// 
			this.holiday_comboBox.FormattingEnabled = true;
			this.holiday_comboBox.Location = new System.Drawing.Point(29, 90);
			this.holiday_comboBox.Name = "holiday_comboBox";
			this.holiday_comboBox.Size = new System.Drawing.Size(223, 27);
			this.holiday_comboBox.TabIndex = 0;
			this.holiday_comboBox.SelectedIndexChanged += new System.EventHandler(this.GetNextQuestion);
			// 
			// nextQuestion_comboBox
			// 
			this.nextQuestion_comboBox.FormattingEnabled = true;
			this.nextQuestion_comboBox.Location = new System.Drawing.Point(29, 157);
			this.nextQuestion_comboBox.Name = "nextQuestion_comboBox";
			this.nextQuestion_comboBox.Size = new System.Drawing.Size(223, 27);
			this.nextQuestion_comboBox.TabIndex = 1;
			// 
			// getNumbers_button
			// 
			this.getNumbers_button.Location = new System.Drawing.Point(29, 208);
			this.getNumbers_button.Name = "getNumbers_button";
			this.getNumbers_button.Size = new System.Drawing.Size(223, 46);
			this.getNumbers_button.TabIndex = 2;
			this.getNumbers_button.Text = "Get Your Number!";
			this.getNumbers_button.UseVisualStyleBackColor = true;
			this.getNumbers_button.Click += new System.EventHandler(this.CalculateLuckyNumber);
			// 
			// exit_button
			// 
			this.exit_button.Location = new System.Drawing.Point(29, 275);
			this.exit_button.Name = "exit_button";
			this.exit_button.Size = new System.Drawing.Size(223, 46);
			this.exit_button.TabIndex = 3;
			this.exit_button.Text = "E&xit";
			this.exit_button.UseVisualStyleBackColor = true;
			this.exit_button.Click += new System.EventHandler(this.Exit);
			// 
			// holiday_label
			// 
			this.holiday_label.AutoSize = true;
			this.holiday_label.Location = new System.Drawing.Point(25, 68);
			this.holiday_label.Name = "holiday_label";
			this.holiday_label.Size = new System.Drawing.Size(195, 19);
			this.holiday_label.TabIndex = 4;
			this.holiday_label.Text = "What is your favorite Holiday?";
			// 
			// nextQuestion_label
			// 
			this.nextQuestion_label.AutoSize = true;
			this.nextQuestion_label.Location = new System.Drawing.Point(25, 135);
			this.nextQuestion_label.Name = "nextQuestion_label";
			this.nextQuestion_label.Size = new System.Drawing.Size(205, 19);
			this.nextQuestion_label.TabIndex = 5;
			this.nextQuestion_label.Text = "Answer above for next question...";
			// 
			// title_label
			// 
			this.title_label.AutoSize = true;
			this.title_label.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title_label.Location = new System.Drawing.Point(25, 25);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(227, 24);
			this.title_label.TabIndex = 6;
			this.title_label.Text = "Get Your Lucky Number!";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(294, 348);
			this.Controls.Add(this.title_label);
			this.Controls.Add(this.nextQuestion_label);
			this.Controls.Add(this.holiday_label);
			this.Controls.Add(this.exit_button);
			this.Controls.Add(this.getNumbers_button);
			this.Controls.Add(this.nextQuestion_comboBox);
			this.Controls.Add(this.holiday_comboBox);
			this.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Activity 15";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox nextQuestion_comboBox;
		private System.Windows.Forms.Button getNumbers_button;
		private System.Windows.Forms.Button exit_button;
		private System.Windows.Forms.Label holiday_label;
		private System.Windows.Forms.Label nextQuestion_label;
		private System.Windows.Forms.Label title_label;
		public System.Windows.Forms.ComboBox holiday_comboBox;
	}
}

