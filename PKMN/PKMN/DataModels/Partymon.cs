using System;
using System.Collections.Generic;
using System.Text;

namespace PKMN.DataModels
{
    public class Partymon
    {
        public Pokemon Pokemon { get; set; }
        public string Nickname { get; set; }
        public Stats Stats { get; set; }
        public Stats IV { get; set; }
        public Stats EV { get; set; }
        public string Notes { get; set; }
        public bool IsOut { get; set; }

        public Partymon(string n="")
        {
            Nickname = n == "" ? Pokemon.Name : n;
        }
    }
}
