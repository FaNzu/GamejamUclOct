﻿using GamejamCheese.Data;
using GamejamCheese.Models;
using GamejamCheese.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace GamejamCheese.Controller
{
	public class EncounterController
	{

		private static Random random = new Random();
		Encounter encounter = new Encounter(0, 40, 40, DataInitialiser.GenerateItems()[5]); // need to adjust item parameter
		EncounterType EnemyType;





		// todo:
		// if vendor go to shopping menu
		// --> Player chooses action from menu ( atk, flee, use item )

		public Item? Encounter(EncounterType enemyType) // todo add modifier AND ADD ITEM TABLE
		{


			switch (enemyType)
			{

				case EncounterType.ArlaEmploye:
					StarBattleArla();
					break;

				case EncounterType.Vendor:
					// open shopping menu
					break;
				default:
					Console.Write("helllo alien");
					StartBattle();
					break;
			}
			return null;
		}
		public void StartBattle()
		{

			bool CombatDone = false;

			while (CombatDone == false)
			{

				EncounterManager.Show(EncounterType.Alien, encounter);
				// --> Player chooses action from menu ( atk, flee, use item )

				var Input = AnsiConsole.Prompt(
					 new SelectionPrompt<string>()
					 .Title("")
					 .PageSize(10)
					 .MoreChoicesText("")
					 .AddChoices(new[] { "shoot", "use item", "flee" }));
				int DiceRoll = 0;
				switch (Input)
				{
					case "shoot": // atk with weapon
						DiceRoll = random.Next(1, 20);
						encounter.HP -= DiceRoll;
						break;
					case "use item": // use item in inventory
						Console.WriteLine("you're out of items! oh no!");
						break;
					case "flee": // try to flee ( dice roll? )
						int FleeRoll = random.Next(1, 100);
						Console.WriteLine("you rolled a " + FleeRoll);
						if (FleeRoll >= 50)
						{
							//end combat
							CombatDone = true;
						}
						break;
				}

				//Console.Clear();
				AnsiConsole.Clear();
				Console.WriteLine("You rolled a:" + DiceRoll);


				if (encounter.HP <= 0)
				{
					// end encounter
					/*
                     * roll on the lootTable
                     * drop item
                     * if inventory is free, pickup
                     * else ask to swap item
                     */
					CombatDone = true;
				}
				else
				{
					int EnemyRoll = random.Next(1, 10); // IDEA: random if dmg is to hp o2 or fuel?

					Console.WriteLine("the enemy is attacking! " + "you take:" + EnemyRoll + " Damage!");
					Player.HP -= EnemyRoll;
				}

			}

		}

		public void StarBattleArla()
		{

			bool CombatDone = false;

			while (CombatDone == false)
			{

				EncounterManager.Show(EncounterType.ArlaEmploye, encounter);
				// --> Player chooses action from menu ( atk, flee, use item )

				var Input = AnsiConsole.Prompt(
					 new SelectionPrompt<string>()
					 .Title("")
					 .PageSize(10)
					 .MoreChoicesText("")
					 .AddChoices(new[] { "shoot", "use item", "flee" }));
				int DiceRoll = 0;
				switch (Input)
				{
					case "shoot": // atk with weapon
						DiceRoll = random.Next(1, 20);
						encounter.HP -= DiceRoll;
						break;
					case "use item": // use item in inventory

						break;
					case "flee": // try to flee ( dice roll? )
						int FleeRoll = random.Next(1, 100);
						Console.WriteLine("you rolled a " + FleeRoll);
						if (FleeRoll >= 50)
						{
							//end combat
							CombatDone = true;
						}
						break;
				}

				//Console.Clear();
				AnsiConsole.Clear();
				Console.WriteLine("You rolled a:" + DiceRoll);


				if (encounter.HP <= 0)
				{
					// end encounter
					/*
                     * roll on the lootTable
                     * drop item
                     * if inventory is free, pickup
                     * else ask to swap item
                     */
					CombatDone = true;
				}
				else
				{
					int EnemyRoll = random.Next(1, 10); // IDEA: random if dmg is to hp o2 or fuel?

					Console.WriteLine("the enemy is Talking about Arla buisness! " + "you take:" + EnemyRoll + " Damage!");
					Player.HP -= EnemyRoll;
				}

			}

		}


		public static void MeetVendor() // needs lots
		{
			List<Item> allItems = DataInitialiser.GenerateItems();
			List<Item> selectedItems = new List<Item>();
			for (int i = 0; i < 4; i++)
			{
				selectedItems.Add(allItems[random.Next(allItems.Count())]);
			}
			AnsiConsole.Write(EncounterManager.CreateVendorTable(selectedItems));
			var fruits = AnsiConsole.Prompt(
				new MultiSelectionPrompt<string>()
					.Title("What are your [green]favorite fruits[/]?")
					.MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
					.InstructionsText("[grey](Press [blue]<space>[/] to toggle a fruit, [green]<enter>[/] to accept)[/]")
					.AddChoices(new[]
					{
						$"{selectedItems[0]}", $"{selectedItems[1]}",$"{selectedItems[2]}",$"{selectedItems[3]}",$"None"
					}));
			if (fruits.Contains("None"))
			{
				Console.WriteLine("You bought nothing");
			}
			else
			{

				foreach (var fruit in fruits)
				{
					AnsiConsole.WriteLine(fruit);
					//add items to player inventory
				}
			}
		}
	}
}
