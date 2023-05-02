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


    public static Dictionary<string, string> GetDefaultEquipments()
    {
        var equipments = new Dictionary<string, string>();
        foreach (var item in Enum.GetNames(typeof(slot)))
        {
            equipments[item] = null;
        }
        return equipments;
    }
}
