
namespace Activity_7
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
			this.input_textbox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.io_label = new System.Windows.Forms.Label();
			this.output_label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter # of Terms:";
			// 
			// input_textbox
			// 
			this.input_textbox.Location = new System.Drawing.Point(185, 39);
			this.input_textbox.Name = "input_textbox";
			this.input_textbox.Size = new System.Drawing.Size(167, 29);
			this.input_textbox.TabIndex = 1;
			this.input_textbox.Text = "0";
			this.input_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.button1.Location = new System.Drawing.Point(58, 96);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(294, 48);
			this.button1.TabIndex = 2;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.CalculatePI);
			// 
			// io_label
			// 
			this.io_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.io_label.Location = new System.Drawing.Point(55, 166);
			this.io_label.Name = "io_label";
			this.io_label.Size = new System.Drawing.Size(297, 24);
			this.io_label.TabIndex = 3;
			this.io_label.Text = "The approximate value of PI for 0 terms =";
			// 
			// output_label
			// 
			this.output_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.output_label.Location = new System.Drawing.Point(54, 209);
			this.output_label.Name = "output_label";
			this.output_label.Size = new System.Drawing.Size(298, 124);
			this.output_label.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(412, 358);
			this.Controls.Add(this.output_label);
			this.Controls.Add(this.io_label);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.input_textbox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.Info;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Activity 7 - PI Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox input_textbox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label io_label;
		private System.Windows.Forms.Label output_label;
	}
}

