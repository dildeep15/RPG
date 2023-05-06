using RPGHeroes.Attributes;

public abstract class Item
{
    public string Name;
    public int RequiredLevel;
    public int WeaponDamage;
    public HeroAttribute ArmorAttribute;

    public enum slot
    {
        Weapon,
        Head,
        Body,
        Legs
    };


    public static Dictionary<Item.slot, Item> GetDefaultEquipments()
    {
        var equipments = new Dictionary<Item.slot, Item>();
        equipments.Add(Item.slot.Weapon, default);
        equipments.Add(Item.slot.Body, default);
        equipments.Add(Item.slot.Head, default);
        equipments.Add(Item.slot.Legs, default);
        return equipments;
    }
}
