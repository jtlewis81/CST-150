using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
{
	class InventoryManager
	{
		List<InventoryItem> items;

		// constructor
		public InventoryManager()
		{
			items = new List<InventoryItem>();
		}

		// add an item to the list
		public void AddItem(InventoryItem item)
		{
			items.Add(item);
		}

		// remove an item from the list
		public void RemoveItem(InventoryItem item)
		{
			items.Remove(item);
		}

		// add a number of items to the stock amount of a perticular item
		public void RestockItem(InventoryItem item, int qty)
		{
			int currentStock = item.GetStockQuantity();
			int newStock = currentStock + qty;
			item.SetStockQuantity(newStock);
		}

		// The implementations of the display methods are a temporary solution for driver program testing.
		// The final forms of these methods will open different views in the inventory system.

		// display a single item
		public void DisplayItem(InventoryItem item)
		{
			Console.WriteLine(item.ToString());
		}

		// displays all items
		public void DisplayAllItems()
		{
			Console.WriteLine("The Inventory System contains:\n");
			foreach(InventoryItem item in items)
			{
				DisplayItem(item);
			}
		}

		// Search methods return a list of inventory items which contain attributes matching the searched keywords. 

		public List<InventoryItem> Search(string key)
		{
			List<InventoryItem> results = new List<InventoryItem>();

			foreach (InventoryItem item in this.items)
			{
				if (item.GetItemDescription().ToLower().Contains(key.ToLower()))
				{
					results.Add(item);
				}
			}

			return results;
		}

		public List<InventoryItem> Search(int num)
		{
			List<InventoryItem> results = new List<InventoryItem>();

			foreach (InventoryItem item in this.items)
			{
				if (item.GetItemNumber() == num || item.GetStockQuantity() == num || item.GetSoldQuantity() == num)
				{
					results.Add(item);
				}
			}

			return results;
		}

		public List<InventoryItem> Search(double num)
		{
			List<InventoryItem> results = new List<InventoryItem>();

			foreach (InventoryItem item in this.items)
			{
				if (item.GetCost() == num || item.GetPrice() == num)
				{
					results.Add(item);
				}
			}

			return results;
		}

		// overriding tostring method
		public override string ToString()
		{
			string output = "The Inventory System contains:\n";
			foreach (InventoryItem item in items)
			{
				output += "\n" + item.ToString();
			}

			return output;
		}
	}
}
