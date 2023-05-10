using RPGHeroes;
using RPGHeroes.Attributes;
using RPGHeroes.Equipments;

public class Warrior : Hero
{   
    public Warrior(string name)
        :base (name, HeroTypes.Warrior)
    {
        this.Name = name;
        // Default hero attributes.
        this.HeroAttributes = new LevelAttribute (5, 2, 1);
        // Allowed weapon types for hero
        this.ValidWeaponTypes.Add(Weapon.WeaponType.Axe.ToString());
        this.ValidWeaponTypes.Add(Weapon.WeaponType.Hammer.ToString());
        this.ValidWeaponTypes.Add(Weapon.WeaponType.Sword.ToString());
        // Allowed armor types for her
        this.ValidArmorTypes.Add(Armor.ArmorType.Mail.ToString());
        this.ValidArmorTypes.Add(Armor.ArmorType.Plate.ToString());
    }

}