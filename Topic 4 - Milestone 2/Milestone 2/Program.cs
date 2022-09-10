// Jamie Lewis
// CST-150
// 9/9/22
// The modifications on this auto-generated file are my own work.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_2
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new InventorySystem());

			// We're going to print to the console for this test, so let's make it easy to find the beginning of the following outputs
			Console.WriteLine("\n\n###############################\n" +
							  "###                         ###\n" +
							  "###   INVENTORY ITEM TEST   ###\n" +
							  "###                         ###\n" +
							  "###############################");

			// test the constructor
			// note: in practice, there will be an InventorySystem class method which automatically increments the itemNumber that gets passed to a constructor call.
			InventoryItem item1 = new InventoryItem(001, "test item description", 7, 2.50, 9.99);

			// test the ToString output of the new InventoryItem instance
			Console.WriteLine(item1.ToString());

			// modify all of the attributes of item1 to test the setter methods
			item1.SetItemDescription("modified item");
			item1.SetSoldQuantity(3);
			item1.SetStockQuantity(20);
			item1.SetCost(3.75);
			item1.SetPrice(12.49);

			// test the getter methods - should return the values that were just set

			Console.WriteLine("item # - " + item1.GetItemNumber());
			Console.WriteLine("item description - " + item1.GetItemDescription());
			Console.WriteLine("stock qty - " + item1.GetStockQuantity());
			Console.WriteLine("sold qty - " + item1.GetSoldQuantity());
			Console.WriteLine("cost - " + item1.GetCost());
			Console.WriteLine("price - " + item1.GetPrice());

			// finally, run the ToString Method again after all modifications
			Console.WriteLine(item1.ToString());
		}
	}
}
