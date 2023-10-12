using GamejamCheese.Models;
using GamejamCheese.View;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Controller
{
	public static class SectionController
	{
		public static void StartSection (Section section)
		{
			HandleChoices(SectionView.ShowAndReturnChoice(section), section);
		}

		private static void HandleChoices (int choice, Section section) 
		{
			switch (choice)
			{
				case 1:
					//Implement section choice
					break;
				case 2:

					break;
				case 3:
					AnsiConsole.Clear();
					StartSection(section.Connections[0].NextSection);
					break;
				case 4:
					break;
			}
		}

		private static void MoveToSection(Section section)
		{

		}
	}
}
