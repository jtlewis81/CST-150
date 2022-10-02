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
			this.exit_button = new System.Windows.Forms.Button();
			this.view_button = new System.Windows.Forms.Button();
			this.edit_button = new System.Windows.Forms.Button();
			this.delete_button = new System.Windows.Forms.Button();
			this.inventory_listBox = new System.Windows.Forms.ListBox();
			this.restockQty_textBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.restock_button = new System.Windows.Forms.Button();
			this.displayAll_button = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.load_button = new System.Windows.Forms.Button();
			this.save_button = new System.Windows.Forms.Button();
			this.NewSavedInventory = new System.Windows.Forms.SaveFileDialog();
			this.LoadSavedInventory = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// newItem_button
			// 
			this.newItem_button.Location = new System.Drawing.Point(25, 396);
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
			this.label1.Location = new System.Drawing.Point(138, 9);
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
			// exit_button
			// 
			this.exit_button.Location = new System.Drawing.Point(609, 482);
			this.exit_button.Margin = new System.Windows.Forms.Padding(4);
			this.exit_button.Name = "exit_button";
			this.exit_button.Size = new System.Drawing.Size(123, 32);
			this.exit_button.TabIndex = 16;
			this.exit_button.Text = "E&xit";
			this.exit_button.UseVisualStyleBackColor = true;
			this.exit_button.Click += new System.EventHandler(this.Exit);
			// 
			// view_button
			// 
			this.view_button.Location = new System.Drawing.Point(156, 396);
			this.view_button.Margin = new System.Windows.Forms.Padding(4);
			this.view_button.Name = "view_button";
			this.view_button.Size = new System.Drawing.Size(100, 32);
			this.view_button.TabIndex = 17;
			this.view_button.Text = "&View";
			this.view_button.UseVisualStyleBackColor = true;
			this.view_button.Click += new System.EventHandler(this.ViewItem);
			// 
			// edit_button
			// 
			this.edit_button.Location = new System.Drawing.Point(264, 396);
			this.edit_button.Margin = new System.Windows.Forms.Padding(4);
			this.edit_button.Name = "edit_button";
			this.edit_button.Size = new System.Drawing.Size(100, 32);
			this.edit_button.TabIndex = 18;
			this.edit_button.Text = "&Edit";
			this.edit_button.UseVisualStyleBackColor = true;
			this.edit_button.Click += new System.EventHandler(this.EditItem);
			// 
			// delete_button
			// 
			this.delete_button.Location = new System.Drawing.Point(372, 396);
			this.delete_button.Margin = new System.Windows.Forms.Padding(4);
			this.delete_button.Name = "delete_button";
			this.delete_button.Size = new System.Drawing.Size(100, 32);
			this.delete_button.TabIndex = 19;
			this.delete_button.Text = "&Delete";
			this.delete_button.UseVisualStyleBackColor = true;
			this.delete_button.Click += new System.EventHandler(this.DeleteItem);
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 16);
			this.label3.TabIndex = 24;
			this.label3.Text = "Qty:";
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
			this.displayAll_button.Location = new System.Drawing.Point(287, 92);
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
			// load_button
			// 
			this.load_button.Location = new System.Drawing.Point(25, 92);
			this.load_button.Margin = new System.Windows.Forms.Padding(4);
			this.load_button.Name = "load_button";
			this.load_button.Size = new System.Drawing.Size(123, 32);
			this.load_button.TabIndex = 26;
			this.load_button.Text = "&Load Inventory";
			this.load_button.UseVisualStyleBackColor = true;
			this.load_button.Click += new System.EventHandler(this.LoadInventory);
			// 
			// save_button
			// 
			this.save_button.Location = new System.Drawing.Point(156, 92);
			this.save_button.Margin = new System.Windows.Forms.Padding(4);
			this.save_button.Name = "save_button";
			this.save_button.Size = new System.Drawing.Size(123, 32);
			this.save_button.TabIndex = 27;
			this.save_button.Text = "&Save Inventory";
			this.save_button.UseVisualStyleBackColor = true;
			this.save_button.Click += new System.EventHandler(this.SaveInventory);
			// 
			// LoadSavedInventory
			// 
			this.LoadSavedInventory.FileName = "openFileDialog";
			// 
			// InventorySystem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 538);
			this.Controls.Add(this.save_button);
			this.Controls.Add(this.load_button);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.displayAll_button);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.inventory_listBox);
			this.Controls.Add(this.delete_button);
			this.Controls.Add(this.edit_button);
			this.Controls.Add(this.view_button);
			this.Controls.Add(this.exit_button);
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
		private System.Windows.Forms.Button exit_button;
		private System.Windows.Forms.Button view_button;
		private System.Windows.Forms.Button edit_button;
		private System.Windows.Forms.Button delete_button;
		private System.Windows.Forms.TextBox restockQty_textBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button restock_button;
		public System.Windows.Forms.ListBox inventory_listBox;
		private System.Windows.Forms.Button displayAll_button;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button load_button;
		private System.Windows.Forms.Button save_button;
		private System.Windows.Forms.SaveFileDialog NewSavedInventory;
		private System.Windows.Forms.OpenFileDialog LoadSavedInventory;
	}
}

