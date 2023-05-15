namespace RPGHeroes.Equipments;
public class Weapon : Item
{ 
    public readonly Item.Slot Slot = Item.Slot.Weapon;
    public WeaponType Type { get; set; }

    /// <summary>
    /// Enumerator containing list of weapon types
    /// </summary>
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

    public Weapon(string weaponName, int requiredLevel, WeaponType weaponType, decimal weaponDamage)
    {
        this.Name = weaponName;
        this.RequiredLevel = requiredLevel;
        this.Type = weaponType;
        this.WeaponDamage = weaponDamage;
    }

 
}