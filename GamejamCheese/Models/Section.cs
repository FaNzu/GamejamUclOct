using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Models
{
	public class Section
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Choice { get; set; }
		//choice en klasse med muligheder?
		public List<Connection> Connections { get; set; }
		public Modifier Modifier { get; set; }
		public string? ImagePath { get; set; }

		public Section(string name, string description, string choice, Modifier modifier)
		{
			Name = name;
			Description = description;
			Choice = choice;
			Modifier = modifier;
			Connections = new List<Connection>();
		}
	}
}
