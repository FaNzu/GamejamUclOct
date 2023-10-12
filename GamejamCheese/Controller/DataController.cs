using GamejamCheese.Data;
using GamejamCheese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Controller
{
	public static class DataController
	{
		public static List<Item> Items { get; set; } = DataInitialiser.GenerateItems();
	}
}
