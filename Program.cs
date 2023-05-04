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
        var weapon1 = new Weapon("First Axe", 1, Weapon.WeaponType.Axes, 2);
        Console.WriteLine("Name: "+ weapon1.Name);
        Console.WriteLine("Required Level: "+ weapon1.RequiredLevel);
        Console.WriteLine("Type: "+ weapon1.Type);



        Console.ReadKey();
    }



}
