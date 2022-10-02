// Jamie Lewis
// CST-150
// 10/2/22
// This is my own work.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_3
{
	public partial class NewItem : Form
	{
		public NewItem()
		{
			InitializeComponent();
			itemNumber_label.Text = (InventorySystem.LastItemNumber + 1).ToString();
		}

		// add item to InventorySystem.Inventory
		private void AddItem(object sender, EventArgs e)
		{
			int itemNumber = int.Parse(itemNumber_label.Text);
			string description = description_textBox.Text;

			// validate user input
			if (description != "" && int.TryParse(initialQty_textBox.Text, out int stock) && double.TryParse(cost_textBox.Text, out double cost) && double.TryParse(price_textBox.Text, out double price))
			{
				InventoryItem newItem = new InventoryItem(itemNumber, description, stock, cost, price, 0);
				InventorySystem.Inventory.AddItem(newItem);
				InventorySystem.LastItemNumber++;
				this.Close();
			}
			else
			{
				MessageBox.Show("Please enter all information correctly. A new item must have a description, use a whole number for initial quantity, and use whole or decimal numbers for cost and price.");
			}
		}

		// close the NewItem form
		private void Close(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
