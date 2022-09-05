// Jamie Lewis
// CST-150
// 9/4/22
// The modifications on this auto-generated file are my own work.

// I got really close to getting this working without Google,
// but I did wind up using the help of this site to fine tune the algorithm:
// https://iq.opengenus.org/different-ways-to-calculate-pi/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity_7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void CalculatePI(object sender, EventArgs e)
		{
			// variables for output and calculations
			string ioLabel = "The approximate value of PI for " + input_textbox.Text + " terms =";
			decimal output =  0;
			decimal denominator = 1;


			// use try-catch for input validation
			try
			{
				// get input value
				int input = int.Parse(input_textbox.Text);

				// run calculations
				for(int i = 0; i < input; i++) // if input is 0, this loop should not run
				{
					if (i % 2 == 0) // even input < add 4/divisor to previous iteration result >
					{
						output += (4 / denominator);
					}
					else if (i % 2 == 1) // odd input < subtract 4/divisor from previous iteration result >
					{
						output -= (4 / denominator);
					}

					// increment the divisor by 2 each iteration
					denominator += 2;
				}

				// update the gui with the results
				io_label.Text = ioLabel;
				output_label.Text = output.ToString();
			}
			catch
			{
				// display message on bad input
				MessageBox.Show("Please enter a whole number!");
			}

		}
	}
}