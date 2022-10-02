

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

	public partial class InventorySystem : Form
	{
		private static InventoryManager inventory;

		internal static InventoryManager Inventory { get => inventory; set => inventory = value; }

		public InventorySystem()
		{
			InitializeComponent();
			Inventory = new InventoryManager();
		}

		// opens the NewItem form
		private void AddItem(object sender, EventArgs e)
		{
			Form newItemForm = new NewItem();

			newItemForm.ShowDialog();

			// update the list of items
			DisplayAllItems();
		}

		// button event that calls the method below, taking no arguments
		private void DisplayAllItems(object sender, EventArgs e)
		{
			search_textBox.Text = "";
			DisplayAllItems();
		}

		// populate the listbox with all inventroy items
		private void DisplayAllItems()
		{
			inventory_listBox.Items.Clear();

			foreach (InventoryItem item in Inventory.DisplayAllItems())
			{
				inventory_listBox.Items.Add(item.ToString());
			}
		}


		// search method that populates the listBox on text changed
		private void Search(object sender, EventArgs e)
		{
			// clear the list
			inventory_listBox.Items.Clear();

			// search results variable
			List<InventoryItem> results = new List<InventoryItem>();
			
			// validate/filter search results:
			// if searchbox is blank, display all items
			// else if value parses as an int, search(int)
			// else if value parses as a double, search(double)
			// else search(string)
			// then, output results to the listBox
			if (search_textBox.Text == "")
			{
				DisplayAllItems();
				return;
			}
			else if (int.TryParse(search_textBox.Text, out int i))
			{
				results = Inventory.Search(i);
			}
			else if (double.TryParse(search_textBox.Text, out double d))
			{
				results = Inventory.Search(d);
			}
			else
			{
				results = Inventory.Search(search_textBox.Text);
			}

			// display the results list
			foreach (InventoryItem item in results)
			{
				inventory_listBox.Items.Add(item.ToString());
			}
		}

		// opens selected item in the ViewItem form
		private void ViewItem(object sender, EventArgs e)
		{
			int selectedIndex = inventory_listBox.SelectedIndex;
			if (selectedIndex >= 0)
			{

				Form viewItemForm = new ViewItem(Inventory.GetItem(inventory_listBox.SelectedIndex));

				viewItemForm.ShowDialog();
			}
			else
			{
				MessageBox.Show("Please select an item to view.");
			}
		}

		// opens the selected item in the EditItem form
		private void EditItem(object sender, EventArgs e)
		{
			int selectedIndex = inventory_listBox.SelectedIndex;
			if (selectedIndex >= 0)
			{
				Form editItemForm = new EditItem(Inventory.GetItem(selectedIndex));
				
				editItemForm.ShowDialog();

				// update the list of items
				DisplayAllItems();
			}
			else
			{
				MessageBox.Show("Please select an item to edit.");
			}

		}


		private void DeleteItem(object sender, EventArgs e)
		{
			int selectedIndex = inventory_listBox.SelectedIndex;
			if (selectedIndex >= 0)
			{
				Inventory.RemoveItem(inventory_listBox.SelectedIndex);

				// update the list of items
				DisplayAllItems();
			}
			else
			{
				MessageBox.Show("Please select an item to delete.");
			}
		}

		// restock the selected item with an input quantity
		private void RestockItem(object sender, EventArgs e)
		{
			int selectedIndex = inventory_listBox.SelectedIndex;
			if (selectedIndex >= 0)
			{
				if (int.TryParse(restockQty_textBox.Text, out int qty))
				{
					Inventory.RestockItem(Inventory.GetItem(selectedIndex), qty);
					restockQty_textBox.Text = "";
					// update the list of items
					DisplayAllItems();
				}
				else
				{
					MessageBox.Show("Invalid input on restock quantity. Please use a whole number.");
				}
			}
			else
			{
				MessageBox.Show("Please select an item to restock.");
			}
		}

		// quit the application
		private void Exit(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
