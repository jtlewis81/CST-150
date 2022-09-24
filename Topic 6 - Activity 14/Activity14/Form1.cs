using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
	public partial class Form1 : Form
	{
		int basePrice;
		int totalPrice;
		int[] basePrices = new int[6] { 15000, 25000, 30000, 45000, 40000, 55000 };
		int[] enginePrices = new int[4] { 500, 1200, 1500, 2000 };
		int[] optionPrices = new int[8] { 1000, 400, 250, 250, 500, 750, 1200, 250 };
		int autoTransUpgradePrice = 2500;
		CheckBox[] options;
		RadioButton[] engineUpgrades;

		public Form1()
		{
			InitializeComponent();

			options = new CheckBox[8] { leather_checkBox, heatedSeats_checkBox,
								  powerDriverSeat_checkBox, powerPassSeat_checkBox,
								  nav_checkBox, sunroof_checkBox, premiumMedia_checkBox,
								  tint_checkBox};

			engineUpgrades = new RadioButton[4] { v6_radioButton, turboV6_radioButton, smallV8_radioButton, bigV8_radioButton };
		}

		private void SetBasePrice(object sender, EventArgs e)
		{
			int selectedIndex = bodyStyle_listBox.SelectedIndex;
			basePrice = basePrices[selectedIndex];
			basePrice_label.Text = $"${basePrice}.00";
			totalPrice = basePrice;
			totalPrice_label.Text = totalPrice.ToString();
			UpdatePrice(this, EventArgs.Empty);
		}


		// recalculate total price
		private void UpdatePrice(object sender, EventArgs e)
		{
			// reset to selected base price
			totalPrice = basePrice;

			// loop through options and add the associated cost to total
			for(int i = 0; i < optionPrices.Length; i++)
			{
				if (options[i].Checked)
				{
					totalPrice += optionPrices[i];
				}
			}

			// find selected engine upgrade option and add cost
			for (int i = 0; i < engineUpgrades.Length; i++)
			{
				if (engineUpgrades[i].Checked)
				{
					totalPrice += enginePrices[i];
				}
			}

			// add auto transmission cost if applicable
			if (autoTrans_radioButton.Checked)
			{
				totalPrice += autoTransUpgradePrice;
			}

			// update the total price label
			totalPrice_label.Text = $"${totalPrice}.00";
		}

		private void PlaceOrder(object sender, EventArgs e)
		{
			if (color_listBox.SelectedItem != null && bodyStyle_listBox.SelectedItem != null)
			{
				MessageBox.Show($"Thank you for your order of a {color_listBox.SelectedItem} {bodyStyle_listBox.SelectedItem}, totaling ${totalPrice}!");
			}
			else
			{
				MessageBox.Show("Please select at least a body style and color.");
			}
		}

		private void Exit(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
