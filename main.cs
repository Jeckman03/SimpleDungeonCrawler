using System;
using System.Collections.Generic;

namespace ConsoleUI {

  class MainClass {
    public static void Main (string[] args) {
  
  		GameStartScreen.GameTitle();
  		bool startGame = GameStartScreen.StartGame();

			while (startGame == true) {
				//set dungeon level to 1
				int dungeonLevel = 1;

				//getting the characters name and assging it
				string characterName = GetPlayerInfo.GetCharacterName("What is your name hero: ");

				//creating a new character and setting the starting atributes
				CharacterModel player = new CharacterModel(characterName, 1, 100, 0, 0, 0);

				//creating a players inventory list for this game
				List<InventoryModel> charactersInventory = new List<InventoryModel>();

				//display character stat bar
				CharacterInfoUI.CharacterInfoBar(characterName, player.Level, player.Health, player.Attack, player.Defense, player.Gold);

				//display the main gameplay text and dungeon Level
				int playerAction = GameplayScreen.MainGameplayText("Goblin", dungeonLevel);

				      Console.ReadLine();

			}

			Console.WriteLine("Thanks for playing!");
  
      Console.ReadLine();
    }
  }
}

