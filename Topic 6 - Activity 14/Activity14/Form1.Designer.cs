
namespace Activity14
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
			this.order_button = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tint_checkBox = new System.Windows.Forms.CheckBox();
			this.premiumMedia_checkBox = new System.Windows.Forms.CheckBox();
			this.sunroof_checkBox = new System.Windows.Forms.CheckBox();
			this.nav_checkBox = new System.Windows.Forms.CheckBox();
			this.powerPassSeat_checkBox = new System.Windows.Forms.CheckBox();
			this.powerDriverSeat_checkBox = new System.Windows.Forms.CheckBox();
			this.heatedSeats_checkBox = new System.Windows.Forms.CheckBox();
			this.leather_checkBox = new System.Windows.Forms.CheckBox();
			this.bodyStyle_listBox = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.powertrain_groupBox = new System.Windows.Forms.GroupBox();
			this.transmission_groupBox = new System.Windows.Forms.GroupBox();
			this.autoTrans_radioButton = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.engine_groupBox = new System.Windows.Forms.GroupBox();
			this.bigV8_radioButton = new System.Windows.Forms.RadioButton();
			this.smallV8_radioButton = new System.Windows.Forms.RadioButton();
			this.turboV6_radioButton = new System.Windows.Forms.RadioButton();
			this.v6_radioButton = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.color_listBox = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.basePrice_label = new System.Windows.Forms.Label();
			this.totalPrice_label = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.powertrain_groupBox.SuspendLayout();
			this.transmission_groupBox.SuspendLayout();
			this.engine_groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(105, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(384, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Custom Vehicle Order Form";
			// 
			// order_button
			// 
			this.order_button.Location = new System.Drawing.Point(422, 544);
			this.order_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.order_button.Name = "order_button";
			this.order_button.Size = new System.Drawing.Size(148, 33);
			this.order_button.TabIndex = 1;
			this.order_button.Text = "Place &Order";
			this.order_button.UseVisualStyleBackColor = true;
			this.order_button.Click += new System.EventHandler(this.PlaceOrder);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(422, 593);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(148, 33);
			this.button2.TabIndex = 2;
			this.button2.Text = "Cancel (E&xit)";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Exit);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tint_checkBox);
			this.groupBox1.Controls.Add(this.premiumMedia_checkBox);
			this.groupBox1.Controls.Add(this.sunroof_checkBox);
			this.groupBox1.Controls.Add(this.nav_checkBox);
			this.groupBox1.Controls.Add(this.powerPassSeat_checkBox);
			this.groupBox1.Controls.Add(this.powerDriverSeat_checkBox);
			this.groupBox1.Controls.Add(this.heatedSeats_checkBox);
			this.groupBox1.Controls.Add(this.leather_checkBox);
			this.groupBox1.Location = new System.Drawing.Point(317, 88);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(253, 254);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Choose Options";
			// 
			// tint_checkBox
			// 
			this.tint_checkBox.AutoSize = true;
			this.tint_checkBox.Location = new System.Drawing.Point(20, 221);
			this.tint_checkBox.Name = "tint_checkBox";
			this.tint_checkBox.Size = new System.Drawing.Size(152, 22);
			this.tint_checkBox.TabIndex = 7;
			this.tint_checkBox.Text = "Tinted Windows";
			this.tint_checkBox.UseVisualStyleBackColor = true;
			this.tint_checkBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// premiumMedia_checkBox
			// 
			this.premiumMedia_checkBox.AutoSize = true;
			this.premiumMedia_checkBox.Location = new System.Drawing.Point(20, 193);
			this.premiumMedia_checkBox.Name = "premiumMedia_checkBox";
			this.premiumMedia_checkBox.Size = new System.Drawing.Size(211, 22);
			this.premiumMedia_checkBox.TabIndex = 6;
			this.premiumMedia_checkBox.Text = "Premium Media System";
			this.premiumMedia_checkBox.UseVisualStyleBackColor = true;
			this.premiumMedia_checkBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// sunroof_checkBox
			// 
			this.sunroof_checkBox.AutoSize = true;
			this.sunroof_checkBox.Location = new System.Drawing.Point(20, 165);
			this.sunroof_checkBox.Name = "sunroof_checkBox";
			this.sunroof_checkBox.Size = new System.Drawing.Size(145, 22);
			this.sunroof_checkBox.TabIndex = 5;
			this.sunroof_checkBox.Text = "Power Sunroof";
			this.sunroof_checkBox.UseVisualStyleBackColor = true;
			this.sunroof_checkBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// nav_checkBox
			// 
			this.nav_checkBox.AutoSize = true;
			this.nav_checkBox.Location = new System.Drawing.Point(20, 137);
			this.nav_checkBox.Name = "nav_checkBox";
			this.nav_checkBox.Size = new System.Drawing.Size(112, 22);
			this.nav_checkBox.TabIndex = 4;
			this.nav_checkBox.Text = "Navigation";
			this.nav_checkBox.UseVisualStyleBackColor = true;
			this.nav_checkBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// powerPassSeat_checkBox
			// 
			this.powerPassSeat_checkBox.AutoSize = true;
			this.powerPassSeat_checkBox.Location = new System.Drawing.Point(20, 109);
			this.powerPassSeat_checkBox.Name = "powerPassSeat_checkBox";
			this.powerPassSeat_checkBox.Size = new System.Drawing.Size(209, 22);
			this.powerPassSeat_checkBox.TabIndex = 3;
			this.powerPassSeat_checkBox.Text = "Power Passenger Seat";
			this.powerPassSeat_checkBox.UseVisualStyleBackColor = true;
			this.powerPassSeat_checkBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// powerDriverSeat_checkBox
			// 
			this.powerDriverSeat_checkBox.AutoSize = true;
			this.powerDriverSeat_checkBox.Location = new System.Drawing.Point(20, 81);
			this.powerDriverSeat_checkBox.Name = "powerDriverSeat_checkBox";
			this.powerDriverSeat_checkBox.Size = new System.Drawing.Size(172, 22);
			this.powerDriverSeat_checkBox.TabIndex = 2;
			this.powerDriverSeat_checkBox.Text = "Power Driver Seat";
			this.powerDriverSeat_checkBox.UseVisualStyleBackColor = true;
			this.powerDriverSeat_checkBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// heatedSeats_checkBox
			// 
			this.heatedSeats_checkBox.AutoSize = true;
			this.heatedSeats_checkBox.Location = new System.Drawing.Point(20, 53);
			this.heatedSeats_checkBox.Name = "heatedSeats_checkBox";
			this.heatedSeats_checkBox.Size = new System.Drawing.Size(135, 22);
			this.heatedSeats_checkBox.TabIndex = 1;
			this.heatedSeats_checkBox.Text = "Heated Seats";
			this.heatedSeats_checkBox.UseVisualStyleBackColor = true;
			this.heatedSeats_checkBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// leather_checkBox
			// 
			this.leather_checkBox.AutoSize = true;
			this.leather_checkBox.Location = new System.Drawing.Point(20, 25);
			this.leather_checkBox.Name = "leather_checkBox";
			this.leather_checkBox.Size = new System.Drawing.Size(227, 22);
			this.leather_checkBox.TabIndex = 0;
			this.leather_checkBox.Text = "Leather Interior Package";
			this.leather_checkBox.UseVisualStyleBackColor = true;
			this.leather_checkBox.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// bodyStyle_listBox
			// 
			this.bodyStyle_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bodyStyle_listBox.FormattingEnabled = true;
			this.bodyStyle_listBox.ItemHeight = 18;
			this.bodyStyle_listBox.Items.AddRange(new object[] {
            "FWD Compact",
            "AWD Wagon",
            "AWD Sedan",
            "RWD Sports Coupe",
            "4WD Truck",
            "4WD SUV"});
			this.bodyStyle_listBox.Location = new System.Drawing.Point(26, 107);
			this.bodyStyle_listBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.bodyStyle_listBox.Name = "bodyStyle_listBox";
			this.bodyStyle_listBox.Size = new System.Drawing.Size(253, 112);
			this.bodyStyle_listBox.TabIndex = 4;
			this.bodyStyle_listBox.SelectedIndexChanged += new System.EventHandler(this.SetBasePrice);
			this.bodyStyle_listBox.SelectedValueChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(26, 88);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "Choose Body Style";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(18, 20);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(153, 22);
			this.radioButton1.TabIndex = 6;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "2.4L I4 [200 HP]";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// powertrain_groupBox
			// 
			this.powertrain_groupBox.Controls.Add(this.transmission_groupBox);
			this.powertrain_groupBox.Controls.Add(this.engine_groupBox);
			this.powertrain_groupBox.Location = new System.Drawing.Point(26, 237);
			this.powertrain_groupBox.Name = "powertrain_groupBox";
			this.powertrain_groupBox.Size = new System.Drawing.Size(253, 285);
			this.powertrain_groupBox.TabIndex = 7;
			this.powertrain_groupBox.TabStop = false;
			this.powertrain_groupBox.Text = "Choose Powertrain";
			// 
			// transmission_groupBox
			// 
			this.transmission_groupBox.Controls.Add(this.autoTrans_radioButton);
			this.transmission_groupBox.Controls.Add(this.radioButton4);
			this.transmission_groupBox.Location = new System.Drawing.Point(6, 195);
			this.transmission_groupBox.Name = "transmission_groupBox";
			this.transmission_groupBox.Size = new System.Drawing.Size(241, 84);
			this.transmission_groupBox.TabIndex = 1;
			this.transmission_groupBox.TabStop = false;
			this.transmission_groupBox.Text = "Transmission";
			// 
			// autoTrans_radioButton
			// 
			this.autoTrans_radioButton.AutoSize = true;
			this.autoTrans_radioButton.Location = new System.Drawing.Point(18, 53);
			this.autoTrans_radioButton.Name = "autoTrans_radioButton";
			this.autoTrans_radioButton.Size = new System.Drawing.Size(178, 22);
			this.autoTrans_radioButton.TabIndex = 10;
			this.autoTrans_radioButton.Text = "5-Speed Automatic";
			this.autoTrans_radioButton.UseVisualStyleBackColor = true;
			this.autoTrans_radioButton.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Checked = true;
			this.radioButton4.Location = new System.Drawing.Point(18, 25);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(153, 22);
			this.radioButton4.TabIndex = 9;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "6-Speed Manual";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// engine_groupBox
			// 
			this.engine_groupBox.Controls.Add(this.bigV8_radioButton);
			this.engine_groupBox.Controls.Add(this.smallV8_radioButton);
			this.engine_groupBox.Controls.Add(this.turboV6_radioButton);
			this.engine_groupBox.Controls.Add(this.v6_radioButton);
			this.engine_groupBox.Controls.Add(this.radioButton1);
			this.engine_groupBox.Location = new System.Drawing.Point(6, 20);
			this.engine_groupBox.Name = "engine_groupBox";
			this.engine_groupBox.Size = new System.Drawing.Size(241, 169);
			this.engine_groupBox.TabIndex = 0;
			this.engine_groupBox.TabStop = false;
			this.engine_groupBox.Text = "Engine";
			// 
			// bigV8_radioButton
			// 
			this.bigV8_radioButton.AutoSize = true;
			this.bigV8_radioButton.Location = new System.Drawing.Point(18, 132);
			this.bigV8_radioButton.Name = "bigV8_radioButton";
			this.bigV8_radioButton.Size = new System.Drawing.Size(159, 22);
			this.bigV8_radioButton.TabIndex = 10;
			this.bigV8_radioButton.Text = "6.2L V8 [450 HP]";
			this.bigV8_radioButton.UseVisualStyleBackColor = true;
			this.bigV8_radioButton.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// smallV8_radioButton
			// 
			this.smallV8_radioButton.AutoSize = true;
			this.smallV8_radioButton.Location = new System.Drawing.Point(18, 104);
			this.smallV8_radioButton.Name = "smallV8_radioButton";
			this.smallV8_radioButton.Size = new System.Drawing.Size(159, 22);
			this.smallV8_radioButton.TabIndex = 9;
			this.smallV8_radioButton.Text = "5.0L V8 [380 HP]";
			this.smallV8_radioButton.UseVisualStyleBackColor = true;
			this.smallV8_radioButton.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// turboV6_radioButton
			// 
			this.turboV6_radioButton.AutoSize = true;
			this.turboV6_radioButton.Location = new System.Drawing.Point(18, 76);
			this.turboV6_radioButton.Name = "turboV6_radioButton";
			this.turboV6_radioButton.Size = new System.Drawing.Size(210, 22);
			this.turboV6_radioButton.TabIndex = 8;
			this.turboV6_radioButton.Text = "3.0L Turbo V6 [330 HP]";
			this.turboV6_radioButton.UseVisualStyleBackColor = true;
			this.turboV6_radioButton.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// v6_radioButton
			// 
			this.v6_radioButton.AutoSize = true;
			this.v6_radioButton.Location = new System.Drawing.Point(18, 48);
			this.v6_radioButton.Name = "v6_radioButton";
			this.v6_radioButton.Size = new System.Drawing.Size(159, 22);
			this.v6_radioButton.TabIndex = 7;
			this.v6_radioButton.Text = "3.0L V6 [250 HP]";
			this.v6_radioButton.UseVisualStyleBackColor = true;
			this.v6_radioButton.CheckedChanged += new System.EventHandler(this.UpdatePrice);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(323, 353);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 18);
			this.label3.TabIndex = 9;
			this.label3.Text = "Choose Color";
			// 
			// color_listBox
			// 
			this.color_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.color_listBox.FormattingEnabled = true;
			this.color_listBox.ItemHeight = 18;
			this.color_listBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Gray",
            "Orange",
            "Purple",
            "Red",
            "Teal",
            "White"});
			this.color_listBox.Location = new System.Drawing.Point(317, 374);
			this.color_listBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.color_listBox.Name = "color_listBox";
			this.color_listBox.Size = new System.Drawing.Size(253, 148);
			this.color_listBox.Sorted = true;
			this.color_listBox.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 559);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 18);
			this.label4.TabIndex = 10;
			this.label4.Text = "Base Price:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 600);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 18);
			this.label5.TabIndex = 11;
			this.label5.Text = "Total Price:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// basePrice_label
			// 
			this.basePrice_label.AutoSize = true;
			this.basePrice_label.Location = new System.Drawing.Point(135, 559);
			this.basePrice_label.Name = "basePrice_label";
			this.basePrice_label.Size = new System.Drawing.Size(28, 18);
			this.basePrice_label.TabIndex = 12;
			this.basePrice_label.Text = "$0";
			this.basePrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// totalPrice_label
			// 
			this.totalPrice_label.AutoSize = true;
			this.totalPrice_label.Location = new System.Drawing.Point(135, 600);
			this.totalPrice_label.Name = "totalPrice_label";
			this.totalPrice_label.Size = new System.Drawing.Size(28, 18);
			this.totalPrice_label.TabIndex = 13;
			this.totalPrice_label.Text = "$0";
			this.totalPrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(604, 638);
			this.Controls.Add(this.totalPrice_label);
			this.Controls.Add(this.basePrice_label);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.color_listBox);
			this.Controls.Add(this.powertrain_groupBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bodyStyle_listBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.order_button);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Form1";
			this.Text = "Activity 14";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.powertrain_groupBox.ResumeLayout(false);
			this.transmission_groupBox.ResumeLayout(false);
			this.transmission_groupBox.PerformLayout();
			this.engine_groupBox.ResumeLayout(false);
			this.engine_groupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button order_button;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox tint_checkBox;
		private System.Windows.Forms.CheckBox premiumMedia_checkBox;
		private System.Windows.Forms.CheckBox sunroof_checkBox;
		private System.Windows.Forms.CheckBox nav_checkBox;
		private System.Windows.Forms.CheckBox powerPassSeat_checkBox;
		private System.Windows.Forms.CheckBox powerDriverSeat_checkBox;
		private System.Windows.Forms.CheckBox heatedSeats_checkBox;
		private System.Windows.Forms.CheckBox leather_checkBox;
		private System.Windows.Forms.ListBox bodyStyle_listBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox powertrain_groupBox;
		private System.Windows.Forms.GroupBox transmission_groupBox;
		private System.Windows.Forms.RadioButton autoTrans_radioButton;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.GroupBox engine_groupBox;
		private System.Windows.Forms.RadioButton turboV6_radioButton;
		private System.Windows.Forms.RadioButton v6_radioButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox color_listBox;
		private System.Windows.Forms.RadioButton smallV8_radioButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton bigV8_radioButton;
		private System.Windows.Forms.Label basePrice_label;
		private System.Windows.Forms.Label totalPrice_label;
	}
}

