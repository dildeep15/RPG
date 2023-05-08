using static RPGHeroes.Hero;

namespace RPGHeroes.Attributes
{
    public class LevelAttribute
    {
        public int Strength;
        public int Dexterity;
        public int Intelligence;
        public HeroTypes TypeOfHero;


        public LevelAttribute( int strength = 0, int dexterity = 0, int intelligence = 0 )
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }


        /// <summary>
        /// <c>GetDefaultAttributes</c> create default attributes for provided type of hero.
        /// </summary>
        /// <param name="type">HeroType</param>
        /// <returns>Return LevelAttribute of Hero(Strength, Dexterity, Intelligence)</returns>
        /// <exception cref="InvalidHeroTypeException"></exception>
        public LevelAttribute GetDefaultAttributes(HeroTypes type)
        {
            LevelAttribute defaultAttributes;
            if (type == HeroTypes.Mage)
                defaultAttributes = new LevelAttribute { Strength = 1, Dexterity = 1, Intelligence = 8 };
            else if (type == HeroTypes.Ranger)
                defaultAttributes = new LevelAttribute { Strength = 1, Dexterity = 7, Intelligence = 1 };
            else if (type == HeroTypes.Rogue)
                defaultAttributes = new LevelAttribute { Strength = 2, Dexterity = 6, Intelligence = 1 };
            else if (type == HeroTypes.Warrior)
                defaultAttributes = new LevelAttribute { Strength = 5, Dexterity = 2, Intelligence = 1 };
            else
                throw new InvalidHeroTypeException(type+" of hero is not valid");

            return defaultAttributes;
        }


        /// <summary>
        /// <c>GetLevelUpAttribute</c> method return levelup attributes of a specific type hero.
        /// </summary>
        /// <param name="type">HeroType</param>
        /// <returns>Return levelup attributes as LevelAttribute</returns>
        /// <exception cref="InvalidHeroTypeException"></exception>
        public LevelAttribute GetLevelUpAttribute(HeroTypes type)
        {
            LevelAttribute levelUpAttributes;
            if (type == HeroTypes.Mage)
                levelUpAttributes = new LevelAttribute { Strength = 1, Dexterity = 1, Intelligence = 5 };
            else if (type == HeroTypes.Ranger)
                levelUpAttributes = new LevelAttribute { Strength = 1, Dexterity = 5, Intelligence = 1 };
            else if (type == HeroTypes.Rogue)
                levelUpAttributes = new LevelAttribute { Strength = 1, Dexterity = 4, Intelligence = 1 };
            else if (type == HeroTypes.Warrior)
                levelUpAttributes = new LevelAttribute { Strength = 3, Dexterity = 2, Intelligence = 1 };
            else
                throw new InvalidHeroTypeException(type + " of hero is not valid");

            return levelUpAttributes;
        }


        /// <summary>
        /// <c>AddAttributes</c> add two level attributes
        /// </summary>
        /// <param name="LevelAttribute"></param>
        /// <param name="LevelAttribute"></param>
        /// <returns>Return updated first parameter as LevelAttribute</returns>
        public static LevelAttribute AddAttributes(LevelAttribute left, LevelAttribute right)
        {
            left.Strength += right.Strength;
            left.Dexterity += right.Dexterity;
            left.Intelligence += right.Intelligence;
            return left;
        }
    }
}
