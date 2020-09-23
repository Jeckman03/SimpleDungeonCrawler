using System;

namespace ConsoleUI {

	public class CharacterModel {
		
		public string Name { get; set; }
		public int Level { get; set; }
		public int Health { get; set; }
		public int Attack { get; set; }
		public int Defense { get; set; }
		public int Gold { get; set; }

		public CharacterModel(string name, int level, int health, int attack, int defense, int gold) {
			Name = name;
			Level = level;
			Health = health;
			Attack = attack;
			Defense = defense;
			Gold = gold;
		}

	}
}