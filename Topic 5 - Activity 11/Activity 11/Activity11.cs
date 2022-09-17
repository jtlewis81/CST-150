// Jamie Lewis
// CST-150
// ### DATE ###
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

namespace Activity_11
{
	public partial class Activity11 : Form
	{
		private int numRolls;
		private int sides;
		Die die1;
		Die die2;

		public Activity11()
		{
			InitializeComponent();

			// this reset method works for initializing the variables
			GetNewDice();
		}

		// RollDice is called when the user clicks the form button.
		// It calls the RollDie method on each Die object and updates the application GUI.
		// A messageBox appears with a count reult if double 1s (snake eyes) are rolled.
		public void RollDice(object sender, EventArgs e)
		{
			// increment the roll count
			numRolls++;
			
			// roll die 1
			die1_label.Text = die1.RollDie().ToString();
			Console.WriteLine($"Die 1 rolled {die1_label.Text} on roll # {numRolls}");

			// add a chance to get non-matching dice rolls because Random is time-based
			for (int i = 0; i < 10000000; i++)
			{
				// there is probably a much better way to do this
			}
			
			// roll die 2
			die2_label.Text = die2.RollDie().ToString();
			Console.WriteLine($"Die 2 rolled {die2_label.Text} on roll # {numRolls}");

			// end game when snake eyes are rolled
			if (die1_label.Text == "1" && die2_label.Text == "1")
			{
				MessageBox.Show($"It took {numRolls} rolls to get snake eyes!");

				// reset
				GetNewDice();
			}
		}


		// I added this helper method to reset the counter, get a new die size, and generate new die objects of that size
		private void GetNewDice()
		{
			numRolls = 0;
			sides = new Random().Next(4, 21);
			die1 = new Die(sides);
			die2 = new Die(sides);
		}
	}
}
