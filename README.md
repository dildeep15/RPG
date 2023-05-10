<div align="center">
    <h1>RPG Heroes : A console based  application built in C#</h1>
</div>

## RPG Heroes

This is a console base application built in C# & .Net for Role Play Games.

>The application allows you to create different types of Heroes. For example Mage, Ranger, Rogue or Warrior.
>A Hero can be created just with a name.
>Each hero can equip various armor and weapons and are displayed under hero equipments. Each hero has a valid armor types and valid armor types that it can equip.
>All character types have their own attributes, which is a combination of **stregnth, Dexterity  & intelligence**.
>Every hero start at level 1 and on level up attributes of hero gets different attributes gain.

## General info and usage
This console application contains:
* Heroes: Hero, Mage, Ranger, Rogue, Warrior.
* Attributes: LevelAttributes.
* Equipments: Armor, item, Weapon.
* CustomExceptions: InvalidArmorException, InvalidHeroTypeException, InvalidWeaponException.
* Unit tests.

## Usage:

```
// Creata new Mage type hero & Display
string mageName = "MageName";
Hero mageHero = new Mage(mageName);

// Creata new Ranger type hero & Display
string rangerName = "RangerName";
Hero rangerHero = new Ranger(rangerName);

// Creata new Rogue type hero & Display
string rogueName = "RogueName";
Hero rogueHero = new Rogue(rogueName);

// Creata new Warrior type hero & Display
string heroName = "WarriorName";
Hero warriorHero = new Warrior(heroName);

// Level Up code;
mageHero.LevelUp();
Console.WriteLine(mageHero.HeroType + " After level Up");

// Level Up code;
rangerHero.LevelUp();

// Level Up code;
rogueHero.LevelUp();

// Level Up code;
warriorHero.LevelUp();

// Equip a Weapon;
var weaponStaff = new Weapon("Staff Weapon", 2, Weapon.WeaponType.Staff, 2);
mageHero.EquipWeapon(weaponStaff);

// Equip an Armor
LevelAttribute armorattribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 5 };
var armor1 = new Armor("Common Cloth Chest", 1, Item.Slot.Body, Armor.ArmorType.Cloth, armorattribute);
mageHero.EquipArmor(armor1);

Console.WriteLine(mageHero.Display());
```

## Technologies

Project is created with:
* .Net6
* C#
* xUnit
