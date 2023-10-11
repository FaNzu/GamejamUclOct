using GamejamCheese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Data
{
	public class DataInitialiser
	{
		public List<Item> GenerateItems()
		{
			List<Item> result = new List<Item>();
			Item HeadItem = new Item("HeadItem2000","Very rusty helmet", 15, ItemEffect.IncreaseHP, SlotType.Helmet);


			result.Add(HeadItem);
			return result;
		}
	}
}
