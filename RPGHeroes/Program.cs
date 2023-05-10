using RPGHeroes;
using RPGHeroes.Attributes;
using RPGHeroes.Equipments;

internal partial class Program
{
    private static void Main(string[] args)
    {

        // Creata new Mage type hero & Display
        string mageName = "MageName";
        Hero mageHero = new Mage(mageName);
        Console.WriteLine(mageHero.Display());

        // Creata new Ranger type hero & Display
        string rangerName = "RangerName";
        Hero rangerHero = new Ranger(rangerName);
        Console.WriteLine(rangerHero.Display());

        // Creata new Rogue type hero & Display
        string rogueName = "RogueName";
        Hero rogueHero = new Rogue(rogueName);
        Console.WriteLine(rogueHero.Display());

        // Creata new Warrior type hero & Display
        string heroName = "WarriorName";
        Hero warriorHero = new Warrior(heroName);
        Console.WriteLine(warriorHero.Display());

        // Level Up code;
        mageHero.LevelUp();
        Console.WriteLine(mageHero.HeroType + " After level Up");
        Console.WriteLine(mageHero.Display());

        // Level Up code;
        rangerHero.LevelUp();
        Console.WriteLine(rangerHero.HeroType + " After level Up");
        Console.WriteLine(rangerHero.Display());

        // Level Up code;
        rogueHero.LevelUp();
        Console.WriteLine(rogueHero.HeroType + " After level Up");
        Console.WriteLine(rogueHero.Display());

        // Level Up code;
        warriorHero.LevelUp();
        Console.WriteLine(warriorHero.HeroType + " After level Up");
        Console.WriteLine(warriorHero.Display());

        // Equip a Weapon;
        var weaponStaff = new Weapon("Staff Weapon", 2, Weapon.WeaponType.Staff, 2);
        mageHero.EquipWeapon(weaponStaff);

        // Equip an Armor
        LevelAttribute armorattribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 5 };
        var armor1 = new Armor("Common Cloth Chest", 1, Item.Slot.Body, Armor.ArmorType.Cloth, armorattribute);
        mageHero.EquipArmor(armor1);

        Console.WriteLine(mageHero.Name+" After equipping a weapon & an armor");
        Console.WriteLine(mageHero.Display());
    }



}
