using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_11
{
	// The Die class represents a die with any number of sides between 4 and 20.
	// The RollDie method returns a random int value between 1 and the number of sides on the Die.
	class Die
	{
		private int sides;

		// default value is set to 6 because that is the most common Die size.
		public Die(int sides = 6)
		{
			// catch an error if the contructor parameter is [ <4 || >20 ]
			try
			{
				if(sides >= 4 && sides <= 20)
				{
					this.sides = sides;
				}
			}
			catch
			{
				Console.WriteLine("Invalid Die Size!\nThe number of sides must be between 4 and 20.");
			}
		}

		public int RollDie()
		{
			return new Random().Next(1, this.sides + 1);
		}

	}
}
