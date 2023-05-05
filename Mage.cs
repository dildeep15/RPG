using RPGHeroes;
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


    public override decimal CalculateHeroDamage()
    {
        //Hero damage = WeaponDamage * (1 + DamagingAttribute / 100)
        int weaponDamage = 1;
        decimal totalDamage;
        // Check if her has a weapon or not.
        if(!(this.Equipments[Item.slot.Weapon] is null))
            weaponDamage = this.Equipments[Item.slot.Weapon].WeaponDamage;
 
            totalDamage = weaponDamage * (1 + Decimal.Divide(GetDamagingAttribute(this) , 100));
        return totalDamage;

    }

    private int GetDamagingAttribute(Hero obj)
    {
        int damagingAttribute = 0;
        var totalAttributes = obj.TotalAttributes();
        var typeofHero = obj.GetType().Name.ToLower();
        switch(typeofHero)
        {
            case "warrior":
                damagingAttribute = totalAttributes.strength;
                break;
            case "mage":
                damagingAttribute = totalAttributes.intelligence;
                Console.WriteLine("In right switch case: "+ totalAttributes.intelligence);
                break;
            case "ranger":
                damagingAttribute = totalAttributes.dexterity;
                break;
            case "rogue":
                damagingAttribute = totalAttributes.dexterity;
                break;
            default:
                throw new InvalidHeroTypeException("Invalid Hero Type");
        }
        return damagingAttribute;
    }


}