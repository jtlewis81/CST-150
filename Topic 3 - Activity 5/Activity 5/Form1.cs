// Jamie Lewis
// CST-150
// 9/4/22
// The modifications on this auto-generated file are my own work.

// The helper method for counting vowels uses a switch statement derived from this video: https://www.youtube.com/watch?v=fapzDz_S-pQ&ab_channel=MicroNG

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

namespace Activity_5
{
	public partial class Form1 : Form
	{
		// variables for use in the application
		StreamReader fileInput;
		StreamWriter fileOutput;
		List<string> wordList = new List<string>();
		string fileInputName;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		// Process File Data

		private void GetStatisticalWords(object sender, EventArgs e)
		{
			try
			{
				// do nothing if list is empty (i.e. if button calling this method is clicked before opening a file)
				if (wordList.Count == 0)
				{
					return;
				}

				// sort word list alphabetically
				wordList.Sort();

				// assign first and last indices to first and last alphabetical statistical fields
				firstAlphabetical_label.Text = wordList[0];
				lastAlphabetical_label.Text = wordList[wordList.Count - 1];

				// assign first word in list to value of other statistical fields
				string longestWord = wordList[0];
				string mostVowels = wordList[0];

				// loop through list and replace words as appropriate
				for (int i = 0; i < wordList_ListBox.Items.Count; i++)
				{
					// store temp variable for multiple tests
					string temp = wordList[i];

					// replace longest word only if longer, do not replace with word of same length
					if (temp.Length > longestWord.Length)
					{
						longestWord = temp;
					}

					// replace word with most vowels
					if (GetVowelCount(temp) > GetVowelCount(mostVowels))
					{
						mostVowels = temp;
					}
				}

				// assign final statistical field labels 
				longest_label.Text = longestWord;
				mostVowels_label.Text = mostVowels;
			}
			catch (Exception)
			{
				MessageBox.Show("No file selected. Please open a file.");
			}

		}

		// Open a File, get the data, and then close it.

		private void OpenFile(object sender, EventArgs e)
		{
			wordList_ListBox.Items.Clear();

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// get file data
				fileInput = File.OpenText(openFileDialog.FileName);
				// save the filename for later use
				fileInputName = openFileDialog.SafeFileName;
				
				while (!fileInput.EndOfStream)
				{
					// convert word to lowercase
					string lowercaseWord = fileInput.ReadLine();
					// add item in the listBox
					wordList_ListBox.Items.Add(lowercaseWord);
					// add words to List of type string
					wordList.Add(lowercaseWord);
				}

				fileInput.Close();
			}
			else
			{
				MessageBox.Show("No file selected. Please open a file.");
			}
		}

		// Create a file to save, write data to it, and close it.

		private void SaveStatisticsToFile(object sender, EventArgs e)
		{
			
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				fileOutput = File.CreateText(saveFileDialog.FileName);
				fileOutput.WriteLine("The file " + fileInputName + " contains the following statistical words:");
				fileOutput.WriteLine("First word alphabetically: " + firstAlphabetical_label.Text);
				fileOutput.WriteLine("Last word alphabetically: " + lastAlphabetical_label.Text);
				fileOutput.WriteLine("Longest word: " + longest_label.Text);
				fileOutput.WriteLine("Word Containing the most vowels: " + mostVowels_label.Text);
				fileOutput.Close();

				MessageBox.Show("File Saved Successfully!");
			}
			else
			{
				MessageBox.Show("File NOT Saved. User cancelled.");
			}
		}

		// Count the number of vowels in the passed string

		private int GetVowelCount(string word)
		{
			if (word == "")
			{
				return 0;
			}

			int count = 0;

			char[] c = word.ToCharArray();

			for (int i = 0; i < c.Length; i++)
			{
				switch (c[i])
				{
					case 'a':
					case 'A':
					case 'e':
					case 'E':
					case 'i':
					case 'I':
					case 'o':
					case 'O':
					case 'u':
					case 'U':
						count++;
						break;
					default:
						break;
				}
					
			}

			return count;
		}
	}
}
