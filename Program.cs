using RPGHeroes.Attributes;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

internal partial class Program
{
    private static void Main(string[] args)
    {

        var mage = new Mage("New Mage Hero");
        Console.WriteLine("The name of mage Hero is: "+ mage.Name);
        Console.WriteLine("Strength: " + mage.HeroAttributes.strength);
        Console.WriteLine("Dexterity: " + mage.HeroAttributes.dexterity);
        Console.WriteLine("intelligence: " + mage.HeroAttributes.intelligence);
        foreach (var item in mage.ValidWeaponTypes)
        {
            Console.WriteLine("Valid weaponType: "+ item);
        }
        Console.WriteLine("--------------------------------------");
        mage.LevelUp();
        Console.WriteLine("Strength (After level up): " + mage.HeroAttributes.strength);
        Console.WriteLine("Dexterity (After level up): " + mage.HeroAttributes.dexterity);
        Console.WriteLine("intelligence (After level up): " + mage.HeroAttributes.intelligence);


        //var weapon1 = new Weapon("First Axe", 1, Weapon.WeaponType.Axe, 2);
        //Console.WriteLine("Name: "+ weapon1.Name);
        //Console.WriteLine("Required Level: "+ weapon1.RequiredLevel);
        //Console.WriteLine("Type: "+ weapon1.Type);
        //mage.EquipWeapon(weapon1);

        var weapon2 = new Weapon("Staff", 1, Weapon.WeaponType.Staff, 2);
        Console.WriteLine("Name: " + weapon2.Name);
        Console.WriteLine("Required Level: " + weapon2.RequiredLevel);
        Console.WriteLine("Type: " + weapon2.Type);
        Console.WriteLine("Try to equip a weapon");
        mage.EquipWeapon(weapon2);


        Console.WriteLine("Try to equip an armor");
        HeroAttribute armorattribute = new HeroAttribute { strength = 12, dexterity = 1, intelligence = 1 };

        var armor1 = new Armor("Common Cloth Chest", 1, Item.slot.Body, Armor.ArmorType.Cloth, armorattribute);
        Console.WriteLine("Armor Name: " +armor1.Name);
        Console.WriteLine("Armor Slot: " +armor1.Slot);
        Console.WriteLine("Armor Type: " +armor1.Type);
        //mage.EquipArmor(armor1);

        var herototalAttributes  = mage.TotalAttributes();
        Console.WriteLine("Total Strength: " + herototalAttributes.strength);
        Console.WriteLine("Total Dexterity: " + herototalAttributes.dexterity);
        Console.WriteLine("Total intelligence: " + herototalAttributes.intelligence);

        Console.WriteLine("The value of total Hero damage is : "+  mage.CalculateHeroDamage());
        Console.WriteLine(mage.Display());

    }



}
