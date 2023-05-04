﻿using RPGHeroes;
using System.Linq.Expressions;
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
            this.Equipments[Item.slot.Weapon] = weapon.Name;
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
            this.Equipments[armor.Slot] = armor.Name;
    }

}