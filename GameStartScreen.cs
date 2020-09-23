using System;

namespace ConsoleUI {

	public static class GameStartScreen {

		public static void GameTitle() {
			Console.WriteLine();
			Console.WriteLine("SIMPLE DUNGEON CRAWLER");
			Console.WriteLine();
		}

		public static bool StartGame() {
			Console.WriteLine("1.) Start New Game");
			Console.WriteLine("2.) Quit Game");
			Console.WriteLine();
			Console.Write("Choice: ");
			string playerChoice = Console.ReadLine();
			Int32.TryParse(playerChoice, out int option);

			bool output; 

			if (option == 1) {
				output = true;
			}
			else if (option == 2) {
				output = false;
			}
			else {
				Console.WriteLine("You have not selected a valid option. Game exiting...");
				output = false;
			}

			return output;
		}

	}
}