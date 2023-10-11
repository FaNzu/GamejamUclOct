using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamejamCheese.Models.Inventory;

namespace GamejamCheese.Models
{
	public class Player
	{
		public int HP { get; set; }
		public List<Item> PlayerInventory { get; set; }
		public int O2 { get; set; }
		public int fuel { get; set; }
		//gear slots

		public Player() { }
		public Player(int hP, List<Item> playerInventory, int o2, int fuel)
		{
			HP = hP;
			PlayerInventory = playerInventory;
			O2 = o2;
			this.fuel = fuel;
		}
	}
}
