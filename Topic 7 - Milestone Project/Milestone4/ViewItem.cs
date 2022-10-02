// Jamie Lewis
// CST-150
// 10/1/22
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
	public partial class ViewItem : Form
	{
		public ViewItem(InventoryItem item)
		{
			InitializeComponent();

			// populate labels
			itemNumber_label.Text = item.GetItemNumber().ToString();
			description_label.Text = item.GetItemDescription();
			stockQty_label.Text = item.GetStockQuantity().ToString();
			soldQty_label.Text = item.GetSoldQuantity().ToString();
			cost_label.Text = item.GetCost().ToString($"F2");
			price_label.Text = item.GetPrice().ToString($"F2");
		}

		// close the ViewItem form
		private void Close(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
