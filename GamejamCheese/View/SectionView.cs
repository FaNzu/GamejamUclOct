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
			int result = AnsiConsole.Prompt(MakeChoice());
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
				.AddItem("Health", 10, Color.Red)
				.AddItem("O2", 15, Color.SkyBlue1)
				.AddItem("Fuel", 10, Color.LightYellow3)
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
				.AddRow($"1. Search the area", $"3. {section.Connections[0].NextSection.Name}")
				.AddRow(new Text("2. Inventory"), new Text($"4. {section.Connections[1].NextSection.Name}"), status)
				.Expand();
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
		public static SelectionPrompt<int> MakeChoice()
		{
			int[] choices = { 1, 2, 3, 4 };
			var result = new SelectionPrompt<int>()
				.AddChoices(choices)
				.PageSize(choices.Length)
				.Title("Make a choice");

			return result;
		}
	}
}
