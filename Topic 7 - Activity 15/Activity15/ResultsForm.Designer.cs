
namespace Activity15
{
	partial class ResultsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
			this.luckyNumber_label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// luckyNumber_label
			// 
			this.luckyNumber_label.BackColor = System.Drawing.Color.Transparent;
			this.luckyNumber_label.CausesValidation = false;
			this.luckyNumber_label.ForeColor = System.Drawing.SystemColors.ControlText;
			this.luckyNumber_label.Location = new System.Drawing.Point(159, 159);
			this.luckyNumber_label.Margin = new System.Windows.Forms.Padding(150);
			this.luckyNumber_label.Name = "luckyNumber_label";
			this.luckyNumber_label.Size = new System.Drawing.Size(203, 108);
			this.luckyNumber_label.TabIndex = 0;
			this.luckyNumber_label.Text = "##";
			this.luckyNumber_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ResultsForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(526, 413);
			this.Controls.Add(this.luckyNumber_label);
			this.Font = new System.Drawing.Font("Poor Richard", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(26, 25, 26, 25);
			this.Name = "ResultsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Lucky Number Result";
			this.Load += new System.EventHandler(this.ResultsForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label luckyNumber_label;
	}
}