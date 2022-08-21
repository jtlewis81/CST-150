// Jamie Lewis
// CST-150
// ### DATE ###
// The modifications on this auto-generated file are my own work.

// Mathmatical formulas retrieved from:
// https://www.metric-conversions.org/weight/pounds-to-kilograms.htm
// https://www.metric-conversions.org/weight/kilograms-to-pounds.htm

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
	public partial class Activity2 : Form
	{		
		public Activity2()
		{
			InitializeComponent();
		}

		private void Activity2_Load(object sender, EventArgs e)
		{

		}

		private void ConvertToKgs(object sender, EventArgs e)
		{
			// Automatically correct empty data submission by making it a 0
			if (textbox_lbs.Text == "")
			{
				textbox_lbs.Text = "0";
			}

			// Attempt to process data, and give user feedback if it fails
			try
			{
				// Capture user data - check for invalid input
				float lbs = float.Parse(textbox_lbs.Text);

				// Convert to new variables
				float kgsFromLbs = lbs / 2.2046f;

				// Pass new data back to TextBoxes
				textbox_kgs.Text = kgsFromLbs.ToString();
			}
			catch
			{
				MessageBox.Show("Please enter only numbers!");
			}
			

			
		}

		private void ConvertToLbs(object sender, EventArgs e)
		{
			// Automatically correct empty data submission by making it a 0
			if (textbox_kgs.Text == "")
			{
				textbox_kgs.Text = "0";
			}

			// Attempt to process data, and give user feedback if it fails
			try
			{
				// Capture user data - check for invalid input
				float kgs = float.Parse(textbox_kgs.Text);

				// Convert to new variables
				float lbsFromKgs = kgs * 2.2046f;

				// Pass new data back to TextBoxes
				textbox_lbs.Text = lbsFromKgs.ToString();
			}
			catch
			{
				MessageBox.Show("Please enter only numbers!");
			}
			
		}
	}
}
