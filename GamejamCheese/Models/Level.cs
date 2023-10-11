using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Models
{
	public class Level
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public List<Section> Sections { get; set; }

		public Level(string name, string description, List<Section> sections) 
		{
			Name = name;
			Description = description;
			Sections = sections;
		}
	}
}
