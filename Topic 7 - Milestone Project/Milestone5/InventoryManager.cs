// Jamie Lewis
// CST-150
// 10/1/22
// This is my own work.

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

		// returns an item by index
		// added 10/1/22
		public InventoryItem GetItem(int index)
		{
			return items[index];
		}

		// displays all items
		public List<InventoryItem> GetAllItems()
		{
			return items;
		}


		// add an item to the list
		public void AddItem(InventoryItem item)
		{
			items.Add(item);
		}

		// remove an item from the list
		public void RemoveItem(int index)
		{
			items.Remove(items[index]);
		}

		// add a quantity to the stock amount of a particular item
		public void RestockItem(InventoryItem item, int qty)
		{
			int currentStock = item.GetStockQuantity();
			int newStock = currentStock + qty;
			item.SetStockQuantity(newStock);
		}

		//
		// Search methods return a list of inventory items which contain attributes matching the searched keywords. 
		//
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

		// overriding tostring method <<< DEPRECATED >>>
		/*
		public override string ToString()
		{
			string output = "";
			foreach (InventoryItem item in items)
			{
				output += "\n" + item.ToString();
			}

			return output;
		}
		*/
	}
}
