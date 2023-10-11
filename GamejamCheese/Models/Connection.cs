using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Models
{
	public class Connection
	{
		public string Description { get; set; }
		public Section NextSection { get; set; }
		public Section LastSection { get; set; }
		public bool IsVisible { get; set; }


		public Connection() { }

		public Connection(string description, Section nextSection, bool isVisible)
		{
			Description = description;
			NextSection = nextSection;
			IsVisible = isVisible;
		}
	}
}
