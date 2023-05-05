
using RPGHeroes;
using System.Runtime.CompilerServices;
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
    public HeroAttribute HeroAttributes = new HeroAttribute();
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

}