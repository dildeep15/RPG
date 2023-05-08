using System.Text;
using RPGHeroes.Attributes;
using RPGHeroes.Equipments;

namespace RPGHeroes;

/// <summary>
/// The base abstract Hero class to encapsulate all the shared functionality (fields and methods).
/// </summary>
abstract public class Hero : LevelAttribute
{
    public string Name;
    public HeroTypes HeroType;
    public int Level = 1;
    public LevelAttribute HeroAttributes;
    public LevelAttribute LevelUpAttributes;
    public readonly List<string> ValidWeaponTypes = new List<string>();
    public readonly List<string> ValidArmorTypes = new List<string>();
    public Dictionary<Item.Slot, Item?> Equipments { get; } = new()
    {
        {Item.Slot.Weapon, null},
        {Item.Slot.Head, null},
        {Item.Slot.Body, null},
        {Item.Slot.Legs, null}
    };

    public enum HeroTypes
    {
        Mage,
        Ranger,
        Rogue,
        Warrior
    };
    public Hero(string name, HeroTypes type)
    {
        this.Name = name;
        this.HeroType = type;
        this.HeroAttributes = GetDefaultAttributes(this.HeroType);
        this.LevelUpAttributes = GetLevelUpAttribute(this.HeroType);
    }


    /// <summary>
    /// Method increase the level og character by 1 & corrresponding level attributes
    /// </summary>
    public void LevelUp()
    {
        // Increase level of hero by 1.
        this.Level++;
        AddAttributes(this.HeroAttributes, this.LevelUpAttributes);
    }


    /// <summary>
    /// <c>TotalAttributes</c> method return total of heroattributes & attributes from 
    /// armor type equipments.
    /// </summary>
    /// <returns>Return total of attributes of hero in <c>LevelAttribute</c> format</returns>
    public LevelAttribute TotalAttributes()
    {
        // Create an empty level attribute.
        LevelAttribute totalAttributes = new LevelAttribute();
        // Assign current values of heroattributes to it.
        totalAttributes.Strength = this.HeroAttributes.Strength;
        totalAttributes.Dexterity = this.HeroAttributes.Dexterity;
        totalAttributes.Intelligence = this.HeroAttributes.Intelligence;

       // Check & iterate in Equipments to finds attributes in all armor type.
        foreach (var (key, val) in this.Equipments)
        {
            if ((key.ToString() != "Weapon") && !(val is null))
            {
                totalAttributes = AddAttributes(totalAttributes, val.ArmorAttribute);
            }
        }
        return totalAttributes;
    }

    /// <summary>
    /// <c>EquipWeapon</c> equip Hero with a weapon or throw InvalidWeaponException
    /// </summary>
    /// <param name="weapon"></param>
    /// <returns>Return confirmation that the weapon is equipped</returns>
    /// <exception cref="InvalidWeaponException"></exception>
    public string EquipWeapon(Weapon weapon)
    {
        if (!(this.ValidWeaponTypes.Contains(weapon.Type.ToString())))
            throw new InvalidWeaponException("The hero can't eqiup " + weapon.Type + " type weapon");
        else if (!(this.Level >= weapon.RequiredLevel))
            throw new InvalidWeaponException("The hero must have atleast " + weapon.RequiredLevel + " Level to aquire "+weapon.Name);

        else
        {
            this.Equipments[Item.Slot.Weapon] = weapon;
            return "The hero is equiped with "+weapon.Name +" Weapon";
        }
    }

    /// <summary>
    /// <c>CalculateHeroDamage</c> calculate hero's damage attribute
    /// </summary>
    /// <returns>Return weapon damage of hero in <c>decimal</c></returns>
    public decimal CalculateHeroDamage()
    {
        decimal weaponDamage = 1;
        decimal totalDamage;
        // Check if hero has a weapon or not.
        if (this.Equipments[Item.Slot.Weapon] is not null)
            weaponDamage = this.Equipments[Item.Slot.Weapon]!.WeaponDamage;

        totalDamage = weaponDamage * (1 + (decimal)GetDamagingAttribute()/100);
        return totalDamage;
    }

    /// <summary>
    /// <c>EquipArmor</c> to equip hero with a armor or throw InvalidArmorException
    /// </summary>
    /// <param name="armor">ArmorAttribute</param>
    public void EquipArmor(Armor armor)
    {
        if (!(this.ValidArmorTypes.Contains(armor.Type.ToString())))
            throw new InvalidArmorException("The " + this.GetType().Name + " hero can't equip " + armor.Type + " type armor");
        else if (!(this.Level >= armor.RequiredLevel))
            throw new InvalidArmorException("The " + this.GetType().Name + " hero must have atleast " + armor.RequiredLevel + " Level to aquire this armor");
        else
        {
            this.Equipments[armor.Slot] = armor;
        }
    }

    /// <summary>
    /// <c>Display</c> method display information about hero.
    /// </summary>
    /// <returns>Returns details of hero in <c>StringBuilder</c> format</returns>
    public StringBuilder Display()
    {
        var totalAttributes = this.TotalAttributes();
        var heroDamage = this.CalculateHeroDamage();
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine();
        stringBuilder.AppendLine("Name: " + this.Name);
        stringBuilder.AppendLine("Class: " + this.GetType().Name);
        stringBuilder.AppendLine("Total Strength: " + totalAttributes.Strength);
        stringBuilder.AppendLine("Total dexterity: " + totalAttributes.Dexterity);
        stringBuilder.AppendLine("Total Intelligence: " + totalAttributes.Intelligence);
        stringBuilder.AppendLine("Damage: " + heroDamage);
        return stringBuilder;
    }


    /// <summary>
    /// <c>GetDamagingAttribute</c> return damaging attributes for a specifice hero type.
    /// </summary>
    /// <param name="Hero Object">Hero Object</param>
    /// <returns>Damaging attribute of hero</returns>
    /// <exception cref="InvalidHeroTypeException"></exception>
    protected int GetDamagingAttribute()
    {
        int damagingAttribute = 0;
        var totalAttributes = this.TotalAttributes();
        var typeofHero = this.HeroType.ToString().ToLower();
        switch (typeofHero)
        {
            case "warrior":
                damagingAttribute = totalAttributes.Strength;
                break;
            case "mage":
                damagingAttribute = totalAttributes.Intelligence;
                break;
            case "ranger":
                damagingAttribute = totalAttributes.Dexterity;
                break;
            case "rogue":
                damagingAttribute = totalAttributes.Dexterity;
                break;
            default:
                throw new InvalidHeroTypeException("Invalid Hero Type");
        }
        return damagingAttribute;
    }

}