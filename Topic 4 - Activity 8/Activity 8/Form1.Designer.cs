
namespace Activity_8
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
			this.fat_groupBox = new System.Windows.Forms.GroupBox();
			this.fatCaloriesOutput_label = new System.Windows.Forms.Label();
			this.fatGramsInput_textBox = new System.Windows.Forms.TextBox();
			this.enterFat_label = new System.Windows.Forms.Label();
			this.fat_pictureBox = new System.Windows.Forms.PictureBox();
			this.carbs_groupBox = new System.Windows.Forms.GroupBox();
			this.carbCaloriesOutput_label = new System.Windows.Forms.Label();
			this.carbGramsInput_textBox = new System.Windows.Forms.TextBox();
			this.enterCarbs_label = new System.Windows.Forms.Label();
			this.carbs_pictureBox = new System.Windows.Forms.PictureBox();
			this.totalCalories_label = new System.Windows.Forms.Label();
			this.exit_button = new System.Windows.Forms.Button();
			this.fat_groupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fat_pictureBox)).BeginInit();
			this.carbs_groupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.carbs_pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// fat_groupBox
			// 
			this.fat_groupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.fat_groupBox.Controls.Add(this.fatCaloriesOutput_label);
			this.fat_groupBox.Controls.Add(this.fatGramsInput_textBox);
			this.fat_groupBox.Controls.Add(this.enterFat_label);
			this.fat_groupBox.Controls.Add(this.fat_pictureBox);
			this.fat_groupBox.Location = new System.Drawing.Point(12, 12);
			this.fat_groupBox.Name = "fat_groupBox";
			this.fat_groupBox.Size = new System.Drawing.Size(550, 150);
			this.fat_groupBox.TabIndex = 0;
			this.fat_groupBox.TabStop = false;
			// 
			// fatCaloriesOutput_label
			// 
			this.fatCaloriesOutput_label.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fatCaloriesOutput_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.fatCaloriesOutput_label.Location = new System.Drawing.Point(322, 37);
			this.fatCaloriesOutput_label.Name = "fatCaloriesOutput_label";
			this.fatCaloriesOutput_label.Size = new System.Drawing.Size(196, 80);
			this.fatCaloriesOutput_label.TabIndex = 3;
			this.fatCaloriesOutput_label.Text = "0 Calories";
			this.fatCaloriesOutput_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// fatGramsInput_textBox
			// 
			this.fatGramsInput_textBox.Location = new System.Drawing.Point(145, 77);
			this.fatGramsInput_textBox.Name = "fatGramsInput_textBox";
			this.fatGramsInput_textBox.Size = new System.Drawing.Size(144, 27);
			this.fatGramsInput_textBox.TabIndex = 2;
			this.fatGramsInput_textBox.TextChanged += new System.EventHandler(this.UpdateTotalCalories);
			// 
			// enterFat_label
			// 
			this.enterFat_label.AutoSize = true;
			this.enterFat_label.Location = new System.Drawing.Point(142, 46);
			this.enterFat_label.Name = "enterFat_label";
			this.enterFat_label.Size = new System.Drawing.Size(147, 18);
			this.enterFat_label.TabIndex = 1;
			this.enterFat_label.Text = "Enter Fat Grams:";
			// 
			// fat_pictureBox
			// 
			this.fat_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fat_pictureBox.Image")));
			this.fat_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("fat_pictureBox.InitialImage")));
			this.fat_pictureBox.Location = new System.Drawing.Point(29, 37);
			this.fat_pictureBox.Name = "fat_pictureBox";
			this.fat_pictureBox.Size = new System.Drawing.Size(80, 80);
			this.fat_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.fat_pictureBox.TabIndex = 0;
			this.fat_pictureBox.TabStop = false;
			this.fat_pictureBox.WaitOnLoad = true;
			// 
			// carbs_groupBox
			// 
			this.carbs_groupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.carbs_groupBox.Controls.Add(this.carbCaloriesOutput_label);
			this.carbs_groupBox.Controls.Add(this.carbGramsInput_textBox);
			this.carbs_groupBox.Controls.Add(this.enterCarbs_label);
			this.carbs_groupBox.Controls.Add(this.carbs_pictureBox);
			this.carbs_groupBox.Location = new System.Drawing.Point(12, 183);
			this.carbs_groupBox.Name = "carbs_groupBox";
			this.carbs_groupBox.Size = new System.Drawing.Size(550, 150);
			this.carbs_groupBox.TabIndex = 1;
			this.carbs_groupBox.TabStop = false;
			// 
			// carbCaloriesOutput_label
			// 
			this.carbCaloriesOutput_label.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carbCaloriesOutput_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.carbCaloriesOutput_label.Location = new System.Drawing.Point(322, 40);
			this.carbCaloriesOutput_label.Name = "carbCaloriesOutput_label";
			this.carbCaloriesOutput_label.Size = new System.Drawing.Size(196, 80);
			this.carbCaloriesOutput_label.TabIndex = 6;
			this.carbCaloriesOutput_label.Text = "0 Calories";
			this.carbCaloriesOutput_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// carbGramsInput_textBox
			// 
			this.carbGramsInput_textBox.Location = new System.Drawing.Point(145, 80);
			this.carbGramsInput_textBox.Name = "carbGramsInput_textBox";
			this.carbGramsInput_textBox.Size = new System.Drawing.Size(144, 27);
			this.carbGramsInput_textBox.TabIndex = 5;
			this.carbGramsInput_textBox.TextChanged += new System.EventHandler(this.UpdateTotalCalories);
			// 
			// enterCarbs_label
			// 
			this.enterCarbs_label.AutoSize = true;
			this.enterCarbs_label.Location = new System.Drawing.Point(142, 49);
			this.enterCarbs_label.Name = "enterCarbs_label";
			this.enterCarbs_label.Size = new System.Drawing.Size(159, 18);
			this.enterCarbs_label.TabIndex = 4;
			this.enterCarbs_label.Text = "Enter Carb Grams:";
			// 
			// carbs_pictureBox
			// 
			this.carbs_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("carbs_pictureBox.Image")));
			this.carbs_pictureBox.Location = new System.Drawing.Point(29, 40);
			this.carbs_pictureBox.Name = "carbs_pictureBox";
			this.carbs_pictureBox.Size = new System.Drawing.Size(80, 80);
			this.carbs_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.carbs_pictureBox.TabIndex = 1;
			this.carbs_pictureBox.TabStop = false;
			// 
			// totalCalories_label
			// 
			this.totalCalories_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalCalories_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.totalCalories_label.Location = new System.Drawing.Point(12, 359);
			this.totalCalories_label.Name = "totalCalories_label";
			this.totalCalories_label.Size = new System.Drawing.Size(356, 36);
			this.totalCalories_label.TabIndex = 2;
			this.totalCalories_label.Text = "Total Calories = 0";
			this.totalCalories_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// exit_button
			// 
			this.exit_button.BackColor = System.Drawing.Color.Firebrick;
			this.exit_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit_button.ForeColor = System.Drawing.SystemColors.ControlText;
			this.exit_button.Location = new System.Drawing.Point(475, 359);
			this.exit_button.Name = "exit_button";
			this.exit_button.Size = new System.Drawing.Size(90, 36);
			this.exit_button.TabIndex = 3;
			this.exit_button.Text = "E&XIT";
			this.exit_button.UseVisualStyleBackColor = false;
			this.exit_button.Click += new System.EventHandler(this.Exit);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(577, 410);
			this.Controls.Add(this.exit_button);
			this.Controls.Add(this.totalCalories_label);
			this.Controls.Add(this.carbs_groupBox);
			this.Controls.Add(this.fat_groupBox);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.Info;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Form1";
			this.Text = "Fats & Carbs Calorie Counter [Activity 8]";
			this.fat_groupBox.ResumeLayout(false);
			this.fat_groupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fat_pictureBox)).EndInit();
			this.carbs_groupBox.ResumeLayout(false);
			this.carbs_groupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.carbs_pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox fat_groupBox;
		private System.Windows.Forms.GroupBox carbs_groupBox;
		private System.Windows.Forms.PictureBox fat_pictureBox;
		private System.Windows.Forms.PictureBox carbs_pictureBox;
		private System.Windows.Forms.Label fatCaloriesOutput_label;
		private System.Windows.Forms.TextBox fatGramsInput_textBox;
		private System.Windows.Forms.Label enterFat_label;
		private System.Windows.Forms.Label carbCaloriesOutput_label;
		private System.Windows.Forms.TextBox carbGramsInput_textBox;
		private System.Windows.Forms.Label enterCarbs_label;
		private System.Windows.Forms.Label totalCalories_label;
		private System.Windows.Forms.Button exit_button;
	}
}

