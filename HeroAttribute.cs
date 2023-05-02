using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public  class HeroAttribute
    {
        public int strength;
        public int dexterity;
        public int intelligence;
        public static HeroAttribute GetHeroAttributes()
        {
            var Attributeobj = new HeroAttribute();
            return Attributeobj;
        }

        /// <summary>
        /// Method increase Attribute of Hero
        /// </summary>
        /// <param name="heroAttribute"></param>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="intelligence"></param>
        public void UpdateHeroAttribute(HeroAttribute heroAttribute, int strength, int dexterity, int intelligence)
        {
            heroAttribute.strength += strength;
            heroAttribute.dexterity += dexterity;
            heroAttribute.intelligence += intelligence;
        }
    }
}
