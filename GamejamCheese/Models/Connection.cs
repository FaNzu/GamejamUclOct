using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Models
{
	public class Connection
	{
		public Section NextSection { get; set; }
		public Section LastSection { get; set; }
		public bool IsVisible { get; set; }


		public Connection() { }

		public Connection(Section nextSection, bool isVisible)
		{
			NextSection = nextSection;
			IsVisible = isVisible;
		}
		public override string ToString()
		{
			return $"{NextSection.Name}";
		}
	}
}
