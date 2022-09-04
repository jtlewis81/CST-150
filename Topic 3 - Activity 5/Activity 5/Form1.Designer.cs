
namespace Activity_5
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
			this.wordList_ListBox = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.firstAlphabetical_label = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.lastAlphabetical_label = new System.Windows.Forms.Label();
			this.longest_label = new System.Windows.Forms.Label();
			this.mostVowels_label = new System.Windows.Forms.Label();
			this.getStatisticalWords_button = new System.Windows.Forms.Button();
			this.writeFile_button = new System.Windows.Forms.Button();
			this.openFile_button = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label1.Location = new System.Drawing.Point(140, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Word List Processor";
			// 
			// wordList_ListBox
			// 
			this.wordList_ListBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wordList_ListBox.FormattingEnabled = true;
			this.wordList_ListBox.ItemHeight = 18;
			this.wordList_ListBox.Location = new System.Drawing.Point(120, 198);
			this.wordList_ListBox.Name = "wordList_ListBox";
			this.wordList_ListBox.Size = new System.Drawing.Size(310, 202);
			this.wordList_ListBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label3.Location = new System.Drawing.Point(116, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(293, 22);
			this.label3.TabIndex = 3;
			this.label3.Text = "The file includes the following content:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label4.Location = new System.Drawing.Point(116, 470);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(181, 22);
			this.label4.TabIndex = 4;
			this.label4.Text = "First alphabetical word:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label5.Location = new System.Drawing.Point(116, 505);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(178, 22);
			this.label5.TabIndex = 5;
			this.label5.Text = "Last alphabetical word:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label6.Location = new System.Drawing.Point(116, 542);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 22);
			this.label6.TabIndex = 6;
			this.label6.Text = "Longest word:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label7.Location = new System.Drawing.Point(116, 578);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(174, 22);
			this.label7.TabIndex = 7;
			this.label7.Text = "Word w/ most vowels:";
			// 
			// firstAlphabetical_label
			// 
			this.firstAlphabetical_label.AutoSize = true;
			this.firstAlphabetical_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstAlphabetical_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.firstAlphabetical_label.Location = new System.Drawing.Point(302, 470);
			this.firstAlphabetical_label.Name = "firstAlphabetical_label";
			this.firstAlphabetical_label.Size = new System.Drawing.Size(0, 22);
			this.firstAlphabetical_label.TabIndex = 8;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// lastAlphabetical_label
			// 
			this.lastAlphabetical_label.AutoSize = true;
			this.lastAlphabetical_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastAlphabetical_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lastAlphabetical_label.Location = new System.Drawing.Point(302, 505);
			this.lastAlphabetical_label.Name = "lastAlphabetical_label";
			this.lastAlphabetical_label.Size = new System.Drawing.Size(0, 22);
			this.lastAlphabetical_label.TabIndex = 9;
			// 
			// longest_label
			// 
			this.longest_label.AutoSize = true;
			this.longest_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.longest_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.longest_label.Location = new System.Drawing.Point(302, 542);
			this.longest_label.Name = "longest_label";
			this.longest_label.Size = new System.Drawing.Size(0, 22);
			this.longest_label.TabIndex = 10;
			// 
			// mostVowels_label
			// 
			this.mostVowels_label.AutoSize = true;
			this.mostVowels_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mostVowels_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.mostVowels_label.Location = new System.Drawing.Point(302, 578);
			this.mostVowels_label.Name = "mostVowels_label";
			this.mostVowels_label.Size = new System.Drawing.Size(0, 22);
			this.mostVowels_label.TabIndex = 11;
			// 
			// getStatisticalWords_button
			// 
			this.getStatisticalWords_button.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.getStatisticalWords_button.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.getStatisticalWords_button.Location = new System.Drawing.Point(120, 421);
			this.getStatisticalWords_button.Margin = new System.Windows.Forms.Padding(0);
			this.getStatisticalWords_button.Name = "getStatisticalWords_button";
			this.getStatisticalWords_button.Size = new System.Drawing.Size(310, 32);
			this.getStatisticalWords_button.TabIndex = 12;
			this.getStatisticalWords_button.Text = "Find Statistical Words";
			this.getStatisticalWords_button.UseVisualStyleBackColor = false;
			this.getStatisticalWords_button.Click += new System.EventHandler(this.GetStatisticalWords);
			// 
			// writeFile_button
			// 
			this.writeFile_button.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.writeFile_button.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.writeFile_button.Location = new System.Drawing.Point(120, 623);
			this.writeFile_button.Margin = new System.Windows.Forms.Padding(0);
			this.writeFile_button.Name = "writeFile_button";
			this.writeFile_button.Size = new System.Drawing.Size(310, 32);
			this.writeFile_button.TabIndex = 13;
			this.writeFile_button.Text = "Save Stats To File";
			this.writeFile_button.UseVisualStyleBackColor = false;
			this.writeFile_button.Click += new System.EventHandler(this.SaveStatisticsToFile);
			// 
			// openFile_button
			// 
			this.openFile_button.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.openFile_button.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openFile_button.Location = new System.Drawing.Point(120, 130);
			this.openFile_button.Margin = new System.Windows.Forms.Padding(0);
			this.openFile_button.Name = "openFile_button";
			this.openFile_button.Size = new System.Drawing.Size(310, 32);
			this.openFile_button.TabIndex = 14;
			this.openFile_button.Text = "Open A File";
			this.openFile_button.UseVisualStyleBackColor = false;
			this.openFile_button.Click += new System.EventHandler(this.OpenFile);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label2.Location = new System.Drawing.Point(116, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(314, 52);
			this.label2.TabIndex = 15;
			this.label2.Text = "Open a .txt file containing a list of words, one word per line.";
			// 
			// Form1
			// 
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(566, 698);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.openFile_button);
			this.Controls.Add(this.writeFile_button);
			this.Controls.Add(this.getStatisticalWords_button);
			this.Controls.Add(this.mostVowels_label);
			this.Controls.Add(this.longest_label);
			this.Controls.Add(this.lastAlphabetical_label);
			this.Controls.Add(this.firstAlphabetical_label);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.wordList_ListBox);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Activity 5";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox wordList_ListBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label firstAlphabetical_label;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label lastAlphabetical_label;
		private System.Windows.Forms.Label longest_label;
		private System.Windows.Forms.Label mostVowels_label;
		private System.Windows.Forms.Button getStatisticalWords_button;
		private System.Windows.Forms.Button writeFile_button;
		private System.Windows.Forms.Button openFile_button;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Label label2;
	}
}

