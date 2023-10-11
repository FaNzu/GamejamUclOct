using GamejamCheese.Controller;
using GamejamCheese.View;
using Spectre.Console;
using GamejamCheese.Models;
namespace GamejamCheese
{
	internal class Program
	{
		static void Main(string[] args)
		{
			EncounterManager encounterManager = new EncounterManager();
			EncounterManager.Show(EncounterType.Alien);

			//var image = new CanvasImage("../../../View/Pictures/spaceship1.png");
			//image.MaxWidth = 25;
			//AnsiConsole.Write(image);
			//AnsiConsole.Markup("[underline bold red]Hello[/] World!");
			//encounterManager.Encounter(EncounterType.Alien);
			//Section section = new Section("Mars", "This planet has no form of life", "Dig a hole", null, Modifier.ZeroOxygen);
			//SectionController.NewSection(section);
			Console.ReadLine();


		}
	}
}