using GamejamCheese.Models;
using GamejamCheese.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace GamejamCheese.View
{
	public class EncounterManager
	{
		Random random = new Random();

		// todo:
		// check kind of encounter ( friend or foe )
		// if vendor go to shopping menu
		// if enemy go to combat
		// loop.
			// --> Player chooses action from menu ( atk, flee, use item )
			// effects apply
			// damage apply
			// is enemy dead check?
			// if dead, drop loot
			// else Enemy action
			// player losses (hp,O2,fuel)
			// check if O2 and/or hp = 0
			// --> if true = GameOver
		// loop end
		// go to navigation ( overworld choices )

		
		public Item? Encounter(EncounterType type) // todo add modifier
		{
			//if (type == EncounterType.Alien) 
			//{
			//	StartBattle();	
			//}
			//else
			//{
			//	// return ??
			//}

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
            //return ??

            // loop.
            // --> Player chooses action from menu ( atk, flee, use item )
            // effects apply
            // damage apply
            // is enemy dead check?
            // if dead, drop loot
            // else Enemy action
            // player losses (hp,O2,fuel)
            // check if O2 and/or hp = 0
            // --> if true = GameOver
            // loop end

            // --> Player chooses action from menu ( atk, flee, use item )
            Console.WriteLine
				(" choose action! \n" +
				" 1. atk \n" +
				" 2. use item \n" +
				" 3. flee" +
				" "
				);

			int Input = int.Parse(Console.ReadLine());

			switch (Input)
			{
				case 1: // atk with weapon
					int DiceRoll = random.Next(1,20);
					Console.WriteLine("you rolled a:"+DiceRoll);
					break;
				case 2: // use item in inventory

					break;
				case 3: // try to flee ( dice roll? )
                    int FleeRoll = random.Next(1, 100);
                    Console.WriteLine("you rolled a:" + FleeRoll);
					if (FleeRoll >= 50)
					{
						//end combat
					}
                    break;
			}

            // effects apply


            // player damage apply



            // is enemy dead check?
            /*
             * sudo:
             * if enemy's hp <=0: end encounter
             * else: enemies action ( dmg to hp,O2,Fuel )
            */

            int EnemyRoll = random.Next(1, 10);
            Console.WriteLine("the enemy is attacking");
            Console.WriteLine("you take:" + EnemyRoll + " Damage!");
			GamejamCheese.Models.Player.HP - EnemyRoll;


            // if dead, drop loot
            /*
             * roll on the lootTable
             * drop item
             * if inventory is free, pickup
             * else ask to swap item
            */






        }
        public void MeetVendor() 
		{
			// show  shooping menu
			// player buys something
				// update inventory

		}

		static public void show()
		{

			//var table = new Table();

			//// Add some columns
			//table.AddColumn("BattleScreen").Centered();
			////table.AddColumn(new TableColumn("Bar"));

			//// Add some rows
			//table.AddRow("Shoot", "[green]Run[/]");
			//table.AddRow("Dodge", "[green]Inventory[/]");


			//// Render the table to the console
			//AnsiConsole.Write(table);



			AnsiConsole.Write(CreateTable());
		}

		private static Table CreateTable()
		{
			var simple = new Table()
				.Border(TableBorder.Square)
				.BorderColor(Color.Red)
				.AddColumn("Run")
				.AddColumn("Shoot")
				.AddRow("[blue]dodge[/]", "[white]inv[/]")
				.Collapse();

			var playerChart = new BarChart()
				.Width(30)
				.Label("player")
				.AddItem("Health", 30, Color.Red) //ændre 3 til player hp
				.AddItem("O2", 10, Color.Blue); //lyseblå?

			var enemyChart = new BarChart()
				.Width(30)
				.Label("enemy")
				.AddItem("Health", 10, Color.Red) //ændre 3 til player hp
				.AddItem("O2", 1, Color.Blue); //lyseblå?


			//game table
			var second = new Table()
				.Border(TableBorder.Rounded)
				.BorderColor(Color.Green)
				.AddColumn(new TableColumn("[u]player area[/]"))
				.AddColumn(new TableColumn("[u]game area[/]"))
				.AddColumn(new TableColumn("[u]enemy area[/]"))
				.AddRow(playerChart, simple, enemyChart)
				.Centered()
				.Expand();

			return new Table()
				.Centered()
				.Border(TableBorder.DoubleEdge)
				.Title("TABLE [yellow]TITLE[/]")
				.Caption("TABLE [yellow]CAPTION[/]")
				//.AddColumn(new TableColumn(new Panel("[u]ABC[/]").BorderColor(Color.Red)).Footer("[u]FOOTER 1[/]"))
				.AddColumn("drawing area")
				.AddRow(new Text("Hello").Centered())
				.AddRow(second)
				.AddRow(new Markup("[blue]Hej[/]").Centered())
				.Expand();
		}
	}
}
