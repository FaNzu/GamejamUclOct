using GamejamCheese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using GamejamCheese.Data;

namespace GamejamCheese.View
{
	public class EncounterManager
	{
		private static CanvasImage playerimage = new CanvasImage("../../../View/Pictures/Mars.png");
		private static CanvasImage image = new CanvasImage("../../../View/Pictures/amongus.png");

		public static void Show(EncounterType type, Encounter enemy)
		{
			switch (type)
			{
				case EncounterType.Alien:
					image = new CanvasImage("../../../View/Pictures/amongus.png");
					break;
				case EncounterType.ArlaEmploye:
					image = new CanvasImage("../../../View/Pictures/Arla.png");
					break;
				case EncounterType.Vendor:
					image = new CanvasImage("../../../View/Pictures/Vendor.png");
					break;
				default:
					image = new CanvasImage("../../../View/Pictures/amongus.png");
					break;
			}
			AnsiConsole.Write(CreateCombatTable(enemy));
			Console.ReadLine();
			image = new CanvasImage("../../../View/Pictures/Vendor.png");
			//AnsiConsole.Write(CreateVendorTable());
		}

		private static Table CreateCombatTable(Encounter enemy)
		{
			var simple = new Table()
				.Border(TableBorder.Square)
				.BorderColor(Color.Red)
				.AddColumn("Run")
				.AddColumn("Shoot")
				.AddRow("[blue]dodge[/]", "[white]inv[/]")
				.Centered()
				.Collapse();

			var playerChart = new BarChart()
				.Width(50)
				.Label("player")
				.AddItem("Health", Player.HP, Color.Red) //ændre 3 til player hp
				.AddItem("O2", Player.O2, Color.Blue); //lyseblå?

			var enemyChart = new BarChart()
				.Width(50)
				.Label("enemy")
				.AddItem("Health", enemy.HP, Color.Red) //ændre 3 til player hp
				.AddItem("O2", enemy.O2, Color.Blue); //lyseblå?

			
			image.MaxWidth = 10;
			playerimage.MaxWidth = 10;

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


			var first = new Table()
				.AddColumn("player")
				.AddColumn("filler")
				.AddColumn("enemy")
				.HideHeaders()
				.Border(TableBorder.None)
				.AddRow(playerimage, new Text(""), image)
				.Expand()
				.Centered();

			return new Table()
				.Centered()
				.Border(TableBorder.DoubleEdge)
				.Title("TABLE [yellow]TITLE[/]")
				.Caption("TABLE [yellow]CAPTION[/]")
				.AddColumn("middle")
				.AddRow(first)
				.AddRow(second)
				.Expand();
		}

		public static Layout CreateVendorTable(List<Item> selectedItems)
		{
			image = new CanvasImage("../../../View/Pictures/Vendor.png"); 
			CanvasImage itemImage = new CanvasImage("../../../View/Pictures/Box.png");
			//Random random = new Random();
			var layout = new Layout("Root")
						.SplitRows(
							new Layout("Drawing"),
							new Layout("Pictures")
								.SplitColumns(
									new Layout("Item1"),
									new Layout("Item2"),
									new Layout("Item3"),
									new Layout("Item4")),
							new Layout("Stats")
								.SplitColumns(
									new Layout("Stats1"),
									new Layout("Stats2"),
									new Layout("Stats3"),
									new Layout("Stats4")));


			//ukommanter disse ligner for at få items ind i koden igen.

			//List<Item> allItems = DataInitialiser.GenerateItems();
			//List<Item> selectedItems = new List<Item>();
			layout["Drawing"].Update(image.MaxWidth(10));
			for (int i = 0; i < 4; i++)
			{
				//selectedItems.Add(allItems[random.Next(allItems.Count())]);
				layout[$"Item{i+1}"].Update(new Panel(Align.Center(itemImage.MaxWidth(10))).Expand().Header($"item{i+1}"));
				layout[$"Stats{i+1}"].Update(new Panel(Align.Center(new Text($"Name: {selectedItems[i].Name}\nValue: {selectedItems[i].Value}"))).Header($"Stats{i+1}"));

			}
			

			return layout;
		}
	}
}