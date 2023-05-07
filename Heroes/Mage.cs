using RPGHeroes;
using RPGHeroes.Attributes;
using RPGHeroes.Equipments;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

public class Mage : Hero
{   
    private int[] _levelUpAttributes = {1,1,5};

    public Mage(string name, HeroTypes heroType)
        :base (name, heroType)
    {
        this.Name = Name;
        // Default hero attributes.
        this.HeroAttributes = new LevelAttribute (1, 1,8 );
        // Allowed weapon types for hero
        this.ValidWeaponTypes.Add(Weapon.WeaponType.Staff.ToString());
        this.ValidWeaponTypes.Add(Weapon.WeaponType.Wand.ToString());
        // Allowed armor types for her
        this.ValidArmorTypes.Add(Armor.ArmorType.Cloth.ToString());
    }

}