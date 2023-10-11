
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
		static public void show()
		{
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
				.Width(30)
				.Label("player")
				.AddItem("Health", 30, Color.Red) //ændre 3 til player hp
				.AddItem("O2", 10, Color.Blue); //lyseblå?

			var enemyChart = new BarChart()
				.Width(30)
				.Label("enemy")
				.AddItem("Health", 10, Color.Red) //ændre 3 til player hp
				.AddItem("O2", 1, Color.Blue); //lyseblå?

			var image = new CanvasImage("../../../View/Pictures/spaceship1.png");
			image.MaxWidth = 10;

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
				.AddRow(image, new Text(""), image)
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