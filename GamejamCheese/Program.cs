using GamejamCheese.View;
using Spectre.Console;
using GamejamCheese.Models;
namespace GamejamCheese
{
	internal class Program
	{
		static void Main(string[] args)
		{


			//var image = new CanvasImage("../../../View/Pictures/spaceship1.png");
			//image.MaxWidth = 25;
			//AnsiConsole.Write(image);
			//AnsiConsole.Markup("[underline bold red]Hello[/] World!");
			EncounterManager encounterManager = new EncounterManager();
			encounterManager.Encounter(EncounterType.Alien);
		}
	}
}