using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity13
{
	public partial class TicTacToe : Form
	{
		// declare "permanent" game variables (they are the same for every game and never change)
		Label[,] gridSpaces;

		public TicTacToe()
		{
			InitializeComponent();

			// initialize permanent game variables
			gridSpaces = new Label[,] { { space_label_0, space_label_1, space_label_2 },
								   { space_label_3, space_label_4, space_label_5 },
								   { space_label_6, space_label_7, space_label_8 } };
		}

		private void StartNewGame(object sender, EventArgs e)
		{
			ResetSpaces();

			// declare and initialize "fluid" game variables (they get reset for every new game)
			bool isPlayer1Turn = true;
			List<int[]> availableGridSpaces = new List<int[]>();
			availableGridSpaces.Add(new int[] { 0, 0 });
			availableGridSpaces.Add(new int[] { 0, 1 });
			availableGridSpaces.Add(new int[] { 0, 2 });
			availableGridSpaces.Add(new int[] { 1, 0 });
			availableGridSpaces.Add(new int[] { 1, 1 });
			availableGridSpaces.Add(new int[] { 1, 2 });
			availableGridSpaces.Add(new int[] { 2, 0 });
			availableGridSpaces.Add(new int[] { 2, 1 });
			availableGridSpaces.Add(new int[] { 2, 2 });

			// main game loop
			for (int turn = 1; turn < 10; turn++)
			{
				// pick a random remaining grid space using a list of remaining spaces
				int index = new Random().Next(0, availableGridSpaces.Count);
				int[] nextPlayedSpace = availableGridSpaces[index];

				// use 2d array index to set player marker
				if (isPlayer1Turn)
				{
					gridSpaces[nextPlayedSpace[0], nextPlayedSpace[1]].Text = "X";
				}
				else if(!isPlayer1Turn)
				{
					gridSpaces[nextPlayedSpace[0], nextPlayedSpace[1]].Text = "O";
				}

				// check if game over
				if (turn >= 3 && CheckForWinner(isPlayer1Turn))
				{
					break;
				}
				else if(turn == 9)
				{
					status_label.Text = "Draw!";
					break;
				}

				// remove played space from available spaces list
				availableGridSpaces.Remove(nextPlayedSpace);


				// change players turn if game will continue
				isPlayer1Turn = !isPlayer1Turn;
			}
		}

		private bool CheckForWinner(bool isPlayer1Turn)
		{
			// check columns, rows, and diagonals that are not empty
			if ( gridSpaces[0, 0].Text.Equals(gridSpaces[0, 1].Text) && gridSpaces[0, 1].Text.Equals(gridSpaces[0, 2].Text) && !gridSpaces[0, 0].Text.Equals("") ||
				gridSpaces[1, 0].Text.Equals(gridSpaces[1, 1].Text) && gridSpaces[1, 1].Text.Equals(gridSpaces[1, 2].Text) && !gridSpaces[1, 0].Text.Equals("") ||
				gridSpaces[2, 0].Text.Equals(gridSpaces[2, 1].Text) && gridSpaces[2, 1].Text.Equals(gridSpaces[2, 2].Text) && !gridSpaces[2, 0].Text.Equals("") ||
				gridSpaces[0, 0].Text.Equals(gridSpaces[1, 0].Text) && gridSpaces[1, 0].Text.Equals(gridSpaces[2, 0].Text) && !gridSpaces[0, 0].Text.Equals("") ||
				gridSpaces[0, 1].Text.Equals(gridSpaces[1, 1].Text) && gridSpaces[1, 1].Text.Equals(gridSpaces[2, 1].Text) && !gridSpaces[0, 1].Text.Equals("") ||
				gridSpaces[0, 2].Text.Equals(gridSpaces[1, 2].Text) && gridSpaces[1, 2].Text.Equals(gridSpaces[2, 2].Text) && !gridSpaces[0, 2].Text.Equals("") ||
				gridSpaces[0, 0].Text.Equals(gridSpaces[1, 1].Text) && gridSpaces[1, 1].Text.Equals(gridSpaces[2, 2].Text) && !gridSpaces[0, 0].Text.Equals("") ||
				gridSpaces[0, 2].Text.Equals(gridSpaces[1, 1].Text) && gridSpaces[1, 1].Text.Equals(gridSpaces[2, 0].Text) && !gridSpaces[0, 2].Text.Equals(""))
			{
				// update gaem status if game over
				if (isPlayer1Turn)
				{
					status_label.Text = "Player 1 Wins!";
				}
				else
				{
					status_label.Text = "Player 2 Wins!";
				}

				return true;
			}
			// no winner
			else
			{
				return false;
			}			
		}

		void ResetSpaces()
		{
			foreach (Label space in gridSpaces)
			{
				space.Text = "";
			}
		}

		private void Exit(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
