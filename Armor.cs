using RPGHeroes;
using static Weapon;

public class Armor : Item
{
    public Item.slot Slot;
    public ArmorType Type;
 

    public Armor(string armorName, int requiredLevel, Item.slot slot, ArmorType armorType, HeroAttribute armorAttribute)
    {
        this.Name = armorName;
        this.RequiredLevel = requiredLevel;
        this.Slot = slot;
        this.Type = armorType;
        this.ArmorAttribute = armorAttribute;
    }
    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    };
 
}