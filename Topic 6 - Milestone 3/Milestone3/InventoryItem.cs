// Jamie Lewis
// CST-150
// 9/9/22
// This is my own work.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
{
	public class InventoryItem
	{
		// item attributes
		private readonly int itemNumber;
		private string itemDescription;
		private int stockQuantity;
		private int soldQuantity;
		private double cost;
		private double price;

		// constructor
		// soldQty initialized to 0 by default in arguments because a new item is being created, but it could be possible to add an item to process the sale of an item before getting it added to inventory.
		// a special option would need to be accessed by an administor to process such an event though, and it would happen in the InventorySystem class.
		public InventoryItem(int itemNumber, string itemDescription, int stockQuantity, double cost, double price, int soldQuantity = 0)
		{			
			this.itemNumber = itemNumber;
			this.itemDescription = itemDescription;
			this.stockQuantity = stockQuantity;
			this.cost = cost;
			this.price = price;
		}

		// getters and setters

		// item number cannot be modified after initialization via constructor
		public int GetItemNumber()
		{
			return itemNumber;
		}

		// all other attributes have a getter and a setter
		public string GetItemDescription()
		{ 
			return itemDescription;
		}
		public void SetItemDescription(string itemDescription)
		{
			this.itemDescription = itemDescription;
		}
		public int GetStockQuantity(){
			return stockQuantity;
		}
		public void SetStockQuantity(int stockQuantity)
		{
			this.stockQuantity = stockQuantity;
		}
		public int GetSoldQuantity()
		{
			return soldQuantity;
		}
		public void SetSoldQuantity(int soldQuantity)
		{
			this.soldQuantity = soldQuantity;
		}
		public double GetCost()
		{
			return cost;
		}
		public void SetCost(double cost)
		{
			this.cost = cost;
		}
		public double GetPrice()
		{
			return price;
		}
		public void SetPrice(double price)
		{
			this.price = price;
		}

		// class methods

		// ToString override method provides a way to print out the details of the InventoryItem class instance
		public override string ToString()
		{
			return $"\n[ Item Number : {itemNumber}\n| Item Description : {itemDescription}\n| Quantity In Stock : {stockQuantity}\n| Quantity Sold : {soldQuantity}\n| Cost : {cost}\n| Current Price : {price} ]\n";
		}

	}
}
