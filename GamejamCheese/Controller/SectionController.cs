using GamejamCheese.Models;
using GamejamCheese.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Controller
{
	public static class SectionController
	{
		public static void NewSection (Section section)
		{
			SectionView.Show(section);
		}



	}
}
