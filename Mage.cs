using RPGHeroes;
using System.Reflection.Metadata.Ecma335;

public class Mage : Hero
{
    private string _name { get; set; }
    private int _level = 1;
    //private int[] _levelUpValues = new int[3] { 1, 1, 5};
    private Dictionary<string, int> _heroAttributes = new HeroAttribute().Attribute;


    public Mage(string Name)
        :base (Name)
    {
        _name = Name;
        _heroAttributes = UpdateHeroAttribute(1, 1, 8);
    }

    /// <summary>
    /// Method return level up attributes for Hero with agrument provided (strength, dexterity, intelligence)
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, int> UpdateHeroAttribute(int strength, int dexterity, int intelligence)
    {

        this._heroAttributes["Strength"]    = strength; 
        this._heroAttributes["Dexterity"]   = dexterity; 
        this._heroAttributes["Intelligence"]= intelligence;
        return this._heroAttributes;
    }


}