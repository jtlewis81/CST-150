
namespace Activity_11
{
	partial class Activity11
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity11));
			this.roll_button = new System.Windows.Forms.Button();
			this.die1_groupBox = new System.Windows.Forms.GroupBox();
			this.die1_label = new System.Windows.Forms.Label();
			this.die2_groupBox = new System.Windows.Forms.GroupBox();
			this.die2_label = new System.Windows.Forms.Label();
			this.die1_groupBox.SuspendLayout();
			this.die2_groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// roll_button
			// 
			this.roll_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.roll_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roll_button.ForeColor = System.Drawing.Color.White;
			this.roll_button.Location = new System.Drawing.Point(29, 25);
			this.roll_button.Name = "roll_button";
			this.roll_button.Size = new System.Drawing.Size(100, 100);
			this.roll_button.TabIndex = 0;
			this.roll_button.Text = "ROLL DICE";
			this.roll_button.UseVisualStyleBackColor = false;
			this.roll_button.Click += new System.EventHandler(this.RollDice);
			// 
			// die1_groupBox
			// 
			this.die1_groupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.die1_groupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.die1_groupBox.Controls.Add(this.die1_label);
			this.die1_groupBox.Location = new System.Drawing.Point(164, 25);
			this.die1_groupBox.Name = "die1_groupBox";
			this.die1_groupBox.Size = new System.Drawing.Size(100, 100);
			this.die1_groupBox.TabIndex = 1;
			this.die1_groupBox.TabStop = false;
			// 
			// die1_label
			// 
			this.die1_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.die1_label.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.die1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.die1_label.Location = new System.Drawing.Point(3, 22);
			this.die1_label.Name = "die1_label";
			this.die1_label.Size = new System.Drawing.Size(94, 55);
			this.die1_label.TabIndex = 0;
			this.die1_label.Text = "2";
			this.die1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// die2_groupBox
			// 
			this.die2_groupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.die2_groupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.die2_groupBox.Controls.Add(this.die2_label);
			this.die2_groupBox.Location = new System.Drawing.Point(298, 25);
			this.die2_groupBox.Name = "die2_groupBox";
			this.die2_groupBox.Size = new System.Drawing.Size(100, 100);
			this.die2_groupBox.TabIndex = 2;
			this.die2_groupBox.TabStop = false;
			// 
			// die2_label
			// 
			this.die2_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.die2_label.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.die2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.die2_label.Location = new System.Drawing.Point(3, 22);
			this.die2_label.Name = "die2_label";
			this.die2_label.Size = new System.Drawing.Size(94, 55);
			this.die2_label.TabIndex = 0;
			this.die2_label.Text = "3";
			this.die2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Activity11
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(419, 150);
			this.Controls.Add(this.die2_groupBox);
			this.Controls.Add(this.die1_groupBox);
			this.Controls.Add(this.roll_button);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Activity11";
			this.Text = "Activity 11";
			this.die1_groupBox.ResumeLayout(false);
			this.die2_groupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button roll_button;
		private System.Windows.Forms.GroupBox die1_groupBox;
		private System.Windows.Forms.Label die1_label;
		private System.Windows.Forms.GroupBox die2_groupBox;
		private System.Windows.Forms.Label die2_label;
	}
}

