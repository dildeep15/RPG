using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    internal class HeroAttribute
    {
        private Dictionary<string, int> _attribute = new Dictionary<string, int>()
        {
            { "Strength", 0 },
            { "Dexterity", 0},
            { "Intelligence", 0 }
        };
        public Dictionary<string, int> Attribute { get; set; }
    }
}
