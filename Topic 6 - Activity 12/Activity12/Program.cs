// Jamie Lewis
// CST-150
// 9/23/22
// This is my own work.

using System;
using System.Collections.Generic;
using System.IO;

namespace Activity12
{
	// The program reads a text file and finds all words ending with 'e' or 't', not case sensative.
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				// Open a text file
				StreamReader inputFile = File.OpenText("E:/GitHub/CST-150/Topic 6 - Activity 12/Activity12/test.txt");

				// Save the entire contents into a string
				string contents = inputFile.ReadToEnd();

				// Close the file
				inputFile.Close();

				// Create a set of delimiters. We'll use space, comma, semi-colon, and period
				char[] delimiters = new char[] { ',', '.', ';', ' ' };

				// Split the file contents into a tokenized array based on the delimiters
				string[] wordList = contents.Split(delimiters);

				// Make a List to store the words to be filtered into
				List<string> filteredWords = new List<string>();

				// Loop through the array of word tokens and add them to the List if they end in 't' or 'e'
				for (int i = 0; i < wordList.Length; i++)
				{
					if(wordList[i].EndsWith('t') || wordList[i].EndsWith('T') || wordList[i].EndsWith('e') || wordList[i].EndsWith('E'))
					{
						filteredWords.Add(wordList[i]);
					}
				}

				// Output the results of the search
				Console.WriteLine($"There are {wordList.Length} words in the file. \n {filteredWords.Count} words end with t or e. \n Those words are:");
				for (int i = 0; i < filteredWords.Count; i++)
				{
					Console.Write(filteredWords[i] + ", ");
				}
				Console.WriteLine();
			}
			catch (Exception e)
			{
				Console.WriteLine("ERROR: " + e);
			}


		}
	}
}
