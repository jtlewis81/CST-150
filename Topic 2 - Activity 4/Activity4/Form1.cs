// Jamie Lewis
// CST-150
// 8/26/22
// The modifications to this auto-generated file are my own work.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		// Runs everytime the textbox input is changed
		private void UpdateTime(object sender, EventArgs e)
		{
			// declare a variable to store the user input into
			int time = 0;

			//check if the input is blank
			if (textBox_seconds.Text != "")
			{
				// validate input
				if (int.TryParse(textBox_seconds.Text, out time))
				{
					// do not process data here because it causes a bug where the
					// input field holds the last digit when trying to clear it
				}
				else
				{
					// display error on invalid input, such as letters
					MessageBox.Show("Please enter numerical digits only!");
					// clear the input when the user closes the message box
					textBox_seconds.Text = "";
				}
			}

			// declare variables for the time breakdown
			int minutes = 0;
			int hours = 0;
			int days = 0;

			// calculate days and update time
			days = time / 86400;
			time -= days * 86400;

			// claculate hours and update time
			hours = time / 3600;
			time -= hours * 3600;

			// calculate minutes and update time
			minutes = time / 60;
			time -= minutes * 60;

			// update the label representing the output based on the user's input
			label_output.Text = days + " " + GetPlurality("Day", days) + " : " +
							hours + " " + GetPlurality("Hour", hours) + " : " +
							minutes + " " + GetPlurality("Minute", minutes) + " : " +
							time + " " + GetPlurality("Second", time);
		}

		// bonus helper method that updates the label with singular vs plural wording
		private string GetPlurality(string timeUnit, int num)
		{
			if(num == 1)
			{
				// if the value of a time unit is equal to 1 and only 1, return it as passed
				return timeUnit;
			}
			else
			{
				// if the value is 0 or more than 1, add an "s"
				return timeUnit + "s";
			}
		}
	}
}
