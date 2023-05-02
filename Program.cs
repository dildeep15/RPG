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

        mage.UpdateHeroAttribute(mage.HeroAttributes, 1, 3, 5);
        Console.WriteLine("Strength: " + mage.HeroAttributes.strength);
        Console.WriteLine("Dexterity: " + mage.HeroAttributes.dexterity);
        Console.WriteLine("intelligence: " + mage.HeroAttributes.intelligence);

        Console.ReadKey();
    }


}
