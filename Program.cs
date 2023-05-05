using RPGHeroes;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

internal partial class Program
{
    private static void Main(string[] args)
    {
        //var list = new List<KeyValuePair<string, int>>();
        //list.Add(new KeyValuePair<string, int>("Cat", 1));
        //list.Add(new KeyValuePair<string, int>("Billli", 1));
        //list.Add(new KeyValuePair<string, int>("Kutta", 1));

        //Console.WriteLine("Values of list is :"+ String.Join(":", list ));

        //IDictionary<int, string> numberNames = new Dictionary<int, string>();
        //numberNames.Add(1, "One"); //adding a key/value using the Add() method
        //numberNames.Add(2, "Two");
        //numberNames.Add(3, "Three");
        //foreach (KeyValuePair<int, string> kvp in numberNames)
        //    Console.WriteLine(kvp.Key+":"+kvp.Value);
        //Console.WriteLine("numberNames.ToString(): "+ numberNames.ToString()) ;
        //Console.WriteLine("Values of dictionary is :" + String.Join(":", numberNames))


        var mage = new Mage("New Mage Hero");
        Console.WriteLine("The name of mage Hero is: "+ mage.Name);
        Console.WriteLine("Strength: " + mage.HeroAttributes.strength);
        Console.WriteLine("Dexterity: " + mage.HeroAttributes.dexterity);
        Console.WriteLine("intelligence: " + mage.HeroAttributes.intelligence);
        foreach (var item in mage.ValidWeaponTypes)
        {
            Console.WriteLine("Valid weaponType: "+ item);
        }
        mage.LevelUp();
        Console.WriteLine("Test this "+ String.Concat(":", mage.HeroAttributes));
        Console.WriteLine("Strength: " + mage.HeroAttributes.strength);
        Console.WriteLine("Dexterity: " + mage.HeroAttributes.dexterity);
        Console.WriteLine("intelligence: " + mage.HeroAttributes.intelligence);

        // Create object of weapon class
        //var weaponObj = new CreateWeapon("First Axe", 1, "Axe", 2);
        var weapon1 = new Weapon("First Axe", 1, Weapon.WeaponType.Axe, 2);
        Console.WriteLine("Name: "+ weapon1.Name);
        Console.WriteLine("Required Level: "+ weapon1.RequiredLevel);
        Console.WriteLine("Type: "+ weapon1.Type);

        var weapon2 = new Weapon("Staff", 1, Weapon.WeaponType.Staff, 1);
        Console.WriteLine("Name: " + weapon2.Name);
        Console.WriteLine("Required Level: " + weapon2.RequiredLevel);
        Console.WriteLine("Type: " + weapon2.Type);

        Console.WriteLine("Try to equip a weapon");
        //mage.EquipWeapon(weapon1);
        mage.EquipWeapon(weapon2);


        Console.WriteLine("Try to equip an armor");
        HeroAttribute armorattribute = new HeroAttribute { strength = 12, dexterity = 1, intelligence = 1 };
        //string combinedAttributes = "strength:" + armorattribute.strength + ",";
        //combinedAttributes += "dexterity:" + armorattribute.dexterity + ",";
        //combinedAttributes += "intelligence:" + armorattribute.intelligence ;
        //Console.WriteLine("combinedAttributes=" + combinedAttributes);

        var armor1 = new Armor("Common Cloth Chest", 1, Item.slot.Body, Armor.ArmorType.Cloth, armorattribute);
        Console.WriteLine("Armor Name: " +armor1.Name);
        Console.WriteLine("Armor Slot: " +armor1.Slot);
        Console.WriteLine("Armor Type: " +armor1.Type);
        mage.EquipArmor(armor1);

        var herototalAttributes  = mage.TotalAttributes();
        Console.WriteLine("Strength: " + herototalAttributes.strength);
        Console.WriteLine("Dexterity: " + herototalAttributes.dexterity);
        Console.WriteLine("intelligence: " + herototalAttributes.intelligence);
        Console.ReadKey();
    }



}
