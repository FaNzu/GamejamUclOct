using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamejamCheese.Models
{
    public class Encounter
    {
        public EncounterType type { get; set; }
        public int HP { get; set; }
        public int O2 { get; set; }
        public Item Loot { get; set; }

        public Encounter(EncounterType type, int hP, int o2, Item loot)
        {
            this.type = type;
            HP = hP;
            O2 = o2;
            Loot = loot;
        }
    }
}
