
namespace Activity4
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_seconds = new System.Windows.Forms.TextBox();
			this.label_output = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 106);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(284, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter the Number of Seconds Elapsed:";
			// 
			// textBox_seconds
			// 
			this.textBox_seconds.Location = new System.Drawing.Point(322, 103);
			this.textBox_seconds.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_seconds.Name = "textBox_seconds";
			this.textBox_seconds.Size = new System.Drawing.Size(232, 26);
			this.textBox_seconds.TabIndex = 1;
			this.textBox_seconds.TextChanged += new System.EventHandler(this.UpdateTime);
			// 
			// label_output
			// 
			this.label_output.AutoSize = true;
			this.label_output.Location = new System.Drawing.Point(157, 181);
			this.label_output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_output.Name = "label_output";
			this.label_output.Size = new System.Drawing.Size(0, 22);
			this.label_output.TabIndex = 2;
			this.label_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(218, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 27);
			this.label2.TabIndex = 3;
			this.label2.Text = "Time Calculator";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(593, 305);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label_output);
			this.Controls.Add(this.textBox_seconds);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Activity 4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_seconds;
		private System.Windows.Forms.Label label_output;
		private System.Windows.Forms.Label label2;
	}
}

