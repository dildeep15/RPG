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

    public void DefaultHeroAttribute(HeroAttribute heroAttribute, int strength, int dexterity, int intelligence)
    {
        heroAttribute.strength += strength;
        heroAttribute.dexterity += dexterity;
        heroAttribute.intelligence += intelligence;
    }

}