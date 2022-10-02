

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
		
		int lastItemNumber = 0;
		
		public NewItem()
		{
			InitializeComponent();
			itemNumber_label.Text = (lastItemNumber + 1).ToString();
		}

		// add item to InventorySystem.Inventory
		private void AddItem(object sender, EventArgs e)
		{
			try
			{
				int itemNumber = int.Parse(itemNumber_label.Text);
				string description = description_textBox.Text;
				// validate user input
				if (int.TryParse(initialQty_textBox.Text, out int stock) && double.TryParse(cost_textBox.Text, out double cost) && double.TryParse(price_textBox.Text, out double price))
				{
					InventoryItem newItem = new InventoryItem(itemNumber, description, stock, cost, price, 0);
					InventorySystem.Inventory.AddItem(newItem);
					lastItemNumber++;
				}				

				this.Close();
			}
			catch (Exception exc)
			{
				Console.WriteLine("ERROR: " + exc);
				MessageBox.Show("Please enter all information correctly. Use a whole number for stock quantity and decimal numbers for cost and price.");
			}
			
		}

		// close the NewItem form
		private void Close(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
