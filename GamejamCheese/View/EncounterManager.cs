using GamejamCheese.Models;
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
		private static CanvasImage playerimage = new CanvasImage("../../../View/Pictures/Mars.png");
		private static CanvasImage image;


		static public void Show(EncounterType type)
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
				.Centered()
				.Collapse();

			var playerChart = new BarChart()
				.Width(50)
				.Label("player")
				.AddItem("Health", 50, Color.Red) //ændre 3 til player hp
				.AddItem("O2", 40, Color.Blue); //lyseblå?

			var enemyChart = new BarChart()
				.Width(50)
				.Label("enemy")
				.AddItem("Health", 50, Color.Red) //ændre 3 til player hp
				.AddItem("O2", 50, Color.Blue); //lyseblå?

			
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
	}
}