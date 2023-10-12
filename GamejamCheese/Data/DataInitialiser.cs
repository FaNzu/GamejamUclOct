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

			return result;
		}

        public Section GenerateSections() 
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
            Connection MilkMafiaHQtoMilkMafiaRoom = new Connection();
            Connection MilkMafiaRoomToMilkMafiaBoss = new Connection();
            Connection CheesePyramidToPyramidRightWing = new Connection();
            Connection CheesePyramidToPyramidLeftWing = new Connection();
            Connection CheesePyramidToPyramidFinalRoom = new Connection();

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
            Section PyramidRightWing = new Section("The right wing of the Pyramid", "Smells like Old Brie", "Look Around", Modifier.HighGravity);
            Section PyramidLeftWing = new Section("The left wing of the Pyramid", "Are the walls made of cheese?", "Look Around", Modifier.HighGravity);
            Section PyramidFinalRoom = new Section("The legendary cheese antechamber", "At long last", "Look Around", Modifier.HighGravity);


            #region Connection Sections
            //Connecting sections
            MoonOrbitToMoonSurface.NextSection = MoonSurface;
            MoonOrbitToMoonSurface.LastSection = MoonOrbit;
            MoonOrbitToMoonSurface.IsVisible = true;

            MoonOrbit.Connections.Add(MoonOrbitToMoonSurface);

            MoonOrbitToSpaceDiner.NextSection = SpaceDiner;
            MoonOrbitToSpaceDiner.LastSection = MoonOrbit;
            MoonOrbitToSpaceDiner.IsVisible = true;

            MoonOrbit.Connections.Add(MoonOrbitToSpaceDiner);

            MoonSurfaceToMoonCrater1.NextSection = MoonCrater1;
            MoonSurfaceToMoonCrater1.NextSection = MoonSurface;
            MoonSurfaceToMoonCrater1.IsVisible = true;

            MoonSurface.Connections.Add(MoonSurfaceToMoonCrater1);

            MoonSurfaceToMoonCrater2.NextSection = MoonCrater2;
            MoonSurfaceToMoonCrater2.LastSection = MoonSurface;
            MoonSurfaceToMoonCrater2.IsVisible = true;

            MoonSurface.Connections.Add(MoonSurfaceToMoonCrater2);

            MoonCrater1ToMoonRuin.NextSection = MoonRuin;
            MoonCrater1ToMoonRuin.LastSection = MoonCrater1;
            MoonCrater1ToMoonRuin.IsVisible = true;

            MoonCrater1.Connections.Add(MoonCrater1ToMoonRuin);

            MoonRuinToMoonRuinRoom1.NextSection = MoonRuinRoom1;
            MoonRuinToMoonRuinRoom1.LastSection = MoonRuin;
            MoonRuinToMoonRuinRoom1.IsVisible = true;

            MoonRuin.Connections.Add(MoonRuinToMoonRuinRoom1);

            MoonRuinToMoonRuin2.NextSection = MoonRuinRoom2;
            MoonRuinToMoonRuin2.LastSection = MoonRuin;
            MoonRuinToMoonRuin2.IsVisible = true;

            MoonRuin.Connections.Add(MoonRuinToMoonRuin2);

            MoonOrbitToMarsOrbit.NextSection = MarsOrbit;
            MoonOrbitToMarsOrbit.LastSection = MoonOrbit;
            MoonOrbitToMarsOrbit.IsVisible = true;

            MoonOrbit.Connections.Add(MoonOrbitToMarsOrbit);

            MarsOrbitToMartianCapital.NextSection = MartianCapital;
            MarsOrbitToMartianCapital.LastSection = MarsOrbit;
            MarsOrbitToMartianCapital.IsVisible = true;

            MarsOrbit.Connections.Add(MarsOrbitToMartianCapital);

            MartianCapitalToMartianBar.NextSection = MartianBar;
            MartianCapitalToMartianBar.LastSection = MartianCapital;
            MartianCapitalToMartianBar.IsVisible = true;

            MartianCapital.Connections.Add(MartianCapitalToMartianBar);

            MartianCapitalToMilkMafiaHQ.NextSection = MilkMafiaHQ;
            MartianCapitalToMilkMafiaHQ.LastSection = MartianCapital;
            MartianCapitalToMilkMafiaHQ.IsVisible = true;

            MartianCapital.Connections.Add(MartianCapitalToMilkMafiaHQ);

            MartianCapitalToCheesePyramid.NextSection = CheesePyramid;
            MartianCapitalToCheesePyramid.LastSection = MartianCapital;
            MartianCapitalToMilkMafiaHQ.IsVisible = true;

            MartianCapital.Connections.Add(MartianCapitalToCheesePyramid);

            MilkMafiaHQtoMilkMafiaRoom.NextSection = MilkMafiaRoom;
            MilkMafiaHQtoMilkMafiaRoom.LastSection = MilkMafiaHQ;
            MilkMafiaHQtoMilkMafiaRoom.IsVisible = true;

            MilkMafiaHQ.Connections.Add(MilkMafiaHQtoMilkMafiaRoom);

            MilkMafiaRoomToMilkMafiaBoss.NextSection = MilkMafiaBoss;
            MilkMafiaRoomToMilkMafiaBoss.LastSection = MilkMafiaRoom;
            MilkMafiaRoomToMilkMafiaBoss.IsVisible = true;

            MilkMafiaRoom.Connections.Add(MilkMafiaRoomToMilkMafiaBoss);

            CheesePyramidToPyramidRightWing.NextSection = PyramidRightWing;
            CheesePyramidToPyramidRightWing.LastSection = CheesePyramid;
            CheesePyramidToPyramidRightWing.IsVisible = true;

            CheesePyramid.Connections.Add(CheesePyramidToPyramidRightWing);

            CheesePyramidToPyramidLeftWing.NextSection = PyramidLeftWing;
            CheesePyramidToPyramidLeftWing.LastSection = CheesePyramid;
            CheesePyramidToPyramidLeftWing.IsVisible = true;

            CheesePyramid.Connections.Add(CheesePyramidToPyramidLeftWing);

            CheesePyramidToPyramidFinalRoom.NextSection = PyramidFinalRoom;
            CheesePyramidToPyramidFinalRoom.LastSection = CheesePyramid;
            CheesePyramidToPyramidFinalRoom.IsVisible = true;

            CheesePyramid.Connections.Add(CheesePyramidToPyramidFinalRoom);
            #endregion

            //Adds Sections to list

            return MoonOrbit;
        }
	}
}
