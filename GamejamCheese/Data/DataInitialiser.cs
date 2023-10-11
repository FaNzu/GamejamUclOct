using GamejamCheese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Data
{
	public class DataInitialiser
	{
		public List<Item> GenerateItems()
		{
			List<Item> result = new List<Item>();
			// Gear
			result.Add(new Item("HeadItem2000","A very rusty helmet, it has a big dent", 15, ItemEffect.IncreaseHP, SlotType.Helmet));
            result.Add(new Item("ChestItem2001", "A rusty breastplate, it is almost falling apart", 20, ItemEffect.IncreaseHP, SlotType.Chest));
            result.Add(new Item("PantsItem2002", "A pair of rusty iron pants, they pinch in a very unfortunate place", 20, ItemEffect.IncreaseHP, SlotType.Pants));
            result.Add(new Item("ShoesItem2003","A very rusty pair of iron boots, not very comfortable", 15, ItemEffect.IncreaseHP, SlotType.Shoes));
			result.Add(new Item("WeaponItem2004", "A rusty old sword, why do you even have this?", 25, ItemEffect.IncreaseBaseDamage, SlotType.Weapon));
			result.Add(new Item("HeadItem2005", "An old astronaut helmet, the glass is a bit cracked", 15, ItemEffect.IncreaseO2, SlotType.Helmet));
            result.Add(new Item("ChestItem2006", "An old astronaut suit, it reeks of cheese", 20, ItemEffect.IncreaseO2, SlotType.Chest));
            result.Add(new Item("PantsItem2007", "An old pair of astronaut pants, they are still a bit warm", 20, ItemEffect.IncreaseO2, SlotType.Pants));
			result.Add(new Item("ShoesItem2008", "A pair of old astronaut boots, they are a about a size too big", 15, ItemEffect.IncreaseO2, SlotType.Shoes));
            result.Add(new Item("WeaponItem2009", "An old mining laser, it barely works", 30, ItemEffect.IncreaseBaseDamage, SlotType.Weapon));
	
			return result;
		}
	}
}
