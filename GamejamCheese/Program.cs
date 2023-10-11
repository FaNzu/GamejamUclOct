using Spectre.Console;

namespace GamejamCheese
{
	internal class Program
	{
		static void Main(string[] args)
		{


			var image = new CanvasImage("../../../View/Pictures/spaceship1.png");
			image.MaxWidth = 25;
			AnsiConsole.Write(image);
			AnsiConsole.Markup("[underline bold red]Hello[/] World!");
		}
	}
}