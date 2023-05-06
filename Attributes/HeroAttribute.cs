using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Attributes
{
    public class HeroAttribute
    {
        public int strength = 0;
        public int dexterity = 0;
        public int intelligence = 0;
        public static HeroAttribute getheroattributes()
        {
            var attributeobj = new HeroAttribute();
            return attributeobj;
        }
    }
}
