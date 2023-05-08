using RPGHeroes;
using RPGHeroes.Attributes;
using RPGHeroes.Equipments;

public class Mage : Hero
{   
    public Mage(string name)
        :base (name, HeroTypes.Mage)
    {
        this.Name = name;
        // Default hero attributes.
        this.HeroAttributes = new LevelAttribute (1, 1,8 );
        // Allowed weapon types for hero
        this.ValidWeaponTypes.Add(Weapon.WeaponType.Staff.ToString());
        this.ValidWeaponTypes.Add(Weapon.WeaponType.Wand.ToString());
        // Allowed armor types for her
        this.ValidArmorTypes.Add(Armor.ArmorType.Cloth.ToString());
    }

}