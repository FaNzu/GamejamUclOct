using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Models
{
    public static class Player
	{
		public static int HP { get; set; } = 50;
		public static List<Item> PlayerInventory { get; set; } = new List<Item>();
		public static List<Item> PlayerGearSlots { get; set; } = new List<Item>();
		public static int O2 { get; set; } = 50;
		public static int Fuel { get; set; } = 50;
		public static int Coins { get; set; } = 0;
	}
}
