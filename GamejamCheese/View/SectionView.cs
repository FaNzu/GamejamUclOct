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
	public class SectionView
	{
		public void StartMenu()
		{
			var image = new CanvasImage("../../../View/Pictures/spaceship1.png");
			image.MaxWidth = 15;

			var table = new Table();
			//table.AddColumn($"{section.Name} - {section.Description}");
			table.AddColumn($"Mars - Mars is hot or something").Centered();
			table.AddRow(image).Centered();
			table.AddRow(new Panel("Test panel"));
			table.AddRow(new Panel("Test panel"));
			table.AddRow(new Panel("Test panel"));
			table.AddRow(new Panel("Test panel"));

			AnsiConsole.Write(table);

		}
	}
}
