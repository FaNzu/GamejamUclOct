﻿using GamejamCheese.Models;
using GamejamCheese.View;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Controller
{
	public static class SectionController
	{
		public static Section StartSection(Section section)
		{
			EncounterController encounterController = new EncounterController();
			Random random = new Random();
			int randomnumber = random.Next(0, 4);

			switch (randomnumber)
			{

				case 0:
					encounterController.StartBattle();
					break;
				case 1:
					encounterController.StarBattleArla();
					break;
				case 2:
					EncounterController.MeetVendor();
					break;
				case 3:
					break;
			}

			Section? result = null;

			while (result == null)
			{
				result = HandleChoices(SectionView.ShowAndReturnChoice(section), section);
			}
			return result;
		}

		private static Section? HandleChoices(int choice, Section section)
		{
			Section? result = null;
			switch (choice)
			{
				case 1:
					string temp = SearchSection();
					AnsiConsole.Clear();
					Console.WriteLine(temp);
					Console.ReadLine();
					AnsiConsole.Clear();
					break;
				case 2:
					AnsiConsole.Clear();
					InventoryController.Show();
					AnsiConsole.Clear();
					break;
				case 3:
				case 4:
				case 5:
					//Move to new section when result is false
					AnsiConsole.Clear();
					if (section.Connections.Count - 1 < choice - 3)
						break;

					if (section.Connections[choice - 3].NextSection.Name == section.Name)
						result = section.Connections[choice - 3].LastSection;
					else
						result = section.Connections[choice - 3].NextSection;
					break;
			}
			return result;
		}
		private static string SearchSection()
		{
			string result = string.Empty;
			Random random = new Random();
			int randomnumber = random.Next(0, 5);
			bool isFound = true;

			switch (randomnumber)
			{

				case 0:
					while (isFound)
					{
						int randomNumber = random.Next(0, DataController.Items.Count);
						var randomItem = DataController.Items[randomNumber];

						if (randomItem.ItemType == TypeOfItem.Junk)
						{
							Player.PlayerInventory.Add(randomItem);
							isFound = false;
							result = $"You got this item: {randomItem.Name}";
						}
					}
					break;
				case 1:
					while (isFound)
					{
						int randomNumber = random.Next(0, DataController.Items.Count);
						var randomItem = DataController.Items[randomNumber];

						if (randomItem.ItemType == TypeOfItem.Consumeble)
						{
							Player.PlayerInventory.Add(randomItem);
							isFound = false;
							result = $"You got this item: {randomItem.Name}";
						}
					}
					break;
				case 2:
					while (isFound)
					{
						int randomNumber = random.Next(0, DataController.Items.Count);
						var randomItem = DataController.Items[randomNumber];

						if (randomItem.ItemType == TypeOfItem.Gear)
						{
							Player.PlayerInventory.Add(randomItem);
							isFound = false;
							result = $"You got this item: {randomItem.Name}";
						}
					}
					break;
				case 3:
					int foundCoins = random.Next(1, 20);
					Player.Coins += foundCoins;
					result = $"You found {foundCoins} coins.\n Your new balance is {Player.Coins}";
					break;
				case 4:
					result = "You searched the area but found nothing.";
					break;
			}
			return result;
		}
	}
}
