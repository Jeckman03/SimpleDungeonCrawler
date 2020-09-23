using System;

namespace ConsoleUI {

	public static class GameplayScreen {
		
		public static int MainGameplayText(string enemyName, int dungeonLevel) {
			Console.WriteLine($"----------- DUNGEON LEVEL { dungeonLevel } -----------");
			Console.WriteLine();
			Console.WriteLine($"You have encountered a { enemyName }!");
			Console.WriteLine();
			Console.Write("What will you do: ");
			string playerChoice = Console.ReadLine();

			Int32.TryParse(playerChoice, out int output);
			Console.WriteLine();
			PlayersActions();

			return output;
		}

		public static void PlayersActions() {
			Console.WriteLine("1. Attack");
			Console.WriteLine("2. Inventory");
			Console.WriteLine("3. Buy");
			Console.WriteLine("4. Quit Game");
		}

	}
}