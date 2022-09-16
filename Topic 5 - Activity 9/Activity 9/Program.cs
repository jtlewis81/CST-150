// Jamie Lewis
// CST-150
// 9/16/22
// This is my own work.

// Instructions state that methods need not be implemented,
// but I added default return values where necessasry in order to eliminate errors.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_9
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}

	// Write a class that contains the following “stubs” for methods used in measurement conversion
	// and include a screenshot of your program running with successful output.
	public class Activity9
	{
		// 1. Write a method that takes two integers and displays their sum.
		public void ShowSum(int intA, int intB) { }

		// 2. Write a method that takes five doubles and returns their average.
		public double GetAverageDouble(double doubleA, double doubleB, double doubleC, double doubleD, double doubleE) { return 0; }

		// 3. Write a method that returns the sum of two randomly generated integers.
		public int GetSumOfRandomInts() { return 0; }

		// 4. Write a method that takes three integers and returns true if their sum is divisible by 3, false otherwise.
		public bool IsSumDivisibleByThree(int intA, int intB, int intC) { return false; }

		// 5. Write a method that takes two strings and displays the string that has fewer characters.
		public void ShowShortestString(string stringA, string stringB) { }

		// 6. Write a method that takes an array of doubles and returns the largest value in the array.
		public double GetLargestDoubleFromArray(double[] doublesArray) { return 0; }

		// 7. Write a method that generates and returns an array of fifty integer values.
		public int[] GenerateArrayOfFiftyInts() { return new int[50]; }

		// 8. Write a method that takes two bool variables and returns true if they have the same value, false otherwise.
		public bool BoolsHaveSameValue(bool boolA, bool boolB) { return false; }

		// 9. Write a method that takes an int and a double and returns their product.
		public double GetIntTimesDouble(int intNum, double doubleNum) { return 0; }

		// 10. Write a method that takes a two-dimensional array of integers and returns the average of the entries.
		public int GetAverageOfIntMatrix(int[][] intMatrix) { return 0; }
	}
}