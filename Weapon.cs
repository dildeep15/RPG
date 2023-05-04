public class Weapon : Item
{ 
    public int WeaponDamage;
    public string Slot = "Weapon";
    public WeaponType Type;
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

    public Weapon(string weaponName, int requiredLevel, WeaponType weaponType, int weaponDamage)
    {
        this.Name = weaponName;
        this.RequiredLevel = requiredLevel;
        this.Type = weaponType;
        this.WeaponDamage = weaponDamage;
    }

 
}