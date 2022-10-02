

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
	public partial class EditItem : Form
	{
		InventoryItem item;

		public EditItem(InventoryItem item)
		{
			InitializeComponent();
			this.item = item;
			// populate labels
			itemNumber_label.Text = item.GetItemNumber().ToString();
			description_textBox.Text = item.GetItemDescription();
			stockQty_textBox.Text = item.GetStockQuantity().ToString();
			soldQty_textBox.Text = item.GetSoldQuantity().ToString();
			cost_textBox.Text = item.GetCost().ToString($"F2");
			price_textBox.Text = item.GetPrice().ToString($"F2");
		}


		private void UpdateItem(object sender, EventArgs e)
		{
			try
			{
				string description = description_textBox.Text;

				// validate user input for numeric values
				if (int.TryParse(stockQty_textBox.Text, out int stock) && int.TryParse(soldQty_textBox.Text, out int sold) && double.TryParse(cost_textBox.Text, out double cost) && double.TryParse(price_textBox.Text, out double price))
				{
					item.SetItemDescription(description);
					item.SetStockQuantity(stock);
					item.SetSoldQuantity(sold);
					item.SetCost(cost);
					item.SetPrice(price); 
				}

				this.Close();
			}
			catch (Exception exc)
			{
				Console.WriteLine("ERROR: " + exc);
				MessageBox.Show("Please enter all information correctly. Use a whole number for stock and sold quantities and decimal numbers for cost and price.");
			}
		}

		// close the EditItem form
		private void Close(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
