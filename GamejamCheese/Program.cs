using GamejamCheese.Controller;
using GamejamCheese.Models;
using GamejamCheese.Data;

using GamejamCheese.View;
namespace GamejamCheese
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SectionController.StartSection(DataController.StartingSection);
			Console.ReadLine();			
		}
	}
}