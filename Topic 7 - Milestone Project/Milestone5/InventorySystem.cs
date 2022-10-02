// Jamie Lewis
// CST-150
// 10/2/22
// This is my own work.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_3
{

	public partial class InventorySystem : Form
	{
		private static InventoryManager inventory;
		public static int LastItemNumber = 0;

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

			foreach (InventoryItem item in Inventory.GetAllItems())
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

		// remove an item from the inventory and update the listBox items
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

		// load an inventory from a saved file
		private void LoadInventory(object sender, EventArgs e)
		{
			// prompt the user to save their work if there is an existing inventory.
			if (Inventory.GetAllItems().Count > 0)
			{
				MessageBox.Show("Do you need to save the current Inventory?");
			}

			// clear the autofilled filename on the load file dialog
			LoadSavedInventory.FileName = "";

			if (LoadSavedInventory.ShowDialog() == DialogResult.OK)
			{
				// empty the current inventory
				Inventory.GetAllItems().Clear();
				LastItemNumber = 0;

				// read the selected file
				StreamReader input;
				input = File.OpenText(LoadSavedInventory.FileName);

				// read each line of the file and try to parse it to an inventory item
				while (!input.EndOfStream)
				{
					string itemData = input.ReadLine();

					string[] itemProperties = itemData.Split('|');
					try
					{
						Inventory.AddItem(new InventoryItem(int.Parse(itemProperties[0]), itemProperties[1], int.Parse(itemProperties[2]), double.Parse(itemProperties[4]), double.Parse(itemProperties[5]), int.Parse(itemProperties[3])));
						LastItemNumber++;
					}
					catch
					{
						MessageBox.Show("Invalid Data.");
						break; // stops the error message from showing up for every line in the file!
					}
				}

				// close the file
				input.Close();
				
				// update the listBox
				DisplayAllItems();
			}
			else
			{
				MessageBox.Show($"Load cancelled.");
			}
		}

		// save inventroy data to a file
		private void SaveInventory(object sender, EventArgs e)
		{
			// apply a filter for type of file to save
			NewSavedInventory.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

			if (NewSavedInventory.ShowDialog() == DialogResult.OK)
			{
				// create a file to write to
				StreamWriter output;
				output = File.CreateText(NewSavedInventory.FileName);
				
				// write the data to the file
				for (int i = 0; i < Inventory.GetAllItems().Count; i++)
				{
					InventoryItem item = Inventory.GetItem(i);
					output.WriteLine($"{item.GetItemNumber()}|{item.GetItemDescription()}|{item.GetStockQuantity()}|{item.GetSoldQuantity()}|{item.GetCost()}|{item.GetPrice()}");
				}

				// close the file
				output.Close();
			}
			else
			{
				MessageBox.Show($"Save cancelled.");
			}
		}
	}
}
