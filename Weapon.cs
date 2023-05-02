public class Weapon : Item
{
    public Weapon(string weaponName)
    {
        // Implementation when a new Weapon is created.
        this.Name = weaponName;
    }
    public enum WeaponType
    {
        Axes,
        Bows,
        Daggers,
        Hammers,
        Staffs,
        Swords,
        Wands
    };
    public int WeaponDamage;
}