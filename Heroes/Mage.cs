using RPGHeroes.Attributes;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

public class Mage : Hero
{   
    private int[] _levelUpAttributes = {1,1,5};
    private string[] _validWeapon = { "Staff", "Wand" };
    private string[] _validArmor = { "Cloth" };

    public Mage(string Name)
        :base (Name)
    {
        this.Name = Name;
        this.HeroAttributes = new HeroAttribute { strength = 1, dexterity = 1, intelligence = 8 };
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

    /// <summary>
    /// Method to Equip Hero with a weapon or throw InvalidWeaponException
    /// </summary>
    /// <param name="weapon"></param>
    public override void EquipWeapon(Weapon weapon)
    {
        if (!(this.ValidWeaponTypes.Contains(weapon.Type.ToString())))
            throw new InvalidWeaponException("The hero can't eqiup " + weapon.Type+" type weapon");
        else if (!(this.Level >= weapon.RequiredLevel))
            throw new InvalidWeaponException("The hero must have atleast " + weapon.RequiredLevel + " Level to aquire this armor");

        else
        {
            this.Equipments[Item.slot.Weapon] = weapon;
        }
    }

    /// <summary>
    /// Method to equip hero with a armor or throw InvalidArmorException
    /// </summary>
    /// <param name="armor"></param>
    public override void EquipArmor(Armor armor)
    {
        if (!(this.ValidArmorTypes.Contains(armor.Type.ToString())))
            throw new InvalidArmorException("The hero can't eqiup "+ armor.Type +" type armor");
        else if(!(this.Level >= armor.RequiredLevel))
            throw new InvalidArmorException("The hero must have atleast "+ armor.RequiredLevel +" Level to aquire this armor");
        else
        {
            this.Equipments[armor.Slot] = armor;
            this.Equipments[armor.Slot].ArmorAttribute.strength = armor.ArmorAttribute.strength;
            this.Equipments[armor.Slot].ArmorAttribute.dexterity = armor.ArmorAttribute.dexterity;
            this.Equipments[armor.Slot].ArmorAttribute.intelligence = armor.ArmorAttribute.intelligence;
        }
    }

    /// <summary>
    /// Method calculate & return total hero attributes.
    /// </summary>
    /// <returns></returns>

    public override HeroAttribute TotalAttributes()
    {
        // Get current values of Hero Attributes
        var totalAttributes = new HeroAttribute();
        totalAttributes.strength = this.HeroAttributes.strength;
        totalAttributes.dexterity = this.HeroAttributes.dexterity;
        totalAttributes.intelligence = this.HeroAttributes.intelligence;

        // Update HeroAttributes with values from Equipments
        foreach (var (key, val) in this.Equipments)
        {
            if ((key.ToString() != "Weapon") && !(val is null))
            {
                totalAttributes.strength = this.HeroAttributes.strength + val.ArmorAttribute.strength;
                totalAttributes.dexterity = this.HeroAttributes.dexterity + val.ArmorAttribute.dexterity;
                totalAttributes.intelligence = this.HeroAttributes.intelligence + val.ArmorAttribute.intelligence;
            }
        }
        return totalAttributes;
    }


    /// <summary>
    /// Method to calculate hero's damage attribute
    /// </summary>
    /// <returns></returns>
    public override decimal CalculateHeroDamage()
    {
         int weaponDamage = 1;
        decimal totalDamage;
        // Check if her has a weapon or not.
        if(!(this.Equipments[Item.slot.Weapon] is null))
            weaponDamage = this.Equipments[Item.slot.Weapon].WeaponDamage;
 
            totalDamage = weaponDamage * (1 + Decimal.Divide(GetDamagingAttribute(this) , 100));
            return totalDamage;
    }


    /// <summary>
    /// Display attributes of Hero.
    /// </summary>
    /// <returns></returns>

    public override StringBuilder Display()
    {
        var totalAttributes = this.TotalAttributes();
        var heroDamage = this.CalculateHeroDamage();
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine();
        stringBuilder.AppendLine("Name: "+ this.Name);
        stringBuilder.AppendLine("Class: "+ this.GetType().Name);
        stringBuilder.AppendLine("Total Strength: "+ totalAttributes.strength);
        stringBuilder.AppendLine("Total dexterity: "+ totalAttributes.dexterity);
        stringBuilder.AppendLine("Total Intelligence: "+ totalAttributes.intelligence);
        stringBuilder.AppendLine("Damage: "+ heroDamage);
        return stringBuilder;
    }



}