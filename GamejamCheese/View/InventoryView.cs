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
			AnsiConsole.Prompt(GenerateMenu());
		}


		//Kig på om det kan gøres flottere
		private static SelectionPrompt<Item> GenerateMenu()
		{
			var inventory = new SelectionPrompt<Item>()
				.Title("Here is you're invetory")
				.PageSize(Player.PlayerInventory.Count())
				.MoreChoicesText("Move up and down to navigate")
				.AddChoices(Player.PlayerInventory);


			return inventory;
		}



	}
}
