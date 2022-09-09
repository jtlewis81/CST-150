// Jamie Lewis
// CST-150
// 9/9/22
// The modifications on this auto-generated file are my own work.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Gets called any time any text box's text is changed
		// calculates the change from grams from fat and/or carbs to calories
		// updates the total calories in the gui label controls
		private void UpdateTotalCalories(object sender, EventArgs e)
		{
			// declare and initialize variables
			int fatGrams = 0;
			int carbGrams = 0;
			
			//update variables with input validation
			try
			{
				if (fatGramsInput_textBox.Text == "")
				{
					fatGrams = 0;
				}
				else
				{
					fatGrams = int.Parse(fatGramsInput_textBox.Text);
				}
			}
			catch
			{
				DisplayError("Fat");
			}

			try
			{
				if (carbGramsInput_textBox.Text == "")
				{
					carbGrams = 0;
				}
				else
				{
					carbGrams = int.Parse(carbGramsInput_textBox.Text);
				}
			}
			catch
			{
				DisplayError("Carb");
			}

			// declare and initialize calorie totals using assignment methods
			int fatCalories = FatCalories(fatGrams);
			int carbCalories = CarbCalories(carbGrams);

			// update output labels
			fatCaloriesOutput_label.Text = fatCalories.ToString() + " Calories";
			carbCaloriesOutput_label.Text = carbCalories.ToString() + " Calories";
			totalCalories_label.Text = $" Total Calories = {fatCalories + carbCalories} ";
		}

		// Calculates the number of calories from fat based on a number of fat grams
		// Returns the number of fat calories as an int
		private int FatCalories(int fatGrams)
		{
			return fatGrams * 9;
		}

		// Calculates the number of calories from carbs based on a number of carbs grams
		// Returns the number of calories from carbs as an int
		private int CarbCalories(int carbGrams)
		{
			return carbGrams * 4;
		}

		// shows the error message box with an appropriate message based on the passed parameter
		private void DisplayError(string term)
		{
			MessageBox.Show($"Please enter only a whole number of {term} Grams.");
		}


		// exit button quits the program
		private void Exit(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
