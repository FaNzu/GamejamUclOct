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

			// Quest Items
			result.Add(new Item(TypeOfItem.QuestItem, "Map 1", "A Map of Mars?", 0, null));
			result.Add(new Item(TypeOfItem.QuestItem, "Moon Key", "Key found in the Moon base", 0, null));
			result.Add(new Item(TypeOfItem.QuestItem, "Mars Bar Rumors", "Some rumors you overheard at the Mars Bar, you uh... put them on a usb or something.", 0, null));
			result.Add(new Item(TypeOfItem.QuestItem, "Mafia's Mars Pyramid", "Key for the Mars Pyramid, previously safguarded by the head of the local mafia.", 0, null));
			result.Add(new Item(TypeOfItem.QuestItem, "Pyramid Key Part 1", "Half of some sort of key. Found in the Mars Pyramid", 0, null));
			result.Add(new Item(TypeOfItem.QuestItem, "Pyramid Key Part 2", "Half of some sort of key. Found in the Mars Pyramid", 0, null));

			// Consumables
			result.Add(new Item(TypeOfItem.Consumeble, "Minimilk", "Small drink of bovine origin, popular within the Arla Empire.", 15, ItemEffect.HealAmountHP));
			result.Add(new Item(TypeOfItem.Consumeble, "Cheese and Crackers", "Now with 10% REAL Cheese!", 30, ItemEffect.HealAmountHP));
			result.Add(new Item(TypeOfItem.Consumeble, "Mars Original", "A pint of Mars brewed beer, comes perfectly poured from the factory.", 30, ItemEffect.HealAmountHP));
			result.Add(new Item(TypeOfItem.Consumeble, "White Russian", "Like the one on earth, but uh... with milk.", 30, ItemEffect.HealAmountHP));
			result.Add(new Item(TypeOfItem.Consumeble, "Oxygen Tank", "Small singleuse container of O2. Can be used to top up your suits oxygen supply.", 15, ItemEffect.RestoreAmountO2));
			result.Add(new Item(TypeOfItem.Consumeble, "Jerry Can", "A can originaly invented by one Jerry F. Uel, usualy contains fuel.", 15, ItemEffect.RestoreFuel));

			// Junk
			result.Add(new Item(TypeOfItem.Junk, "Moon Rock", "Suprisingly popular on earth, in space not so much.", 2, null));
			result.Add(new Item(TypeOfItem.Junk, "Mars Rock", "Wow, cool rock bro.", 2, null));
			result.Add(new Item(TypeOfItem.Junk, "Alien's Finger", "Glows for a while when shaken, useful for emergency lighting.", 5, null));
			result.Add(new Item(TypeOfItem.Junk, "Mars Mafioso Tattoo", "Apparently they are actually just stickers", 3, null));

			return result;
		}
	}
}
