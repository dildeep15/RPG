using RPGHeroes;
using RPGHeroes.Attributes;
using RPGHeroes.Equipments;

public class Ranger : Hero
{   
    public Ranger(string name)
        :base (name, HeroTypes.Ranger)
    {
        this.Name = name;
        // Default hero attributes.
        this.HeroAttributes = new LevelAttribute (1, 7, 1);
        // Allowed weapon types for hero
        this.ValidWeaponTypes.Add(Weapon.WeaponType.Bow.ToString());
        // Allowed armor types for her
        this.ValidArmorTypes.Add(Armor.ArmorType.Leather.ToString());
        this.ValidArmorTypes.Add(Armor.ArmorType.Mail.ToString());
    }
}