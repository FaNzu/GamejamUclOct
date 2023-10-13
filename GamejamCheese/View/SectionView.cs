using GamejamCheese.Models;
using Spectre.Console;
using Spectre.Console.Rendering;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.View
{
	public static class SectionView
	{
		public static int ShowAndReturnChoice(Section section)
		{
			AnsiConsole.Write(StartMenu(section));
			int result = AnsiConsole.Prompt(MakeChoice(section));
			return result;
		}
		public static Table StartMenu(Section section)
		{
			//var image = new CanvasImage(section.ImagePath);
			//image.MaxWidth = 25;

			var titleAndImage = new Table()
				.AddColumn($"{section.Name} - {section.Description}").Centered()
				//.AddRow(image).Centered()
				.Border(TableBorder.None);

			var status = new BarChart()
				.AddItem("Health", Player.HP, Color.Red)
				.AddItem("O2", Player.O2, Color.SkyBlue1)
				.AddItem("Fuel", Player.Fuel, Color.LightYellow3)
				.Width(50);

			var playerMenu = new Table();

			if (section.Connections.Count == 0 || section.Connections == null)
			{
				playerMenu
				.AddColumn("Actions")
				.AddColumn("Move")
				.AddColumn("Status")
				.AddRow($"1. Search the area")
				.AddRow(new Text("2. Inventory"), new Text($"4. test"), status)
				.Expand();
			}
			else
			{
				playerMenu
				.AddColumn("Actions")
				.AddColumn("Move")
				.AddColumn("Status")
				.Expand();

				if (section.Connections.Count >= 1)
				{
					Section connection= section.Connections[0].NextSection;
					if (connection.Name == section.Name)
						connection = section.Connections[0].LastSection;

					playerMenu.AddRow($"1. Search the area", $"3. {connection.Name}");
				} else
					playerMenu.AddRow($"1. Search the area");

				if (section.Connections.Count >= 2)
				{
					Section connection = section.Connections[1].NextSection;
					if (connection.Name == section.Name)
						connection = section.Connections[1].LastSection;

					playerMenu.AddRow(new Text("2. Inventory"), new Text($"4. {connection.Name}"), status);
				} else
					playerMenu.AddRow($"2. Inventory");

				if (section.Connections.Count >= 3)
				{
					Section? connection = section.Connections[2].NextSection;
					if (connection.Name == section.Name)
						connection = section.Connections[2].LastSection;

					playerMenu.AddRow(new Text(""), new Text($"5. {connection.Name}"), status);
				}
			}
			

			var result = new Table()
			   .Centered()
			   .Expand()
			   .AddColumn("")
			   .HideHeaders()
			   .AddRow(titleAndImage)
			   .AddRow(playerMenu);

			return result;
		}
		public static SelectionPrompt<int> MakeChoice(Section section)
		{
			List<int> choices = new List<int>();
			for (int i = 1; i <= section.Connections.Count + 2; i++)
				choices.Add(i);

			var result = new SelectionPrompt<int>()
				.AddChoices(choices)
				.PageSize(choices.Count)
				.Title("Make a choice");

			return result;
		}
	}
}
