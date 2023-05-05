
using RPGHeroes;
using System.Runtime.CompilerServices;
using System.Text;
/// <summary>
/// The base abstract Hero class to encapsulate all the shared functionality (fields and methods).
/// </summary>
abstract public class Hero : HeroAttribute
{
    public Hero(string name)
    {
        Name = name;
    }

    public string Name;
    public int Level = 1;
    public HeroAttribute HeroAttributes;
    public Dictionary<Item.slot, Item> Equipments = new Dictionary<Item.slot, Item>();
    public List<string> ValidWeaponTypes = new List<string>();
    public List<string> ValidArmorTypes = new List<string>();


    /// <summary>
    /// Method increase the level og character by 1 & corrresponding level attributes
    /// </summary>
    public abstract void LevelUp();
    public abstract void EquipWeapon(Weapon weapon);
    public abstract void EquipArmor(Armor armor);
    public abstract HeroAttribute TotalAttributes();
    public abstract decimal CalculateHeroDamage();
    public abstract StringBuilder Display();


    protected int GetDamagingAttribute(Hero obj)
    {
        int damagingAttribute = 0;
        var totalAttributes = obj.TotalAttributes();
        var typeofHero = obj.GetType().Name.ToLower();
        switch (typeofHero)
        {
            case "warrior":
                damagingAttribute = totalAttributes.strength;
                break;
            case "mage":
                damagingAttribute = totalAttributes.intelligence;
                break;
            case "ranger":
                damagingAttribute = totalAttributes.dexterity;
                break;
            case "rogue":
                damagingAttribute = totalAttributes.dexterity;
                break;
            default:
                throw new InvalidHeroTypeException("Invalid Hero Type");
        }
        return damagingAttribute;
    }

}