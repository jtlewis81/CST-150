
namespace Activity_6
{
	partial class Activity6
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity6));
			this.label_title = new System.Windows.Forms.Label();
			this.label_lbs = new System.Windows.Forms.Label();
			this.label_kgs = new System.Windows.Forms.Label();
			this.textbox_lbs = new System.Windows.Forms.TextBox();
			this.textbox_kgs = new System.Windows.Forms.TextBox();
			this.btn_lbsToKgs = new System.Windows.Forms.Button();
			this.btn_kgsToLbs = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.label_title.Location = new System.Drawing.Point(66, 33);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(316, 26);
			this.label_title.TabIndex = 0;
			this.label_title.Text = "Weight Conversion Calculator";
			this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label_lbs
			// 
			this.label_lbs.AutoSize = true;
			this.label_lbs.Location = new System.Drawing.Point(41, 97);
			this.label_lbs.Name = "label_lbs";
			this.label_lbs.Size = new System.Drawing.Size(101, 18);
			this.label_lbs.TabIndex = 1;
			this.label_lbs.Text = "Pounds (Lbs)";
			// 
			// label_kgs
			// 
			this.label_kgs.AutoSize = true;
			this.label_kgs.Location = new System.Drawing.Point(41, 144);
			this.label_kgs.Name = "label_kgs";
			this.label_kgs.Size = new System.Drawing.Size(121, 18);
			this.label_kgs.TabIndex = 4;
			this.label_kgs.Text = "Kilograms (Kgs)";
			// 
			// textbox_lbs
			// 
			this.textbox_lbs.Location = new System.Drawing.Point(172, 94);
			this.textbox_lbs.Name = "textbox_lbs";
			this.textbox_lbs.Size = new System.Drawing.Size(100, 26);
			this.textbox_lbs.TabIndex = 2;
			// 
			// textbox_kgs
			// 
			this.textbox_kgs.Location = new System.Drawing.Point(172, 141);
			this.textbox_kgs.Name = "textbox_kgs";
			this.textbox_kgs.Size = new System.Drawing.Size(100, 26);
			this.textbox_kgs.TabIndex = 5;
			// 
			// btn_lbsToKgs
			// 
			this.btn_lbsToKgs.BackColor = System.Drawing.Color.Teal;
			this.btn_lbsToKgs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_lbsToKgs.ForeColor = System.Drawing.Color.White;
			this.btn_lbsToKgs.Location = new System.Drawing.Point(290, 90);
			this.btn_lbsToKgs.Name = "btn_lbsToKgs";
			this.btn_lbsToKgs.Size = new System.Drawing.Size(115, 35);
			this.btn_lbsToKgs.TabIndex = 3;
			this.btn_lbsToKgs.Text = "Convert to Kgs";
			this.btn_lbsToKgs.UseVisualStyleBackColor = false;
			this.btn_lbsToKgs.Click += new System.EventHandler(this.ConvertToKgs);
			// 
			// btn_kgsToLbs
			// 
			this.btn_kgsToLbs.BackColor = System.Drawing.Color.Teal;
			this.btn_kgsToLbs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_kgsToLbs.ForeColor = System.Drawing.Color.White;
			this.btn_kgsToLbs.Location = new System.Drawing.Point(290, 137);
			this.btn_kgsToLbs.Name = "btn_kgsToLbs";
			this.btn_kgsToLbs.Size = new System.Drawing.Size(115, 35);
			this.btn_kgsToLbs.TabIndex = 6;
			this.btn_kgsToLbs.Text = "Convert to Lbs";
			this.btn_kgsToLbs.UseVisualStyleBackColor = false;
			this.btn_kgsToLbs.Click += new System.EventHandler(this.ConvertToLbs);
			// 
			// Activity6
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(471, 232);
			this.Controls.Add(this.btn_kgsToLbs);
			this.Controls.Add(this.btn_lbsToKgs);
			this.Controls.Add(this.textbox_kgs);
			this.Controls.Add(this.textbox_lbs);
			this.Controls.Add(this.label_kgs);
			this.Controls.Add(this.label_lbs);
			this.Controls.Add(this.label_title);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Activity6";
			this.Text = "Activity6";
			this.Load += new System.EventHandler(this.Activity6_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_title;
		private System.Windows.Forms.Label label_lbs;
		private System.Windows.Forms.Label label_kgs;
		private System.Windows.Forms.TextBox textbox_lbs;
		private System.Windows.Forms.TextBox textbox_kgs;
		private System.Windows.Forms.Button btn_lbsToKgs;
		private System.Windows.Forms.Button btn_kgsToLbs;
	}
}

