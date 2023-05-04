using RPGHeroes;
using System.Reflection.Metadata.Ecma335;

public class Mage : Hero
{   
    private int[] _defaultAttributes = {1,1,8};
    private int[] _levelUpAttributes = {1,1,5};
    private string[] _validWeapon = { "Staff", "Wand" };
    private string[] _validArmor = { "Cloth" };
   

    public Mage(string Name)
        :base (Name)
    {
        this.Name = Name;
        DefaultHeroAttribute(this.HeroAttributes ,1, 1, 8);
        this.Equipments = Item.GetDefaultEquipments();
        this.ValidWeaponTypes.AddRange(_validWeapon);
        this.ValidArmorTypes.AddRange(_validArmor);
    }

    public override void LevelUp()
    {
        this.Level += Level;
        this.HeroAttributes.strength += _levelUpAttributes[0];
        this.HeroAttributes.dexterity += _levelUpAttributes[1];
        this.HeroAttributes.intelligence += _levelUpAttributes[2];

    }

    private void DefaultHeroAttribute(HeroAttribute heroAttribute, int strength, int dexterity, int intelligence)
    {
        heroAttribute.strength += strength;
        heroAttribute.dexterity += dexterity;
        heroAttribute.intelligence += intelligence;
    }

    /// <summary>
    /// Method to Equip Hero with a weapon or throw exception in case of invalid weapon type
    /// </summary>
    /// <param name="weapon"></param>
    public override void EquipWeapon(Weapon weapon)
    {

    }



}