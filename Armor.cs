using RPGHeroes;

public class Armor : Item
{
    public Armor(string armorName)
    {
        this.Name = armorName;
    }
    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    };
    public HeroAttribute ArmorAttribute;
}