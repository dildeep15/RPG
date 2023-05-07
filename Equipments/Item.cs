using RPGHeroes;
using RPGHeroes.Attributes;

namespace RPGHeroes.Equipments;
public abstract class Item
{
    public string? Name;
    public int RequiredLevel;
    public int WeaponDamage;
    public LevelAttribute ArmorAttribute;

    /// <summary>
    /// Enumerator listing items to be equiped by hero
    /// </summary>
    public enum Slot
    {
        Weapon,
        Head,
        Body,
        Legs
    };

    /// <summary>
    /// <c>GetDefaultEquipments</c> method initialize Equipment with null/default value.
    /// </summary>
    /// <returns>Return list of equipments</returns>
    public  Dictionary<Item.Slot, Item?> GetDefaultEquipments()
    {
        var equipments = new Dictionary<Item.Slot, Item?>();
        equipments.Add(Item.Slot.Weapon, null);
        equipments.Add(Item.Slot.Body, null);
        equipments.Add(Item.Slot.Head, null);
        equipments.Add(Item.Slot.Legs, null);
        return equipments;
    }
}
