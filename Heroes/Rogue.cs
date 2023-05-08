using RPGHeroes;
using RPGHeroes.Attributes;
using RPGHeroes.Equipments;

public class Rogue : Hero
{   
    public Rogue(string name)
        :base (name, HeroTypes.Rogue)
    {
        this.Name = name;
        // Default hero attributes.
        this.HeroAttributes = new LevelAttribute (2, 6, 1);
        // Allowed weapon types for hero
        this.ValidWeaponTypes.Add(Weapon.WeaponType.Dagger.ToString());
        this.ValidWeaponTypes.Add(Weapon.WeaponType.Sword.ToString());
        // Allowed armor types for her
        this.ValidArmorTypes.Add(Armor.ArmorType.Leather.ToString());
        this.ValidArmorTypes.Add(Armor.ArmorType.Mail.ToString());
    }

}