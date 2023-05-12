using RPGHeroes;
using RPGHeroes.Attributes;

namespace RPGHeroes.Equipments;
public class Armor : Item
{
    public Item.Slot Slot;
    public ArmorType Type;
 
    public Armor(string armorName, int requiredLevel, Item.Slot slot, ArmorType armorType, LevelAttribute armorAttribute)
    {
        this.Name = armorName;
        this.RequiredLevel = requiredLevel;
        this.Slot = slot;
        this.Type = armorType;
        this.ArmorAttribute = armorAttribute;
    }

    /// <summary>
    /// List of armor types
    /// </summary>
    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    };
 
}