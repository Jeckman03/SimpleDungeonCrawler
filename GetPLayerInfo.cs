using System;

namespace ConsoleUI {

	public static class GetPlayerInfo {
		
		public static string GetCharacterName(string message) {
			Console.Clear();
			Console.Write(message);
			string output = Console.ReadLine();

			return output;
		}

		public static string PlayerTurnAction(int playerSelection) {
			string output;
			bool isValid = false;

			do {
				if (playerSelection == 1) {
					isValid = true;
					output = "attack";
				}
				else if (playerSelection == 2) {
					isValid = true;
					output = "inventory";
				}
				else if (playerSelection == 3) {
					isValid = true;
					output = "buy";
				}
				else if (playerSelection == 4) {
					isValid = true;
					output = "exit";
				}
				else {
					Console.WriteLine("You have entered an invalid number. Try again...");output = "na";					
				}
			} while (isValid == false);

			return output;
		}

	}
}