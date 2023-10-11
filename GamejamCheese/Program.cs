using GamejamCheese.Controller;
using GamejamCheese.View;
using Spectre.Console;
using GamejamCheese.Models;
using GamejamCheese.Controller;

namespace GamejamCheese
{
	internal class Program
	{
		static void Main(string[] args)
		{
			EncounterManager.show();

            //var image = new CanvasImage("../../../View/Pictures/spaceship1.png");
            //image.MaxWidth = 25;
            //AnsiConsole.Write(image);
            //AnsiConsole.Markup("[underline bold red]Hello[/] World!");

            EncounterController encounterController = new EncounterController();
            encounterController.Encounter(EncounterType.Alien);
            SectionView section = new SectionView();
			section.StartMenu();
			Console.ReadLine();
		}
	}
}