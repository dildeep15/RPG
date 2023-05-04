public abstract class Item
{
    public string Name;
    public int RequiredLevel;
    public enum slot
    {
        Weapon,
        Head,
        Body,
        Legs
    };


    public static Dictionary<Item.slot, string> GetDefaultEquipments()
    {
        var equipments = new Dictionary<Item.slot, string>();
        equipments.Add(Item.slot.Weapon, null);
        equipments.Add(Item.slot.Body, null);
        equipments.Add(Item.slot.Head, null);
        equipments.Add(Item.slot.Legs, null);
        return equipments;
    }
}
