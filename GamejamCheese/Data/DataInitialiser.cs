using GamejamCheese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Data
{
	public static class DataInitialiser
	{
		public static List<Item> GenerateItems()
		{
			List<Item> result = new List<Item>();
			Item HeadItem = new Item("HeadItem2000","Very rusty helmet", 15, ItemEffect.IncreaseHP, SlotType.Helmet);


			result.Add(HeadItem);

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

            //Junk
            result.Add(new Item(TypeOfItem.Junk, "Can", "A can originaly invented by one Jerry F. Uel, usualy contains fuel.", 15, ItemEffect.RestoreFuel));

            return result;
		}
	}
}
