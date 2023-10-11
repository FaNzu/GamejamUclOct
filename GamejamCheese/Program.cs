using GamejamCheese.Controller;
using GamejamCheese.View;
using Spectre.Console;
using GamejamCheese.Models;
using GamejamCheese.Data;

namespace GamejamCheese
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//EncounterManager.show();

			//var image = new CanvasImage("../../../View/Pictures/spaceship1.png");
			//image.MaxWidth = 25;
			//AnsiConsole.Write(image);
			//AnsiConsole.Markup("[underline bold red]Hello[/] World!");
			//EncounterManager encounterManager = new EncounterManager();
			//encounterManager.Encounter(EncounterType.Alien);

			//For at teste section view
			//Section section = new Section("Mars", "This planet has no form of life", "Dig a hole", null, Modifier.ZeroOxygen);
			//SectionController.NewSection(section);

			//For at teste item view
			//for (int i = 0; i < 10; i++)
			//{
			//	Player.PlayerInventory[i] = DataInitialiser.GenerateItems().ToArray()[i]; 
			//}
			//InventoryController.Show();

			Console.ReadLine();
		}
	}
}