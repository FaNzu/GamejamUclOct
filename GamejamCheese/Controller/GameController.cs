using GamejamCheese.Models;
using GamejamCheese.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Controller
{
	public static class GameController
	{
		public static bool IsNotDead { get; set; } = true;
		public static void StartGame()
		{
			var nextSection = SectionController.StartSection(DataController.StartingSection);

			while (IsNotDead)
			{
				nextSection = SectionController.StartSection(nextSection);

				if(Player.HP == 0 || Player.O2 == 0)
				{
					IsNotDead = true;
				}
			}
		}
	}
}
