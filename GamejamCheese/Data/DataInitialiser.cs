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
            #region creating items
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
            #endregion
            return result;
		}

		public static Section GenerateSections() 
		{
            //New Connections
            Connection MoonOrbitToMoonSurface = new Connection();
            Connection MoonOrbitToSpaceDiner = new Connection();
            Connection MoonSurfaceToMoonCrater1 = new Connection();
            Connection MoonSurfaceToMoonCrater2 = new Connection();
            Connection MoonCrater1ToMoonRuin = new Connection();
            Connection MoonRuinToMoonRuinRoom1 = new Connection();
            Connection MoonRuinToMoonRuin2 = new Connection();
            Connection MoonOrbitToMarsOrbit = new Connection();
            Connection MarsOrbitToMartianCapital = new Connection();
            Connection MartianCapitalToMartianBar = new Connection();
            Connection MartianCapitalToMilkMafiaHQ = new Connection();
            Connection MartianCapitalToCheesePyramid = new Connection();

            //New sections
            Section MoonOrbit = new Section("The Moon", "Where is all the cheese?", "Land on the surface", Modifier.NormalGravity);
            Section SpaceDiner = new Section("A space diner", "Smells like freshly baked crackers", "Buy some food", Modifier.NormalGravity);
            Section MoonSurface = new Section("The Moon's surface", "Silence fills the air, there is no cheese", "Search for Cheese", Modifier.LowGravity);
            Section MoonCrater1 = new Section("A big Moon crater", "There is an old ruin in the middle of the crater", "Investigate Ruin", Modifier.LowGravity);
            Section MoonCrater2 = new Section("A small Moon crater", "There is something hidden in the Moon Dust", "Ivestigate mound of Moon dust", Modifier.LowGravity);
            Section MoonRuin = new Section("The Moon Ruin", "The Ruin is covered in moon dust", "Search the Ruin", Modifier.LowGravity);
            Section MoonRuinRoom1 = new Section("Ruin Room", "Smells like Mozzarella", "Search the room", Modifier.LowGravity);
            Section MoonRuinRoom2 = new Section("Ruin Side Room", "Smells like enemies", "Search the room", Modifier.LowGravity);
            Section MarsOrbit = new Section("Mars", "The home of the Martians", "Land on the surface", Modifier.NormalGravity);
            Section MartianCapital = new Section("The capital of Mars", "The bustle of the city reminds you of home", "Search the City", Modifier.NormalGravity);
            Section MartianBar = new Section("The Crazy Cow", "The most famous dairy bar on Mars", "Ask Around", Modifier.NormalGravity);
            Section MilkMafiaHQ = new Section("The Milk Mafia HQ", "The home of the famous Al Cowpone", "Search the Area", Modifier.HighTemp);
            Section CheesePyramid = new Section("The Great Cheese Pyramid", "You feel the hands of fate churning", "Search the Pyramid", Modifier.HighGravity);
            Section MilkMafiaRoom = new Section("Milk Mafia Storage Facility", "Smells like crime and cheese", "Look Around", Modifier.HighTemp);
            Section MilkMafiaBoss = new Section("Al Cowpone's Office", "His little friend says hello", "Search the office", Modifier.HighTemp);

			#region Connecting sections
			//Connecting sections
			MoonOrbitToMoonSurface.NextSection = MoonSurface;
            MoonOrbitToMoonSurface.LastSection = MoonOrbit;
            MoonOrbitToMoonSurface.IsVisible = true;

            insterConnect(MoonOrbitToMoonSurface);

            MoonOrbitToSpaceDiner.NextSection = SpaceDiner;
            MoonOrbitToSpaceDiner.LastSection = MoonOrbit;
            MoonOrbitToSpaceDiner.IsVisible = true;

			insterConnect(MoonOrbitToSpaceDiner);

            MoonSurfaceToMoonCrater1.NextSection = MoonCrater1;
            MoonSurfaceToMoonCrater1.LastSection = MoonSurface;
            MoonSurfaceToMoonCrater1.IsVisible = true;

			insterConnect(MoonSurfaceToMoonCrater1);

            MoonSurfaceToMoonCrater2.NextSection = MoonCrater2;
            MoonSurfaceToMoonCrater2.LastSection = MoonSurface;
            MoonSurfaceToMoonCrater2.IsVisible = true;

            insterConnect(MoonSurfaceToMoonCrater2);

            MoonCrater1ToMoonRuin.NextSection = MoonRuin;
            MoonCrater1ToMoonRuin.LastSection = MoonCrater1;
            MoonCrater1ToMoonRuin.IsVisible = true;

            insterConnect(MoonCrater1ToMoonRuin);

            MoonRuinToMoonRuinRoom1.NextSection = MoonRuinRoom1;
            MoonRuinToMoonRuinRoom1.LastSection = MoonRuin;
            MoonRuinToMoonRuinRoom1.IsVisible = true;

            insterConnect(MoonRuinToMoonRuinRoom1);

            MoonRuinToMoonRuin2.NextSection = MoonRuinRoom2;
            MoonRuinToMoonRuin2.LastSection = MoonRuin;
            MoonRuinToMoonRuin2.IsVisible = true;

            insterConnect(MoonRuinToMoonRuin2);

            MoonOrbitToMarsOrbit.NextSection = MarsOrbit;
            MoonOrbitToMarsOrbit.LastSection = MoonOrbit;
            MoonOrbitToMarsOrbit.IsVisible = true;

            insterConnect(MoonOrbitToMarsOrbit);

            MarsOrbitToMartianCapital.NextSection = MartianCapital;
            MarsOrbitToMartianCapital.LastSection = MarsOrbit;
            MarsOrbitToMartianCapital.IsVisible = true;

            insterConnect(MarsOrbitToMartianCapital);

            MartianCapitalToMartianBar.NextSection = MartianBar;
            MartianCapitalToMartianBar.LastSection = MartianCapital;
            MartianCapitalToMartianBar.IsVisible = true;

            insterConnect(MartianCapitalToMartianBar);

            MartianCapitalToMilkMafiaHQ.NextSection = MilkMafiaHQ;
            MartianCapitalToMilkMafiaHQ.LastSection = MartianCapital;
            MartianCapitalToMilkMafiaHQ.IsVisible = true;

            insterConnect(MartianCapitalToMilkMafiaHQ);

            MartianCapitalToCheesePyramid.NextSection = CheesePyramid;
            MartianCapitalToCheesePyramid.LastSection = MartianCapital;
            MartianCapitalToCheesePyramid.IsVisible = true;

            insterConnect(MartianCapitalToCheesePyramid);
            #endregion
            //Adds Sections to list
			return MoonOrbit;
        }

        static void insterConnect (Connection con)
        {
            con.NextSection.Connections.Add(con);
			con.LastSection.Connections.Add(con);
		}
	}
}
