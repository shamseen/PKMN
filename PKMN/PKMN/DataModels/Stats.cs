using System;
using System.Collections.Generic;
using System.Text;

namespace PKMN.DataModels
{
    public class Stats
    {
        public int HP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int SP_ATK { get; set; }
        public int SP_DEF { get; set; }
        public int ACC { get; set; }
        public int EXP { get; set; }
        public int LEVEL { get; set; }
    }

    public class Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public enum Type
    {
        NORMAL,
        FIRE,
        WATER,
        ELECTRIC,
        GRASS,
        ICE,
        FIGHTING,
        POISON,
        GROUND,
        FLYING,
        PSYCHIC,
        BUG,
        ROCK,
        GHOST,
        DRAGON,
        DARK,
        STEEL
    }
}
