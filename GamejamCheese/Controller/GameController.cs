using GamejamCheese.Models;
using GamejamCheese.View;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Controller
{
	public static class GameController
	{
		public static bool IsNotDead { get; set; } = true;
		public static void StartGame()
		{
			var nextSection = SectionController.StartSection(DataController.StartingSection);

			while (IsNotDead)
			{
				nextSection = SectionController.StartSection(nextSection);

				if(Player.HP == 0 || Player.O2 == 0)
				{
					IsNotDead = true;
				}
			}
		}
		public static void Intro()
		{
			AnsiConsole.Status()
				.Start("Loading story...", ctx =>
				{
					AnsiConsole.Write(new FigletText("Cheddar Frontier").Centered().Color(Color.Orange1));
					// Simulate some work
					AnsiConsole.MarkupLine("Andreas Morgensen has spent his entire life searching for the perfect [Orange1]cheese[/].");
					Thread.Sleep(1000);

					// Update the status and spinner
					ctx.Status("Loading more story");
					ctx.Spinner(Spinner.Known.Star);
					ctx.SpinnerStyle(Style.Parse("green"));

					// Simulate some work
					AnsiConsole.Markup("After scouring the earth for all its [Orange1]cheese[/], he concluded that there was only one place left to search: The [White]Moon[/].");
					Thread.Sleep(2000);
					AnsiConsole.MarkupLine("When he finally reaches the moon, he finds that its once bountiful, natural [Orange1]cheese[/] deposits have long since been diminished by the solar systems denizens.");
					Thread.Sleep(2000);
					ctx.Status("Loading more cheesy story");
					AnsiConsole.MarkupLine("But he does not return empty handed, as he finds a map which shows the location of the 9 Legendary [Orange1]cheeses[/] of Power.");
					Thread.Sleep(2000);
					AnsiConsole.MarkupLine("These legendary artifacts have been scattered across the solar system and hold the secretes of all [Orange1]cheese[/].");
					Thread.Sleep(2000);
					AnsiConsole.MarkupLine("Now he must chart the stars and find the [Orange1]cheese[/] before the tyrannical Arla empire find the legendary [Orange1]cheeses[/] and seal the fate of all dairy products in the Solar system.");
					Thread.Sleep(2000);
				});
			AnsiConsole.Write(new Markup("[green]click a key to start the game[/]"));
			Console.ReadKey();
			Console.Clear();
			StartGame();
		}
	}
}
