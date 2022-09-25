// Jamie Lewis
// CST-150
// 9/25/22
// The modifications on this auto-generated file are my own work.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_3
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			int lastItemNumber = 0;
			InventoryManager inventoryManager = new InventoryManager();

			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new InventorySystem());

			// We're going to print to the console for this test, so let's make it easy to find the beginning of the following outputs
			Console.WriteLine("\n\n##################################\n" +
							  "###                            ###\n" +
							  "###   INVENTORY MANAGER TEST   ###\n" +
							  "###                            ###\n" +
							  "##################################");

			// create some items
			InventoryItem item1 = new InventoryItem(lastItemNumber += 1, "test item 1 description", 10, 1, 1.99);
			InventoryItem item2 = new InventoryItem(lastItemNumber += 1, "test item 2 book", 20, 2, 2.99);
			InventoryItem item3 = new InventoryItem(lastItemNumber += 1, "test item 3 chair", 30, 3, 3.99);
			InventoryItem item4 = new InventoryItem(lastItemNumber += 1, "test item 4 table", 40, 4, 4.99);
			InventoryItem item5 = new InventoryItem(lastItemNumber += 1, "test item 5 desk", 50, 5, 5.99);
			InventoryItem item6 = new InventoryItem(lastItemNumber += 1, "test item 6 book 2", 60, 6, 6.99);

			// test AddItem method
			inventoryManager.AddItem(item1);
			inventoryManager.AddItem(item2);
			inventoryManager.AddItem(item3);
			inventoryManager.AddItem(item4);
			inventoryManager.AddItem(item5);
			inventoryManager.AddItem(item6);

			// test DisplayItem method
			inventoryManager.DisplayItem(item3);

			// test RemoveItem
			inventoryManager.RemoveItem(item3);

			// test DisplayAllItems
			inventoryManager.DisplayAllItems();

			// test RestockItem
			inventoryManager.RestockItem(item1, 15);

			// test Search(string)
			List<InventoryItem> sample = inventoryManager.Search("book");
			inventoryManager.DisplayItem(sample[0]);
			inventoryManager.DisplayItem(sample[1]);

			// test Search(int)
			List<InventoryItem> sample2 = inventoryManager.Search(50);
			inventoryManager.DisplayItem(sample2[0]);

			// test Search(double)
			List<InventoryItem> sample3 = inventoryManager.Search(4.99);
			inventoryManager.DisplayItem(sample3[0]);

			// test ToString
			Console.WriteLine(inventoryManager.ToString());

		}
	}
}
