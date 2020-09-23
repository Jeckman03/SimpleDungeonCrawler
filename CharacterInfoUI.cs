using System;

namespace ConsoleUI {

	public static class CharacterInfoUI {
		
		public static void CharacterInfoBar(string name, int level, int health, int attack, int defense, int gold) {
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine($"Hero: { name }   Level: { level }   Health: { health }   Atk: { attack }   Def: { defense }   Gold: { gold }");
			Console.WriteLine("***********************************************************************");
			Console.WriteLine();
		}

	}
}