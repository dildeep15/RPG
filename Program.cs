using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using RPGHeroes;
using RPGHeroes.Attributes;
using RPGHeroes.Equipments;
using static System.Net.Mime.MediaTypeNames;

internal partial class Program
{
    private static void Main(string[] args)
    {

        // Creata new hero of type Mage.
        var heroType = Hero.HeroTypes.Mage;
        Console.WriteLine("The value of herotype is: " + heroType);
        var mageHero = new Mage("Mage Hero", heroType);
        Console.WriteLine(mageHero.Display());

        // Level Up code;
        mageHero.LevelUp();
        Console.WriteLine("Update informationa after level up");
        Console.WriteLine(mageHero.Display());

        // Equip a Weapon;
        var weaponStaff = new Weapon("Staff Weapon", 2, Weapon.WeaponType.Staff, 2);
        Console.WriteLine("Name: "+ weaponStaff.Name);
        Console.WriteLine("Required Level: "+ weaponStaff.RequiredLevel);
        Console.WriteLine("Type: "+ weaponStaff.Type);
        mageHero.EquipWeapon(weaponStaff);
        Console.WriteLine("Information after weapon equipment");
        Console.WriteLine(mageHero.Display());

        // Equip an Armor
        Console.WriteLine("Try to equip an armor");
        LevelAttribute armorattribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };

        var armor1 = new Armor("Common Cloth Chest", 1, Item.Slot.Body, Armor.ArmorType.Cloth, armorattribute);
        Console.WriteLine("Armor Name: " + armor1.Name);
        Console.WriteLine("Armor Slot: " + armor1.Slot);
        Console.WriteLine("Armor Type: " + armor1.Type);
        mageHero.EquipArmor(armor1);
        Console.WriteLine("Information after aquiring an armor");
        Console.WriteLine(mageHero.Display());
    }



}
