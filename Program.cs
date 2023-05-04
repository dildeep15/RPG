using RPGHeroes;
using System.Security.Cryptography.X509Certificates;
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
        mage.LevelUp();
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
        var armorattribute = new HeroAttribute();
        armorattribute.strength = 1;
        armorattribute.dexterity = 1;
        armorattribute.intelligence = 1;

        var armor1 = new Armor("Common Cloth Chest", 1, Item.slot.Body, Armor.ArmorType.Cloth, armorattribute);
        Console.WriteLine("Armor Name: " +armor1.Name);
        Console.WriteLine("Armor Slot: " +armor1.Slot);
        Console.WriteLine("Armor Type: " +armor1.Type);
        mage.EquipArmor(armor1);

        foreach (var val in mage.Equipments)
        { 
            Console.WriteLine("Value of Equipments: "+val);
        }



        Console.ReadKey();
    }



}
