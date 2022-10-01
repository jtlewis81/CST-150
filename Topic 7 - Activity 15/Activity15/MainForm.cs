using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15
{
	public partial class MainForm : Form
	{
		public static int LuckyNumber = 0;

		public MainForm()
		{
			InitializeComponent();

			// programmatically populate the first ComboBox
			holiday_comboBox.Items.AddRange(new string[7] { "New Years", "Valentine's Day", "St. Patrick's Day", "Easter", "Independence Day", "Thanksgiving", "Christmas" });

		}

		// On selecting an item from the first ComboBox, populate the second one accordingly
		private void GetNextQuestion(object sender, EventArgs e)
		{
			// remove previous options and selection
			nextQuestion_comboBox.SelectedItem = null;
			nextQuestion_comboBox.Items.Clear();

			// add new options
			switch (holiday_comboBox.SelectedItem.ToString())
			{
				case "New Years":
					{
						nextQuestion_label.Text = "Why do you like New Year's?";
						nextQuestion_comboBox.Items.AddRange(new string[3] { "Drinking", "Fireworks", "Fresh Start" });
						break;
					}
				case "Valentine's Day":
					{
						nextQuestion_label.Text = "What is your relationship status?";
						nextQuestion_comboBox.Items.AddRange(new string[5] { "Single", "Have a boyfriend or girlfriend", "Engaged", "Married", "Widowed" });
						break;
					}
				case "St. Patrick's Day":
					{
						nextQuestion_label.Text = "Are you Irish?";
						nextQuestion_comboBox.Items.AddRange(new string[4] { "No", " I wish I were", "Partly" , "Yes" });
						break;
					}
				case "Easter":
					{
						nextQuestion_label.Text = "Hollow or solid chocolate bunny?";
						nextQuestion_comboBox.Items.AddRange(new string[3] { "Chocolate? Eww!", "Hollow", "Solid" });
						break;
					}
				case "Independence Day":
					{
						nextQuestion_label.Text = "How do you like your steak?";
						nextQuestion_comboBox.Items.AddRange(new string[6] { "I'm a vegetarian/vegan", "Well Done", "Rare", "Medium-Rare", "Medium-Well", "Medium" });
						break;
					}
				case "Thanksgiving":
					{
						nextQuestion_label.Text = "Ham or Turkey?";
						nextQuestion_comboBox.Items.AddRange(new string[3] { "Ham", "Turkey - white meat", "Turkey - dark meat" });
						break;
					}
				case "Christmas":
					{
						nextQuestion_label.Text = "Open presents on Christmas Eve?";
						nextQuestion_comboBox.Items.AddRange(new string[3] { "No - Christmas Day only", "Yes - both Chistmas Eve and Day", "Yes - Christmas Eve only" });
						break;
					}

				default:
					{
						break;
					}
			}	
		}

		// lucky number generation algorithm
		// 
		// multiply a random number from 1-100 by the (index number + 1) of the second question answer
		// then, divide that result by a random number from 1 - 10.

		private void CalculateLuckyNumber(object sender, EventArgs e)
		{
			// make sure both questions are answered
			if(holiday_comboBox.SelectedItem != null && nextQuestion_comboBox.SelectedItem != null)
			{
				int selectedFactor = nextQuestion_comboBox.SelectedIndex;
				int[] randomFactors = new int[2] { new Random().Next(1, 101), new Random().Next(1, 11) };

				// save lucky number
				LuckyNumber = (randomFactors[0] * (selectedFactor + 1)) / randomFactors[1];

				// open results form
				Form results = new ResultsForm();

				results.ShowDialog();
			}
			else
			{
				MessageBox.Show("Please answer both questions.");

			}
		}

		private void Exit(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
