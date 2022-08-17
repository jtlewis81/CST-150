// Jamie Lewis
// CST-150
// 8/16/22
// The modifications to this auto-generated file are my own work.

using System;

namespace Topic1_Activity1
{
	partial class Activity1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity1));
			this.text_fname = new System.Windows.Forms.TextBox();
			this.label_fname = new System.Windows.Forms.Label();
			this.label_lname = new System.Windows.Forms.Label();
			this.text_lname = new System.Windows.Forms.TextBox();
			this.btn_hello = new System.Windows.Forms.Button();
			this.label_title = new System.Windows.Forms.Label();
			this.radbtn_male = new System.Windows.Forms.RadioButton();
			this.radbtn_miss = new System.Windows.Forms.RadioButton();
			this.radbtn_mrs = new System.Windows.Forms.RadioButton();
			this.radbtn_ms = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// text_fname
			// 
			this.text_fname.Location = new System.Drawing.Point(187, 159);
			this.text_fname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.text_fname.Name = "text_fname";
			this.text_fname.Size = new System.Drawing.Size(134, 26);
			this.text_fname.TabIndex = 0;
			this.text_fname.TextChanged += new System.EventHandler(this.text_fname_TextChanged);
			// 
			// label_fname
			// 
			this.label_fname.AutoSize = true;
			this.label_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label_fname.Location = new System.Drawing.Point(76, 159);
			this.label_fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_fname.Name = "label_fname";
			this.label_fname.Size = new System.Drawing.Size(90, 20);
			this.label_fname.TabIndex = 1;
			this.label_fname.Text = "First Name:";
			// 
			// label_lname
			// 
			this.label_lname.AutoSize = true;
			this.label_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label_lname.Location = new System.Drawing.Point(76, 208);
			this.label_lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_lname.Name = "label_lname";
			this.label_lname.Size = new System.Drawing.Size(90, 20);
			this.label_lname.TabIndex = 3;
			this.label_lname.Text = "Last Name:";
			// 
			// text_lname
			// 
			this.text_lname.Location = new System.Drawing.Point(187, 208);
			this.text_lname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.text_lname.Name = "text_lname";
			this.text_lname.Size = new System.Drawing.Size(134, 26);
			this.text_lname.TabIndex = 2;
			this.text_lname.TextChanged += new System.EventHandler(this.text_lname_TextChanged);
			// 
			// btn_hello
			// 
			this.btn_hello.ForeColor = System.Drawing.SystemColors.Desktop;
			this.btn_hello.Location = new System.Drawing.Point(142, 279);
			this.btn_hello.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_hello.Name = "btn_hello";
			this.btn_hello.Size = new System.Drawing.Size(112, 35);
			this.btn_hello.TabIndex = 4;
			this.btn_hello.Text = "Say \"Hello\"";
			this.btn_hello.UseVisualStyleBackColor = true;
			this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.label_title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label_title.Location = new System.Drawing.Point(74, 39);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(253, 31);
			this.label_title.TabIndex = 5;
			this.label_title.Text = "Introduce Yourself";
			this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// radbtn_male
			// 
			this.radbtn_male.AutoSize = true;
			this.radbtn_male.Location = new System.Drawing.Point(81, 106);
			this.radbtn_male.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radbtn_male.Name = "radbtn_male";
			this.radbtn_male.Size = new System.Drawing.Size(49, 24);
			this.radbtn_male.TabIndex = 6;
			this.radbtn_male.TabStop = true;
			this.radbtn_male.Text = "Mr.";
			this.radbtn_male.UseVisualStyleBackColor = true;
			this.radbtn_male.CheckedChanged += new System.EventHandler(this.radbtn_male_CheckedChanged);
			// 
			// radbtn_miss
			// 
			this.radbtn_miss.AutoSize = true;
			this.radbtn_miss.Location = new System.Drawing.Point(142, 106);
			this.radbtn_miss.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radbtn_miss.Name = "radbtn_miss";
			this.radbtn_miss.Size = new System.Drawing.Size(59, 24);
			this.radbtn_miss.TabIndex = 7;
			this.radbtn_miss.TabStop = true;
			this.radbtn_miss.Text = "Miss";
			this.radbtn_miss.UseVisualStyleBackColor = true;
			this.radbtn_miss.CheckedChanged += new System.EventHandler(this.radbtn_ms_CheckedChanged);
			// 
			// radbtn_mrs
			// 
			this.radbtn_mrs.AutoSize = true;
			this.radbtn_mrs.Location = new System.Drawing.Point(209, 106);
			this.radbtn_mrs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radbtn_mrs.Name = "radbtn_mrs";
			this.radbtn_mrs.Size = new System.Drawing.Size(57, 24);
			this.radbtn_mrs.TabIndex = 8;
			this.radbtn_mrs.TabStop = true;
			this.radbtn_mrs.Text = "Mrs.";
			this.radbtn_mrs.UseVisualStyleBackColor = true;
			// 
			// radbtn_ms
			// 
			this.radbtn_ms.AutoSize = true;
			this.radbtn_ms.Location = new System.Drawing.Point(276, 106);
			this.radbtn_ms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radbtn_ms.Name = "radbtn_ms";
			this.radbtn_ms.Size = new System.Drawing.Size(52, 24);
			this.radbtn_ms.TabIndex = 9;
			this.radbtn_ms.TabStop = true;
			this.radbtn_ms.Text = "Ms.";
			this.radbtn_ms.UseVisualStyleBackColor = true;
			// 
			// Activity1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(416, 405);
			this.Controls.Add(this.radbtn_ms);
			this.Controls.Add(this.radbtn_mrs);
			this.Controls.Add(this.radbtn_miss);
			this.Controls.Add(this.radbtn_male);
			this.Controls.Add(this.label_title);
			this.Controls.Add(this.btn_hello);
			this.Controls.Add(this.label_lname);
			this.Controls.Add(this.text_lname);
			this.Controls.Add(this.label_fname);
			this.Controls.Add(this.text_fname);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.ForeColor = System.Drawing.SystemColors.Window;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Activity1";
			this.Text = "Activity 1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox text_fname;
		private System.Windows.Forms.Label label_fname;
		private System.Windows.Forms.Label label_lname;
		private System.Windows.Forms.TextBox text_lname;
		private System.Windows.Forms.Button btn_hello;
		private System.Windows.Forms.Label label_title;
		private System.Windows.Forms.RadioButton radbtn_male;
		private System.Windows.Forms.RadioButton radbtn_miss;
		private System.Windows.Forms.RadioButton radbtn_mrs;
		private System.Windows.Forms.RadioButton radbtn_ms;
	}
}

