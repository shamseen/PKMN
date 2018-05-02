using System;
using System.Collections.Generic;
using System.Text;

namespace PKMN.DataModels
{
    public class Pokemon
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Pokemon> Evolutions { get; set; }
        public Stats EV_Yield { get; set; }
        public Stats BaseStats { get; set; }
        public Type Type1 { get; set; }
        public Type Type2 { get; set; }
        public Attribute Attribute { get; set; }
        //location, moveset
    }
}
