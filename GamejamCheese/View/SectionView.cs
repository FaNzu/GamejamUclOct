using GamejamCheese.Models;
using Spectre.Console;
using Spectre.Console.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.View
{
	public static class SectionView
	{
		public static void Show(Section section)
		{
			AnsiConsole.Write(StartMenu(section));
		}
		public static Table StartMenu(Section section)
		{
			var image = new CanvasImage("../../../View/Pictures/Mars.png");
			image.MaxWidth = 15;

			var titleAndImage = new Table()
				.AddColumn($"{section.Name} - {section.Description}").Centered()
				.AddRow(image).Centered()
				.Border(TableBorder.None);

			var status = new BarChart()
				.AddItem("Health", 10, Color.Red)
				.AddItem("O2", 15, Color.SkyBlue1)
				.AddItem("Fuel", 10, Color.LightYellow3)
				.Width(50);


			var playerMenu = new Table()
				.AddColumn("Actions")
				.AddColumn("Move")
				.AddColumn("Status")
				.AddRow($"1. {section.Choice}", "2. Station")
				.AddRow(new Text("3. Inventory"), new Text("4. Bar"), status)
				.Expand();

			var result = new Table()
			   .Centered()
			   .Expand()
			   .AddColumn("")
			   .HideHeaders()
			   .AddRow(titleAndImage)
			   .AddRow(playerMenu);

			return result;
		}
	}
}
