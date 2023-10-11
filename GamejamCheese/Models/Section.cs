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
		public List<string> Choice { get; set; }
		//choice en klasse med muligheder?
		public List<Connection> Connections { get; set; }
		public Modifier Modifier { get; set; }

		public Section(string name, string description, List<string> choice, List<Connection> connections, Modifier modifier)
		{
			Name = name;
			Description = description;
			Choice = choice;
			Connections = connections;
			Modifier = modifier;
		}
	}
}
