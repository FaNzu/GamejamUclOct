using GamejamCheese.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.View
{
	public static class InventoryView
	{
		public static void Show()
		{
			if (Player.PlayerInventory.Count == 0)
			{
				Console.WriteLine("You have nothing in you're inventory");
			}
			else
			{
				AnsiConsole.Prompt(GenerateMenu());
			}
		}


		//Kig på om det kan gøres flottere
		private static SelectionPrompt<Item> GenerateMenu()
		{
			var inventory = new SelectionPrompt<Item>()
				.Title("Here is you're invetory")
				.MoreChoicesText("Move up and down to navigate")
				.AddChoices(Player.PlayerInventory);

			if (Player.PlayerInventory.Count < 3)
			{
				inventory.PageSize(3);
			}
			else
			{
				inventory.PageSize(Player.PlayerInventory.Count);
			}

			return inventory;
		}



	}
}
