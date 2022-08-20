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
			// Catch an error that occurs when empty data is submitted
			if (textbox_lbs.Text == "")
			{
				textbox_lbs.Text = "0";
			}

			// Capture user data
			float lbs = float.Parse(textbox_lbs.Text);
			//float kgs = float.Parse(textbox_kgs.Text);

			// Convert to new variables
			//float lbsFromKgs = kgs * 2.2046f;
			float kgsFromLbs = lbs / 2.2046f;

			// Pass new data back to TextBoxes
			//textbox_lbs.Text = lbsFromKgs.ToString();
			textbox_kgs.Text = kgsFromLbs.ToString();
		}

		private void ConvertToLbs(object sender, EventArgs e)
		{
			// Catch an error that occurs when empty data is submitted
			if (textbox_kgs.Text == "")
			{
				textbox_kgs.Text = "0";
			}

			// Capture user data
			//float lbs = float.Parse(textbox_lbs.Text);
			float kgs = float.Parse(textbox_kgs.Text);

			// Convert to new variables
			float lbsFromKgs = kgs * 2.2046f;
			//float kgsFromLbs = lbs / 2.2046f;

			// Pass new data back to TextBoxes
			textbox_lbs.Text = lbsFromKgs.ToString();
			//textbox_kgs.Text = kgsFromLbs.ToString();
		}
	}
}
