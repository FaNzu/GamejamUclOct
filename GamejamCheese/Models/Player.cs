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
		public static Item[] PlayerInventory { get; set; } = new Item[10];
		public static Item[] PlayerGearSlots { get; set; } = new Item[5];
		public static int O2 { get; set; } = 50;
        public static int Fuel { get; set; } = 50;
		public static int BaseDamage { get; set; } = 10;
	}
}
