namespace Milestone_3
{
	partial class InventorySystem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventorySystem));
			this.newItem_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.search_textBox = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.inventory_listBox = new System.Windows.Forms.ListBox();
			this.restockQty_textBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.restock_button = new System.Windows.Forms.Button();
			this.displayAll_button = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// newItem_button
			// 
			this.newItem_button.Location = new System.Drawing.Point(156, 92);
			this.newItem_button.Margin = new System.Windows.Forms.Padding(4);
			this.newItem_button.Name = "newItem_button";
			this.newItem_button.Size = new System.Drawing.Size(123, 32);
			this.newItem_button.TabIndex = 0;
			this.newItem_button.Text = "Add &New Item";
			this.newItem_button.UseVisualStyleBackColor = true;
			this.newItem_button.Click += new System.EventHandler(this.AddItem);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(154, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(462, 51);
			this.label1.TabIndex = 1;
			this.label1.Text = "INVENTORY SYSTEM";
			// 
			// search_textBox
			// 
			this.search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_textBox.Location = new System.Drawing.Point(74, 21);
			this.search_textBox.Name = "search_textBox";
			this.search_textBox.Size = new System.Drawing.Size(214, 22);
			this.search_textBox.TabIndex = 4;
			this.search_textBox.TextChanged += new System.EventHandler(this.Search);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(609, 482);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(123, 32);
			this.button5.TabIndex = 16;
			this.button5.Text = "E&xit";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Exit);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(25, 395);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 32);
			this.button2.TabIndex = 17;
			this.button2.Text = "&View";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ViewItem);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(133, 395);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 32);
			this.button3.TabIndex = 18;
			this.button3.Text = "&Edit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.EditItem);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(241, 395);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 32);
			this.button4.TabIndex = 19;
			this.button4.Text = "&Delete";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.DeleteItem);
			// 
			// inventory_listBox
			// 
			this.inventory_listBox.FormattingEnabled = true;
			this.inventory_listBox.ItemHeight = 16;
			this.inventory_listBox.Location = new System.Drawing.Point(25, 142);
			this.inventory_listBox.Name = "inventory_listBox";
			this.inventory_listBox.Size = new System.Drawing.Size(707, 228);
			this.inventory_listBox.TabIndex = 20;
			// 
			// restockQty_textBox
			// 
			this.restockQty_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.restockQty_textBox.Location = new System.Drawing.Point(53, 26);
			this.restockQty_textBox.Name = "restockQty_textBox";
			this.restockQty_textBox.Size = new System.Drawing.Size(94, 22);
			this.restockQty_textBox.TabIndex = 21;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.restock_button);
			this.groupBox1.Controls.Add(this.restockQty_textBox);
			this.groupBox1.Location = new System.Drawing.Point(25, 444);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(267, 70);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			// 
			// restock_button
			// 
			this.restock_button.Location = new System.Drawing.Point(154, 21);
			this.restock_button.Margin = new System.Windows.Forms.Padding(4);
			this.restock_button.Name = "restock_button";
			this.restock_button.Size = new System.Drawing.Size(100, 32);
			this.restock_button.TabIndex = 23;
			this.restock_button.Text = "&Restock";
			this.restock_button.UseVisualStyleBackColor = true;
			this.restock_button.Click += new System.EventHandler(this.RestockItem);
			// 
			// displayAll_button
			// 
			this.displayAll_button.Location = new System.Drawing.Point(25, 92);
			this.displayAll_button.Margin = new System.Windows.Forms.Padding(4);
			this.displayAll_button.Name = "displayAll_button";
			this.displayAll_button.Size = new System.Drawing.Size(123, 32);
			this.displayAll_button.TabIndex = 23;
			this.displayAll_button.Text = "&Display All Items";
			this.displayAll_button.UseVisualStyleBackColor = true;
			this.displayAll_button.Click += new System.EventHandler(this.DisplayAllItems);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 16);
			this.label2.TabIndex = 24;
			this.label2.Text = "Search:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.search_textBox);
			this.groupBox2.Location = new System.Drawing.Point(425, 76);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(307, 60);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 16);
			this.label3.TabIndex = 24;
			this.label3.Text = "Qty:";
			// 
			// InventorySystem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 538);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.displayAll_button);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.inventory_listBox);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.newItem_button);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "InventorySystem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CST-150 Milestone Project";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button newItem_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox search_textBox;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox restockQty_textBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button restock_button;
		public System.Windows.Forms.ListBox inventory_listBox;
		private System.Windows.Forms.Button displayAll_button;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
	}
}

