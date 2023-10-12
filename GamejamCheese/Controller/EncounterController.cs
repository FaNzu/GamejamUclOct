using GamejamCheese.Data;
using GamejamCheese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamejamCheese.View;
using Spectre.Console;

namespace GamejamCheese.Controller
{
	public class EncounterController
	{
		Random random = new Random();
		Encounter encounter = new Encounter(0, 12, 12, DataInitialiser.GenerateItems()[5]); // need to adjust item parameter


		// todo:
		// if vendor go to shopping menu
		// --> Player chooses action from menu ( atk, flee, use item )

		public Item? Encounter(EncounterType type) // todo add modifier AND ADD ITEM TABLE
		{

			switch (type)
			{
				case EncounterType.Alien:
					Console.Write("helllo alien");
					StartBattle();
					break;
				case EncounterType.ArlaEmploye:
					StartBattle();
					break;

				case EncounterType.Vendor:
					// open shopping menu
					break;
			}
			return null;
		}
		public void StartBattle()
		{
			EncounterManager.Show(EncounterType.Alien, encounter);
			bool CombatDone = false;
			// loop. 
			// --> Player chooses action from menu ( atk, flee, use item ) Done ( missing item )
			// effects apply 
			// is enemy dead check? done
			// if dead, drop loot item missing
			// else Enemy action done
			// player losses (hp,O2,fuel) need to change
			// check if O2 and/or hp = 0
			// --> if true = GameOver
			// loop end

			while (CombatDone == false)
			{
				// --> Player chooses action from menu ( atk, flee, use item )

				var Input = AnsiConsole.Prompt(
					 new SelectionPrompt<string>()
					 .Title("")
					 .PageSize(10)
					 .MoreChoicesText("")
					 .AddChoices(new[] { "shoot", "use item", "flee" }));

				switch (Input)
				{
					case "shoot": // atk with weapon
						int DiceRoll = random.Next(1, 20);
						Console.WriteLine("you rolled a:" + DiceRoll);
						encounter.HP -= DiceRoll;
						break;
					case "use item": // use item in inventory

						break;
					case "flee": // try to flee ( dice roll? )
						int FleeRoll = random.Next(1, 100);
						Console.WriteLine("you rolled a:" + FleeRoll);
						if (FleeRoll >= 50)
						{
							//end combat
							CombatDone = true;
						}
						break;
				}
				// effects apply
				// is enemy dead check?

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
					Console.WriteLine("the enemy is attacking");
					Console.WriteLine("you take:" + EnemyRoll + " Damage!");
					Player.HP -= EnemyRoll;
				}
			}

		}
		public void MeetVendor() // needs lots
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
