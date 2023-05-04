public class Weapon : Item
{ 
    public int WeaponDamage;
    public Item.slot Slot = Item.slot.Weapon;
    public WeaponType Type;
    public enum WeaponType
    {
        Axe,
        Bow,
        Dagger,
        Hammer,
        Staff,
        Sword,
        Wand
    };

    public Weapon(string weaponName, int requiredLevel, WeaponType weaponType, int weaponDamage)
    {
        this.Name = weaponName;
        this.RequiredLevel = requiredLevel;
        this.Type = weaponType;
        this.WeaponDamage = weaponDamage;
    }

 
}