using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Models
{
    public class Player
	{
		public int HP { get; set; }
		public Item[] PlayerInventory { get; set; }
		public Item[] PlayerGearSlots { get; set; } 
		public int O2 { get; set; }
		public int Fuel { get; set; }
		public int BaseDamage { get; set; }

		//gear slots

		public Player() { }
		public Player(int hP, int o2, int fuel)
		{
			HP = hP;
			PlayerInventory = new Item[10];
			O2 = o2;
			Fuel = fuel;
			PlayerGearSlots = new Item[5];
		}

		public void DoDamage()
		{

		}
	}
}
