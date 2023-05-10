using RPGHeroes;
using RPGHeroes.Attributes;
using RPGHeroes.Equipments;
using System.Text;
using static RPGHeroes.Hero;

namespace RPGHeroesTest
{
    public class RPGHeroTest
    {
        #region Created Hero must have correct name, level and attributes
        [Fact]
        public void Constructor_CreateMageTypeHero_ShouldCreatedWithCorrectName()
        {
            // Arrange
            string heroName = "MageName";
            string expected = heroName;

            // Act
             Hero myHero = new Mage(heroName);
            string actual = myHero.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_CreateRangerTypeHero_ShouldCreatedWithCorrectName()
        {
            // Arrange
            string heroName = "RangerName";
            string expected = heroName;

            // Act
            Hero myHero = new Ranger(heroName);
            string actual = myHero.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_CreateRogueTypeHero_ShouldCreatedWithCorrectName()
        {
            // Arrange
            string heroName = "RogueName";
            string expected = heroName;

            // Act
            Hero myHero = new Rogue(heroName);
            string actual = myHero.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_CreateWarriorTypeHero_ShouldCreatedWithCorrectName()
        {
            // Arrange
            string heroName = "WarriorName";
            string expected = heroName;

            // Act
            Hero myHero = new Warrior(heroName);
            string actual = myHero.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_CreateMageTypeHero_ShouldBeCreatedAtLevelOne()
        {
            // Arrange
            string heroName = "MageName";
            int expected = 1;

            // Act
            Hero myHero = new Mage(heroName);
            int actual = myHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_CreateRangerTypeHero_ShouldBeCreatedAtLevelOne()
        {
            // Arrange
            string heroName = "RangerName";
            int expected = 1;

            // Act
            Hero myHero = new Ranger(heroName);
            int actual = myHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_CreateRogueTypeHero_ShouldBeCreatedAtLevelOne()
        {
            // Arrange
            string heroName = "RogueName";
            int expected = 1;

            // Act
            Hero myHero = new Rogue(heroName);
            int actual = myHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Constructor_CreateWarriorTypeHero_ShouldBeCreatedAtLevelOne()
        {
            // Arrange
            string heroName = "WarriorName";
            int expected = 1;

            // Act
            Hero myHero = new Warrior(heroName);
            int actual = myHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_CreateMageTypeHero_ShouldHaveCorrectAttributes()
        {
            // Arrange
            string heroName = "MageName";
            LevelAttribute expected = new LevelAttribute(1,1,8);

            // Act
            Hero myHero = new Mage(heroName);
            LevelAttribute actual = myHero.HeroAttributes;

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void Constructor_CreateRangerTypeHero_ShouldHaveCorrectAttributes()
        {
            // Arrange
            string heroName = "RangerName";
            LevelAttribute expected = new LevelAttribute(1, 7, 1);

            // Act
            Hero myHero = new Ranger(heroName);
            LevelAttribute actual = myHero.HeroAttributes;

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }
        [Fact]
        public void Constructor_CreateRogueTypeHero_ShouldHaveCorrectAttributes()
        {
            // Arrange
            string heroName = "RogueName";
            LevelAttribute expected = new LevelAttribute(2, 6, 1);

            // Act
            Hero myHero = new Rogue(heroName);
            LevelAttribute actual = myHero.HeroAttributes;

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }
        [Fact]
        public void Constructor_CreateWarriorTypeHero_ShouldHaveCorrectAttributes()
        {
            // Arrange
            string heroName = "WarriorName";
            LevelAttribute expected = new LevelAttribute(5, 2, 1);

            // Act
            Hero myHero = new Warrior(heroName);
            LevelAttribute actual = myHero.HeroAttributes;

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        #endregion

        #region Level Up of Hero & Attribution calculation on level up
        [Fact]
        public void LevelUp_UpdateLevelOfMage_LevelOfHeroShouldIncrease()
        {
            // Arrange
            string heroName = "MageName";
            Hero myHero = new Mage(heroName);
            int expected = myHero.Level+ 1;

            // Act
            myHero.LevelUp();
            int actual = myHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_UpdateLevelOfRanger_LevelOfHeroShouldIncrease()
        {
            // Arrange
            string heroName = "RangerName";
            Hero myHero = new Ranger(heroName);
            int expected = myHero.Level + 1;

            // Act
            myHero.LevelUp();
            int actual = myHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_UpdateLevelOfRogue_LevelOfHeroShouldIncrease()
        {
            // Arrange
            string heroName = "RogueName";
            Hero myHero = new Rogue(heroName);
            int expected = myHero.Level + 1;

            // Act
            myHero.LevelUp();
            int actual = myHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_UpdateLevelOfWarrior_LevelOfHeroShouldIncrease()
        {
            // Arrange
            string heroName = "WarriorName";
            Hero myHero = new Warrior(heroName);
            int expected = myHero.Level + 1;

            // Act
            myHero.LevelUp();
            int actual = myHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_UpdateLevelOfMageType_LevelAttributesofmyHeroShouldBeIncrementedProperly()
        {
            // Arrange
            string heroName = "MageName";
            HeroTypes heroType = HeroTypes.Mage;
            Hero myHero = new Mage(heroName);
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            LevelAttribute levelUpAttributes = levelObj.GetLevelUpAttribute(heroType);
            LevelAttribute expected = new LevelAttribute((defaultAttributes.Strength + levelUpAttributes.Strength),
                (defaultAttributes.Dexterity + levelUpAttributes.Dexterity), 
                (defaultAttributes.Intelligence + levelUpAttributes.Intelligence)); 

            // Act
            myHero.LevelUp();
            LevelAttribute actual = myHero.HeroAttributes;

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void LevelUp_UpdateLevelOfRangerType_LevelAttributesofmyHeroShouldBeIncrementedProperly()
        {
            // Arrange
            string heroName = "RangerName";
            HeroTypes heroType = HeroTypes.Ranger;
            Hero myHero = new Ranger(heroName);
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            LevelAttribute levelUpAttributes = levelObj.GetLevelUpAttribute(heroType);
            LevelAttribute expected = new LevelAttribute((defaultAttributes.Strength + levelUpAttributes.Strength),
                (defaultAttributes.Dexterity + levelUpAttributes.Dexterity),
                (defaultAttributes.Intelligence + levelUpAttributes.Intelligence));

            // Act
            myHero.LevelUp();
            LevelAttribute actual = myHero.HeroAttributes;

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void LevelUp_UpdateLevelOfRogueType_LevelAttributesofmyHeroShouldBeIncrementedProperly()
        {
            // Arrange
            string heroName = "RogueName";
            HeroTypes heroType = HeroTypes.Rogue;
            Hero myHero = new Rogue(heroName);
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            LevelAttribute levelUpAttributes = levelObj.GetLevelUpAttribute(heroType);
            LevelAttribute expected = new LevelAttribute((defaultAttributes.Strength + levelUpAttributes.Strength),
                (defaultAttributes.Dexterity + levelUpAttributes.Dexterity),
                (defaultAttributes.Intelligence + levelUpAttributes.Intelligence));

            // Act
            myHero.LevelUp();
            LevelAttribute actual = myHero.HeroAttributes;

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }
        [Fact]
        public void LevelUp_UpdateLevelOfWarriorType_LevelAttributesofmyHeroShouldBeIncrementedProperly()
        {
            // Arrange
            string heroName = "WarriorName";
            HeroTypes heroType = HeroTypes.Warrior;
            Hero myHero = new Warrior(heroName);
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            LevelAttribute levelUpAttributes = levelObj.GetLevelUpAttribute(heroType);
            LevelAttribute expected = new LevelAttribute((defaultAttributes.Strength + levelUpAttributes.Strength),
                (defaultAttributes.Dexterity + levelUpAttributes.Dexterity),
                (defaultAttributes.Intelligence + levelUpAttributes.Intelligence));

            // Act
            myHero.LevelUp();
            LevelAttribute actual = myHero.HeroAttributes;

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }
        #endregion

        #region Test for creating weapon.
        [Theory]
        [InlineData("Axes", 1, Weapon.WeaponType.Axe, 2)]
        [InlineData("Bow", 2, Weapon.WeaponType.Bow, 3)]
        [InlineData("Dagger", 3, Weapon.WeaponType.Dagger, 6)]
        [InlineData("Hammer", 4, Weapon.WeaponType.Hammer, 8)]
        [InlineData("Staff", 5, Weapon.WeaponType.Staff,1)]
        [InlineData("Sword", 6, Weapon.WeaponType.Sword, 9)]
        [InlineData("Wand", 7, Weapon.WeaponType.Wand, 5)]

        public void Constructor_CreateANewWeapon_ShouldHaveCorrectName(string weaponName, int requiredLevel,Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            string expected = weaponName;

            // Act
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            string? actual = newWeapon.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Axes", 1, Weapon.WeaponType.Axe, 2)]
        [InlineData("Bow", 2, Weapon.WeaponType.Bow, 3)]
        [InlineData("Dagger", 3, Weapon.WeaponType.Dagger, 6)]
        [InlineData("Hammer", 4, Weapon.WeaponType.Hammer, 8)]
        [InlineData("Staff", 5, Weapon.WeaponType.Staff, 1)]
        [InlineData("Sword", 6, Weapon.WeaponType.Sword, 9)]
        [InlineData("Wand", 7, Weapon.WeaponType.Wand, 5)]
        public void Constructor_CreateANewWeapon_ShouldHaveCorrectRequiredLevel(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            int expected = requiredLevel;

            // Act
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            int actual = newWeapon.RequiredLevel;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Axes", 1, Weapon.WeaponType.Axe, 2)]
        [InlineData("Bow", 2, Weapon.WeaponType.Bow, 3)]
        [InlineData("Dagger", 3, Weapon.WeaponType.Dagger, 6)]
        [InlineData("Hammer", 4, Weapon.WeaponType.Hammer, 8)]
        [InlineData("Staff", 5, Weapon.WeaponType.Staff, 1)]
        [InlineData("Sword", 6, Weapon.WeaponType.Sword, 9)]
        [InlineData("Wand", 7, Weapon.WeaponType.Wand, 5)]
        public void Constructor_CreateANewWeapon_ShouldHaveCorrectSlot(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            string expected = "Weapon";

            // Act
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            string actual = newWeapon.Slot.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Axes", 1, Weapon.WeaponType.Axe, 2)]
        [InlineData("Bow", 2, Weapon.WeaponType.Bow, 3)]
        [InlineData("Dagger", 3, Weapon.WeaponType.Dagger, 6)]
        [InlineData("Hammer", 4, Weapon.WeaponType.Hammer, 8)]
        [InlineData("Staff", 5, Weapon.WeaponType.Staff, 1)]
        [InlineData("Sword", 6, Weapon.WeaponType.Sword, 9)]
        [InlineData("Wand", 7, Weapon.WeaponType.Wand, 5)]
        public void Constructor_CreateANewWeapon_ShouldHaveCorrectWeaponType(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon.WeaponType expected = weaponType;

            // Act
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Weapon.WeaponType actual = newWeapon.Type;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Axes", 1, Weapon.WeaponType.Axe, 2)]
        [InlineData("Bow", 2, Weapon.WeaponType.Bow, 3)]
        [InlineData("Dagger", 3, Weapon.WeaponType.Dagger, 6)]
        [InlineData("Hammer", 4, Weapon.WeaponType.Hammer, 8)]
        [InlineData("Staff", 5, Weapon.WeaponType.Staff, 1)]
        [InlineData("Sword", 6, Weapon.WeaponType.Sword, 9)]
        [InlineData("Wand", 7, Weapon.WeaponType.Wand, 5)]
        public void Constructor_CreateANewWeapon_ShouldHaveCorrectWeaponDamage(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            int expected = weaponDamage;

            // Act
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            decimal actual = newWeapon.WeaponDamage;

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Test for creating Armor.
        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        [InlineData("Leather", 2, Item.Slot.Legs, Armor.ArmorType.Leather)]
        [InlineData("Mail", 3, Item.Slot.Body, Armor.ArmorType.Mail)]
        [InlineData("Plate", 4, Item.Slot.Head, Armor.ArmorType.Plate)]
        public void Constructor_CreateAnArmor_ShouldHaveCorrectName(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            string expected = armorName;

            // Act
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            string? actual = newArmor.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        [InlineData("Leather", 2, Item.Slot.Legs, Armor.ArmorType.Leather)]
        [InlineData("Mail", 3, Item.Slot.Body, Armor.ArmorType.Mail)]
        [InlineData("Plate", 4, Item.Slot.Head, Armor.ArmorType.Plate)]
        public void Constructor_CreateAnArmor_ShouldHaveCorrectRequiredLevel(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            int expected = requiredLevel;

            // Act
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            int actual = newArmor.RequiredLevel;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        [InlineData("Leather", 2, Item.Slot.Legs, Armor.ArmorType.Leather)]
        [InlineData("Mail", 3, Item.Slot.Body, Armor.ArmorType.Mail)]
        [InlineData("Plate", 4, Item.Slot.Head, Armor.ArmorType.Plate)]
        public void Constructor_CreateAnArmor_ShouldHaveCorrectSlot(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            string expected = slot.ToString();

            // Act
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            string actual = newArmor.Slot.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        [InlineData("Leather", 2, Item.Slot.Legs, Armor.ArmorType.Leather)]
        [InlineData("Mail", 3, Item.Slot.Body, Armor.ArmorType.Mail)]
        [InlineData("Plate", 4, Item.Slot.Head, Armor.ArmorType.Plate)]
        public void Constructor_CreateAnArmor_ShouldHaveCorrectArmorType(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            string expected = armorType.ToString();

            // Act
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            string actual = newArmor.Type.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        [InlineData("Leather", 2, Item.Slot.Legs, Armor.ArmorType.Leather)]
        [InlineData("Mail", 3, Item.Slot.Body, Armor.ArmorType.Mail)]
        [InlineData("Plate", 4, Item.Slot.Head, Armor.ArmorType.Plate)]
        public void Constructor_CreateAnArmor_ShouldHaveCorrectAttributes(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            LevelAttribute expected = armorAttribute;

            // Act
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            LevelAttribute actual = newArmor.ArmorAttribute;

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }
        #endregion

        #region Equipping a weapon for different hero type
        [Theory]
        [InlineData("Staff", 1, Weapon.WeaponType.Staff, 1)]
        [InlineData("Wand", 1, Weapon.WeaponType.Wand, 5)]
        public void EquipWeapon_MageEquipAValidWeapon_WeaponGetEquipedInWeaponSlot(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Mage("myHero");
            string expected = weaponName;

            // Act
            myHero.EquipWeapon(newWeapon);
            string? actual = myHero.Equipments[Item.Slot.Weapon]!.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Bow", 1, Weapon.WeaponType.Bow, 1)]
        public void EquipWeapon_RangerEquipAValidWeapon_WeaponGetEquipedInWeaponSlot(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Ranger("myHero");
            string expected = weaponName;

            // Act
            myHero.EquipWeapon(newWeapon);
            string? actual = myHero.Equipments[Item.Slot.Weapon]!.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Dagger", 1, Weapon.WeaponType.Dagger, 1)]
        [InlineData("Sword", 1, Weapon.WeaponType.Sword, 1)]
        public void EquipWeapon_RogueEquipAValidWeapon_WeaponGetEquipedInWeaponSlot(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Rogue("myHero");
            string expected = weaponName;

            // Act
            myHero.EquipWeapon(newWeapon);
            string? actual = myHero.Equipments[Item.Slot.Weapon]!.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Axe", 1, Weapon.WeaponType.Axe, 1)]
        [InlineData("Hammer", 1, Weapon.WeaponType.Hammer, 1)]
        [InlineData("Sword", 1, Weapon.WeaponType.Sword, 1)]
        public void EquipWeapon_WarriorEquipAValidWeapon_WeaponGetEquipedInWeaponSlot(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Warrior("myHero");
            string expected = weaponName;

            // Act
            myHero.EquipWeapon(newWeapon);
            string? actual = myHero.Equipments[Item.Slot.Weapon]!.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Staff", 5, Weapon.WeaponType.Staff, 1)]
        [InlineData("Wand", 5, Weapon.WeaponType.Wand, 5)]
        public void EquipWeapon_MageEquipValidWeaponTypeWithHighRequiredLevel_GetAnInvalidWeaponException(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Mage("myHero");
            string expected = weaponName;

            // Act and Assert
            Assert.Throws<InvalidWeaponException>(() => { myHero.EquipWeapon(newWeapon); });
        }

        [Theory]
        [InlineData("Bow", 5, Weapon.WeaponType.Bow, 1)]
        public void EquipWeapon_RogueEquipValidWeaponTypeWithHighRequiredLevel_GetAnInvalidWeaponException(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Rogue("myHero");
            string expected = weaponName;

            // Act and Assert
            Assert.Throws<InvalidWeaponException>(() => { myHero.EquipWeapon(newWeapon); });
        }

        [Theory]
        [InlineData("Dagger", 5, Weapon.WeaponType.Dagger, 1)]
        [InlineData("Sword", 5, Weapon.WeaponType.Sword, 1)]
        public void EquipWeapon_RangerEquipValidWeaponTypeWithHighRequiredLevel_GetAnInvalidWeaponException(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Ranger("myHero");
            string expected = weaponName;

            // Act and Assert
            Assert.Throws<InvalidWeaponException>(() => { myHero.EquipWeapon(newWeapon); });
        }

        [Theory]
        [InlineData("Axe", 5, Weapon.WeaponType.Axe, 1)]
        [InlineData("Hammer", 5, Weapon.WeaponType.Hammer, 1)]
        [InlineData("Sword", 5, Weapon.WeaponType.Sword, 1)]
        public void EquipWeapon_WarriorEquipValidWeaponTypeWithHighRequiredLevel_GetAnInvalidWeaponException(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Warrior("myHero");
            string expected = weaponName;

            // Act and Assert
            Assert.Throws<InvalidWeaponException>(() => { myHero.EquipWeapon(newWeapon); });
        }

        [Theory]
        [InlineData("Axes", 1, Weapon.WeaponType.Axe, 2)]
        [InlineData("Bow", 1, Weapon.WeaponType.Bow, 3)]
        [InlineData("Dagger", 1, Weapon.WeaponType.Dagger, 6)]
        [InlineData("Hammer", 1, Weapon.WeaponType.Hammer, 8)]
        [InlineData("Sword", 1, Weapon.WeaponType.Sword, 9)]
        public void EquipWeapon_MageEquipAnInvalidWeaponType_GetAnInvalidWeaponException(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Mage("myHero");
            string expected = weaponName;

            // Act and Assert
            Assert.Throws<InvalidWeaponException>(() => { myHero.EquipWeapon(newWeapon); });

        }

        [Theory]
        [InlineData("Axes", 1, Weapon.WeaponType.Axe, 2)]
        [InlineData("Dagger", 1, Weapon.WeaponType.Dagger, 6)]
        [InlineData("Hammer", 1, Weapon.WeaponType.Hammer, 8)]
        [InlineData("Sword", 1, Weapon.WeaponType.Sword, 9)]
        [InlineData("Staff", 1, Weapon.WeaponType.Staff, 1)]
        [InlineData("Wand", 1, Weapon.WeaponType.Wand, 5)]
        public void EquipWeapon_RangerEquipAnInvalidWeaponType_GetAnInvalidWeaponException(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Ranger("myHero");
            string expected = weaponName;

            // Act and Assert
            Assert.Throws<InvalidWeaponException>(() => { myHero.EquipWeapon(newWeapon); });

        }
        [Theory]
        [InlineData("Axes", 1, Weapon.WeaponType.Axe, 2)]
        [InlineData("Bow", 1, Weapon.WeaponType.Bow, 3)]
        [InlineData("Hammer", 1, Weapon.WeaponType.Hammer, 8)]
        [InlineData("Staff", 1, Weapon.WeaponType.Staff, 1)]
        [InlineData("Wand", 1, Weapon.WeaponType.Wand, 5)]
        public void EquipWeapon_RogueEquipAnInvalidWeaponType_GetAnInvalidWeaponException(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Rogue("myHero");
            string expected = weaponName;

            // Act and Assert
            Assert.Throws<InvalidWeaponException>(() => { myHero.EquipWeapon(newWeapon); });

        }
        [Theory]
        [InlineData("Bow", 1, Weapon.WeaponType.Bow, 3)]
        [InlineData("Dagger", 1, Weapon.WeaponType.Dagger, 6)]
        [InlineData("Staff", 1, Weapon.WeaponType.Staff, 1)]
        [InlineData("Wand", 1, Weapon.WeaponType.Wand, 5)]
        public void EquipWeapon_WarriorEquipAnInvalidWeaponType_GetAnInvalidWeaponException(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, int weaponDamage)
        {
            // Arrange
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            Hero myHero = new Warrior("myHero");
            string expected = weaponName;

            // Act and Assert
            Assert.Throws<InvalidWeaponException>(() => { myHero.EquipWeapon(newWeapon); });

        }
        #endregion

        #region Equipping an armor for different hero types
        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        public void EquipArmor_MageEquipAValidArmor_WeaponGetEquipedInArmorSlot(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            string expected = armorName;
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Mage("MageName");

            // Act
            myHero.EquipArmor(newArmor);
            string? actual = myHero.Equipments[slot]!.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Leather", 1, Item.Slot.Body, Armor.ArmorType.Leather)]
        [InlineData("Mail", 1, Item.Slot.Legs, Armor.ArmorType.Mail)]
        public void EquipArmor_RangerEquipAValidArmor_WeaponGetEquipedInArmorSlot(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            string expected = armorName;
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Ranger("RangerName");

            // Act
            myHero.EquipArmor(newArmor);
            string? actual = myHero.Equipments[slot]!.Name;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Leather", 1, Item.Slot.Body, Armor.ArmorType.Leather)]
        [InlineData("Mail", 1, Item.Slot.Legs, Armor.ArmorType.Mail)]
        public void EquipArmor_RogueEquipAValidArmor_WeaponGetEquipedInArmorSlot(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            string expected = armorName;
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Rogue("RogueName");

            // Act
            myHero.EquipArmor(newArmor);
            string? actual = myHero.Equipments[slot]!.Name;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Mail", 1, Item.Slot.Legs, Armor.ArmorType.Mail)]
        [InlineData("Plate", 1, Item.Slot.Head, Armor.ArmorType.Plate)]
        public void EquipArmor_WarriorEquipAValidArmor_WeaponGetEquipedInArmorSlot(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            string expected = armorName;
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Warrior("WarriorName");

            // Act
            myHero.EquipArmor(newArmor);
            string? actual = myHero.Equipments[slot]!.Name;

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("Cloth", 5, Item.Slot.Body, Armor.ArmorType.Cloth)]
        public void EquipArmor_MageEquipAValidArmorWithHighRequiredLevel_GetInvalidArmorException(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Mage("MageName");
            string expected = armorName;

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => { myHero.EquipArmor(newArmor); });
        }

        [Theory]
        [InlineData("Leather", 5, Item.Slot.Body, Armor.ArmorType.Leather)]
        [InlineData("Mail", 5, Item.Slot.Body, Armor.ArmorType.Mail)]
        public void EquipArmor_RangerEquipAValidArmorWithHighRequiredLevel_GetInvalidArmorException(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Ranger("RangerName");
            string expected = armorName;

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => { myHero.EquipArmor(newArmor); });
        }

        [Theory]
        [InlineData("Leather", 5, Item.Slot.Body, Armor.ArmorType.Leather)]
        [InlineData("Mail", 5, Item.Slot.Body, Armor.ArmorType.Mail)]
        public void EquipArmor_RogueEquipAValidArmorWithHighRequiredLevel_GetInvalidArmorException(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            string expected = armorName;
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Rogue("RogueName");

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => { myHero.EquipArmor(newArmor); });
        }

        [Theory]
        [InlineData("Leather", 5, Item.Slot.Body, Armor.ArmorType.Leather)]
        [InlineData("Mail", 5, Item.Slot.Body, Armor.ArmorType.Mail)]
        public void EquipArmor_WarriorEquipAValidArmorWithHighRequiredLevel_GetInvalidArmorException(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            string expected = armorName;
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Warrior("WarriorName");

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => { myHero.EquipArmor(newArmor); });
        }

        [Theory]
        [InlineData("Leather", 1, Item.Slot.Legs, Armor.ArmorType.Leather)]
        [InlineData("Mail", 1, Item.Slot.Body, Armor.ArmorType.Mail)]
        [InlineData("Plate", 1, Item.Slot.Head, Armor.ArmorType.Plate)]
        public void EquipArmor_MageEquipAnInValidArmorType_GetInvalidArmorException(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Mage("Mage Hero");
            string expected = armorName;

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => { myHero.EquipArmor(newArmor); });
        }


        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        [InlineData("Plate", 1, Item.Slot.Head, Armor.ArmorType.Plate)]
        public void EquipArmor_RangerEquipAnInValidArmorType_GetInvalidArmorException(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Ranger("RangerName");
            string expected = armorName;

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => { myHero.EquipArmor(newArmor); });
        }

        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        [InlineData("Plate", 1, Item.Slot.Head, Armor.ArmorType.Plate)]
        public void EquipArmor_RogueEquipAnInValidArmorType_GetInvalidArmorException(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Rogue("RogueName");
            string expected = armorName;

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => { myHero.EquipArmor(newArmor); });
        }

        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        [InlineData("Leather", 1, Item.Slot.Head, Armor.ArmorType.Leather)]
        public void EquipArmor_WarriorEquipAnInValidArmorType_GetInvalidArmorException(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            Hero myHero = new Warrior("WarriorName");
            string expected = armorName;

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => { myHero.EquipArmor(newArmor); });
        }
        #endregion

        #region TotalAttribute test for different heros
        [Fact]
        public void TotalAttributes_CalculateTotalAttributesOfMageWithNoArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            HeroTypes heroType = HeroTypes.Mage;
            LevelAttribute levelObj = new LevelAttribute();
            var expected = levelObj.GetDefaultAttributes(heroType);

            // Act
            Hero myHero = new Mage("MageName");
            var actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void TotalAttributes_CalculateTotalAttributesOfRangerWithNoArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            HeroTypes heroType = HeroTypes.Ranger;
            LevelAttribute levelObj = new LevelAttribute();
            var expected = levelObj.GetDefaultAttributes(heroType);

            // Act
            Hero myHero = new Ranger("RangerName");
            var actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void TotalAttributes_CalculateTotalAttributesOfRogueWithNoArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            HeroTypes heroType = HeroTypes.Rogue;
            LevelAttribute levelObj = new LevelAttribute();
            var expected = levelObj.GetDefaultAttributes(heroType);

            // Act
            Hero myHero = new Rogue("RogueName");
            var actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void TotalAttributes_CalculateTotalAttributesOfWarriorWithNoArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            HeroTypes heroType = HeroTypes.Warrior;
            LevelAttribute levelObj = new LevelAttribute();
            var expected = levelObj.GetDefaultAttributes(heroType);

            // Act
            Hero myHero = new Warrior("WarriorName");
            var actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        public void TotalAttributes_CalculateTotalAttributesOfMageWithOneArmor_ShouldReturnCorrectAttributes(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            HeroTypes heroType = HeroTypes.Mage;
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Hero myHero = new Mage("Mage Hero");
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            var expected = new LevelAttribute( defaultAttributes.Strength, defaultAttributes.Dexterity, defaultAttributes.Intelligence);
            expected.Strength += armorAttribute.Strength;
            expected.Dexterity += armorAttribute.Dexterity;
            expected.Intelligence += armorAttribute.Intelligence;

            // Act
            myHero.EquipArmor(newArmor);
            LevelAttribute actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Theory]
        [InlineData("Leather", 1, Item.Slot.Body, Armor.ArmorType.Leather)]
        public void TotalAttributes_CalculateTotalAttributesOfRangerWithOneArmor_ShouldReturnCorrectAttributes(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            HeroTypes heroType = HeroTypes.Ranger;
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Hero myHero = new Ranger("RangerName");
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            var expected = new LevelAttribute(defaultAttributes.Strength, defaultAttributes.Dexterity, defaultAttributes.Intelligence);
            expected.Strength += armorAttribute.Strength;
            expected.Dexterity += armorAttribute.Dexterity;
            expected.Intelligence += armorAttribute.Intelligence;

            // Act
            myHero.EquipArmor(newArmor);
            LevelAttribute actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Theory]
        [InlineData("Leather", 1, Item.Slot.Body, Armor.ArmorType.Leather)]
        public void TotalAttributes_CalculateTotalAttributesOfRogueWithOneArmor_ShouldReturnCorrectAttributes(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            HeroTypes heroType = HeroTypes.Rogue;
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Hero myHero = new Rogue("RogueName");
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            var expected = new LevelAttribute(defaultAttributes.Strength, defaultAttributes.Dexterity, defaultAttributes.Intelligence);
            expected.Strength += armorAttribute.Strength;
            expected.Dexterity += armorAttribute.Dexterity;
            expected.Intelligence += armorAttribute.Intelligence;

            // Act
            myHero.EquipArmor(newArmor);
            LevelAttribute actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Theory]
        [InlineData("Mail", 1, Item.Slot.Body, Armor.ArmorType.Mail)]
        public void TotalAttributes_CalculateTotalAttributesOfWarriorWithOneArmor_ShouldReturnCorrectAttributes(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            HeroTypes heroType = HeroTypes.Warrior;
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Hero myHero = new Warrior("WarriorName");
            var newArmor = new Armor(armorName, requiredLevel, slot, armorType, armorAttribute);
            var expected = new LevelAttribute(defaultAttributes.Strength, defaultAttributes.Dexterity, defaultAttributes.Intelligence);
            expected.Strength += armorAttribute.Strength;
            expected.Dexterity += armorAttribute.Dexterity;
            expected.Intelligence += armorAttribute.Intelligence;

            // Act
            myHero.EquipArmor(newArmor);
            LevelAttribute actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Theory]
        [InlineData("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth)]
        public void TotalAttributes_CalculateTotalAttributesOfMageWithArmorReplaced_ShouldReturnCorrectAttributes(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute oldArmorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            LevelAttribute newArmorAttribute = new LevelAttribute { Strength = 10, Dexterity = 5, Intelligence = 3 };
            HeroTypes heroType = HeroTypes.Mage;
            Hero myHero = new Mage("MageName");
            var firstArmor = new Armor(armorName, requiredLevel, slot, armorType, oldArmorAttribute);
            var secondArmor = new Armor(armorName, requiredLevel, slot, armorType, newArmorAttribute);
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            var expected = new LevelAttribute(defaultAttributes.Strength, defaultAttributes.Dexterity, defaultAttributes.Intelligence);
            expected.Strength += newArmorAttribute.Strength;
            expected.Dexterity += newArmorAttribute.Dexterity;
            expected.Intelligence += newArmorAttribute.Intelligence;

            // Act
            myHero.EquipArmor(firstArmor);
            myHero.EquipArmor(secondArmor);
            var actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Theory]
        [InlineData("Leather", 1, Item.Slot.Body, Armor.ArmorType.Leather)]
        public void TotalAttributes_CalculateTotalAttributesOfRangerWithArmorReplaced_ShouldReturnCorrectAttributes(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute oldArmorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            LevelAttribute newArmorAttribute = new LevelAttribute { Strength = 10, Dexterity = 5, Intelligence = 3 };
            HeroTypes heroType = HeroTypes.Ranger;
            Hero myHero = new Ranger("RangerName");
            var firstArmor = new Armor(armorName, requiredLevel, slot, armorType, oldArmorAttribute);
            var secondArmor = new Armor(armorName, requiredLevel, slot, armorType, newArmorAttribute);
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            var expected = new LevelAttribute(defaultAttributes.Strength, defaultAttributes.Dexterity, defaultAttributes.Intelligence);
            expected.Strength += newArmorAttribute.Strength;
            expected.Dexterity += newArmorAttribute.Dexterity;
            expected.Intelligence += newArmorAttribute.Intelligence;

            // Act
            myHero.EquipArmor(firstArmor);
            myHero.EquipArmor(secondArmor);
            var actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Theory]
        [InlineData("Leather", 1, Item.Slot.Body, Armor.ArmorType.Leather)]
        public void TotalAttributes_CalculateTotalAttributesOfRogueWithArmorReplaced_ShouldReturnCorrectAttributes(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute oldArmorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            LevelAttribute newArmorAttribute = new LevelAttribute { Strength = 10, Dexterity = 5, Intelligence = 3 };
            HeroTypes heroType = HeroTypes.Rogue;
            Hero myHero = new Rogue("RogueName");
            var firstArmor = new Armor(armorName, requiredLevel, slot, armorType, oldArmorAttribute);
            var secondArmor = new Armor(armorName, requiredLevel, slot, armorType, newArmorAttribute);
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            var expected = new LevelAttribute(defaultAttributes.Strength, defaultAttributes.Dexterity, defaultAttributes.Intelligence);
            expected.Strength += newArmorAttribute.Strength;
            expected.Dexterity += newArmorAttribute.Dexterity;
            expected.Intelligence += newArmorAttribute.Intelligence;

            // Act
            myHero.EquipArmor(firstArmor);
            myHero.EquipArmor(secondArmor);
            var actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Theory]
        [InlineData("Mail", 1, Item.Slot.Body, Armor.ArmorType.Mail)]
        public void TotalAttributes_CalculateTotalAttributesOfWarriorWithArmorReplaced_ShouldReturnCorrectAttributes(string armorName, int requiredLevel, Item.Slot slot, Armor.ArmorType armorType)
        {
            // Arrange
            LevelAttribute oldArmorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            LevelAttribute newArmorAttribute = new LevelAttribute { Strength = 10, Dexterity = 5, Intelligence = 3 };
            HeroTypes heroType = HeroTypes.Warrior;
            Hero myHero = new Warrior("WarriorName");
            var firstArmor = new Armor(armorName, requiredLevel, slot, armorType, oldArmorAttribute);
            var secondArmor = new Armor(armorName, requiredLevel, slot, armorType, newArmorAttribute);
            LevelAttribute levelObj = new LevelAttribute();
            LevelAttribute defaultAttributes = levelObj.GetDefaultAttributes(heroType);
            var expected = new LevelAttribute(defaultAttributes.Strength, defaultAttributes.Dexterity, defaultAttributes.Intelligence);
            expected.Strength += newArmorAttribute.Strength;
            expected.Dexterity += newArmorAttribute.Dexterity;
            expected.Intelligence += newArmorAttribute.Intelligence;

            // Act
            myHero.EquipArmor(firstArmor);
            myHero.EquipArmor(secondArmor);
            var actual = myHero.TotalAttributes();

            // Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }
        #endregion

        #region Calculate HeroDamage for different heroes
        [Fact]
        public void CalculateHeroDamage_CalculateHeroDamageForMageWithNoWeapon_ShouldReturnCorrectHeroDamage()
        {
            // Arrange
            decimal weaponDamage = 1;
            Hero myHero = new Mage("MageName");
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Intelligence;
            decimal expected = weaponDamage * (1 + (decimal)heroDamageAttribute/100);

            // Act
            decimal actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateHeroDamage_CalculateHeroDamageForRangerWithNoWeapon_ShouldReturnCorrectHeroDamage()
        {
            // Arrange
            decimal weaponDamage = 1;
            Hero myHero = new Ranger("RangerName");
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Dexterity;
            decimal expected = weaponDamage * (1 + (decimal)heroDamageAttribute / 100);

            // Act
            decimal actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateHeroDamage_CalculateHeroDamageForRogueWithNoWeapon_ShouldReturnCorrectHeroDamage()
        {
            // Arrange
            decimal weaponDamage = 1;
            Hero myHero = new Rogue("RogueName");
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Dexterity;
            decimal expected = weaponDamage * (1 + (decimal)heroDamageAttribute / 100);

            // Act
            decimal actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateHeroDamage_CalculateHeroDamageForWarriorWithNoWeapon_ShouldReturnCorrectHeroDamage()
        {
            // Arrange
            decimal weaponDamage = 1;
            Hero myHero = new Warrior("WarriorName");
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Strength;
            decimal expected = weaponDamage * (1 + (decimal)heroDamageAttribute / 100);

            // Act
            decimal actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Staff", 1, Weapon.WeaponType.Staff, 1)]
        [InlineData("Wand", 1, Weapon.WeaponType.Wand, 5)]
        public void CalculateHeroDamage_CalculateHeroDamageForMageWithWeaponEquipped_ShouldReturnCorrectHeroDamage(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, decimal weaponDamage)
        {
            // Arrange
            Hero myHero = new Mage("MageName");
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Intelligence;
            var expected = weaponDamage * (1 + (decimal)heroDamageAttribute / 100);

            // Act
            myHero.EquipWeapon(newWeapon);
            var actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Bow", 1, Weapon.WeaponType.Bow, 1)]
        public void CalculateHeroDamage_CalculateHeroDamageForRangerWithWeaponEquipped_ShouldReturnCorrectHeroDamage(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, decimal weaponDamage)
        {
            // Arrange
            Hero myHero = new Ranger("RangerName");
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Dexterity;
            var expected = weaponDamage * (1 + (decimal)heroDamageAttribute / 100);

            // Act
            myHero.EquipWeapon(newWeapon);
            var actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Dagger", 1, Weapon.WeaponType.Dagger, 1)]
        [InlineData("Sword", 1, Weapon.WeaponType.Sword, 1)]
        public void CalculateHeroDamage_CalculateHeroDamageForRogueWithWeaponEquipped_ShouldReturnCorrectHeroDamage(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, decimal weaponDamage)
        {
            // Arrange
            Hero myHero = new Rogue("RogueName");
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Dexterity;
            var expected = weaponDamage * (1 + (decimal)heroDamageAttribute / 100);

            // Act
            myHero.EquipWeapon(newWeapon);
            var actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Axe", 1, Weapon.WeaponType.Axe, 1)]
        [InlineData("Hammer", 1, Weapon.WeaponType.Hammer, 1)]
        [InlineData("Sword", 1, Weapon.WeaponType.Sword, 1)]
        public void CalculateHeroDamage_CalculateHeroDamageForWarriorWithWeaponEquipped_ShouldReturnCorrectHeroDamage(string weaponName, int requiredLevel, Weapon.WeaponType weaponType, decimal weaponDamage)
        {
            // Arrange
            Hero myHero = new Warrior("WarriorName");
            Weapon newWeapon = new Weapon(weaponName, requiredLevel, weaponType, weaponDamage);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Strength;
            var expected = weaponDamage * (1 + (decimal)heroDamageAttribute/100);

            // Act
            myHero.EquipWeapon(newWeapon);
            var actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateHeroDamage_CalculateHeroDamageForMageWithWeaponAndArmor_ShouldReturnCorrectHeroDamage()
        {
            // Arrange
            Hero myHero = new Mage("MageName");
            var weaponDamage = 5;
            Weapon newWeapon = new Weapon("Staff", 1, Weapon.WeaponType.Staff, weaponDamage);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Armor newArmor = new Armor("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth, armorAttribute);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Intelligence + armorAttribute.Intelligence;
            var expected = weaponDamage * (1 + (decimal)heroDamageAttribute / 100);

            // Act
            myHero.EquipWeapon(newWeapon);
            myHero.EquipArmor(newArmor);
            var actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateHeroDamage_CalculateHeroDamageForRogueWithWeaponAndArmor_ShouldReturnCorrectHeroDamage()
        {
            // Arrange
            Hero myHero = new Rogue("RogueName");
            var weaponDamage = 5;
            Weapon newWeapon = new Weapon("Dagger", 1, Weapon.WeaponType.Dagger, weaponDamage);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Armor newArmor = new Armor("Leather", 1, Item.Slot.Body, Armor.ArmorType.Leather, armorAttribute);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Dexterity + armorAttribute.Dexterity;
            var expected = weaponDamage * (1 + (decimal)heroDamageAttribute / 100);

            // Act
            myHero.EquipWeapon(newWeapon);
            myHero.EquipArmor(newArmor);
            var actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateHeroDamage_CalculateHeroDamageForRangerWithWeaponAndArmor_ShouldReturnCorrectHeroDamage()
        {
            // Arrange
            Hero myHero = new Ranger("RangerName");
            var weaponDamage = 5;
            Weapon newWeapon = new Weapon("Bow", 1, Weapon.WeaponType.Bow, weaponDamage);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Armor newArmor = new Armor("Leather", 1, Item.Slot.Body, Armor.ArmorType.Leather, armorAttribute);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Dexterity + armorAttribute.Dexterity;
            var expected = weaponDamage * (1 + (decimal)heroDamageAttribute / 100);

            // Act
            myHero.EquipWeapon(newWeapon);
            myHero.EquipArmor(newArmor);
            var actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateHeroDamage_CalculateHeroDamageForWarriorWithWeaponAndArmor_ShouldReturnCorrectHeroDamage()
        {
            // Arrange
            Hero myHero = new Warrior("WarriorName");
            var weaponDamage = 5;
            Weapon newWeapon = new Weapon("Axe", 1, Weapon.WeaponType.Axe, weaponDamage);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Armor newArmor = new Armor("Mail", 1, Item.Slot.Body, Armor.ArmorType.Mail, armorAttribute);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Strength + armorAttribute.Strength;
            var expected = weaponDamage * (1 + (decimal)heroDamageAttribute / 100);

            // Act
            myHero.EquipWeapon(newWeapon);
            myHero.EquipArmor(newArmor);
            var actual = myHero.CalculateHeroDamage();

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Test Display method of hero
        [Fact]
        public void Display_DisplayMageHeroStateCorrectly_DisplayCorrectHeroState()
        {
            // Arrange
            string heroName = "MageName";
            Hero myHero = new Mage(heroName);
            var weaponDamage = 5;
            Weapon newWeapon = new Weapon("Wand", 1, Weapon.WeaponType.Wand, weaponDamage);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Armor newArmor = new Armor("Cloth", 1, Item.Slot.Body, Armor.ArmorType.Cloth, armorAttribute);
            myHero.EquipWeapon(newWeapon);
            myHero.EquipArmor(newArmor);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Intelligence + armorAttribute.Intelligence;
            var heroDamage = weaponDamage * (1 + (decimal)totalAttributes.Intelligence / 100);
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Name: " + heroName);
            stringBuilder.AppendLine("Class: " + myHero.HeroType);
            stringBuilder.AppendLine("Total Strength: " + totalAttributes.Strength);
            stringBuilder.AppendLine("Total dexterity: " + totalAttributes.Dexterity);
            stringBuilder.AppendLine("Total Intelligence: " + totalAttributes.Intelligence);
            stringBuilder.AppendLine("Damage: " + heroDamage);
            var expected = stringBuilder.ToString();

            // Act
            var actual = myHero.Display().ToString();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Display_DisplayRangerHeroStateCorrectly_DisplayCorrectHeroState()
        {
            // Arrange
            string heroName = "RangerName";
            Hero myHero = new Ranger(heroName);
            var weaponDamage = 5;
            Weapon newWeapon = new Weapon("Bow", 1, Weapon.WeaponType.Bow, weaponDamage);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Armor newArmor = new Armor("Leather", 1, Item.Slot.Body, Armor.ArmorType.Leather, armorAttribute);
            myHero.EquipWeapon(newWeapon);
            myHero.EquipArmor(newArmor);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Dexterity + armorAttribute.Dexterity;
            var heroDamage = weaponDamage * (1 + (decimal)totalAttributes.Dexterity / 100);
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Name: " + heroName);
            stringBuilder.AppendLine("Class: " + myHero.HeroType);
            stringBuilder.AppendLine("Total Strength: " + totalAttributes.Strength);
            stringBuilder.AppendLine("Total dexterity: " + totalAttributes.Dexterity);
            stringBuilder.AppendLine("Total Intelligence: " + totalAttributes.Intelligence);
            stringBuilder.AppendLine("Damage: " + heroDamage);
            var expected = stringBuilder.ToString();

            // Act
            var actual = myHero.Display().ToString();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Display_DisplayRogueHeroStateCorrectly_DisplayCorrectHeroState()
        {
            // Arrange
            string heroName = "RogueName";
            Hero myHero = new Rogue(heroName);
            var weaponDamage = 5;
            Weapon newWeapon = new Weapon("Dagger", 1, Weapon.WeaponType.Dagger, weaponDamage);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Armor newArmor = new Armor("Leather", 1, Item.Slot.Body, Armor.ArmorType.Leather, armorAttribute);
            myHero.EquipWeapon(newWeapon);
            myHero.EquipArmor(newArmor);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Dexterity + armorAttribute.Dexterity;
            var heroDamage = weaponDamage * (1 + (decimal)totalAttributes.Dexterity / 100);
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Name: " + heroName);
            stringBuilder.AppendLine("Class: " + myHero.HeroType);
            stringBuilder.AppendLine("Total Strength: " + totalAttributes.Strength);
            stringBuilder.AppendLine("Total dexterity: " + totalAttributes.Dexterity);
            stringBuilder.AppendLine("Total Intelligence: " + totalAttributes.Intelligence);
            stringBuilder.AppendLine("Damage: " + heroDamage);
            var expected = stringBuilder.ToString();

            // Act
            var actual = myHero.Display().ToString();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Display_DisplayWarriorHeroStateCorrectly_DisplayCorrectHeroState()
        {
            // Arrange
            string heroName = "WarriorName";
            Hero myHero = new Warrior(heroName);
            var weaponDamage = 5;
            Weapon newWeapon = new Weapon("Axe", 1, Weapon.WeaponType.Axe, weaponDamage);
            LevelAttribute armorAttribute = new LevelAttribute { Strength = 12, Dexterity = 1, Intelligence = 1 };
            Armor newArmor = new Armor("Mail", 1, Item.Slot.Body, Armor.ArmorType.Mail, armorAttribute);
            myHero.EquipWeapon(newWeapon);
            myHero.EquipArmor(newArmor);
            LevelAttribute totalAttributes = myHero.TotalAttributes();
            int heroDamageAttribute = totalAttributes.Strength + armorAttribute.Strength;
            var heroDamage = weaponDamage * (1 + (decimal)totalAttributes.Strength / 100);
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Name: " + heroName);
            stringBuilder.AppendLine("Class: " + myHero.HeroType);
            stringBuilder.AppendLine("Total Strength: " + totalAttributes.Strength);
            stringBuilder.AppendLine("Total dexterity: " + totalAttributes.Dexterity);
            stringBuilder.AppendLine("Total Intelligence: " + totalAttributes.Intelligence);
            stringBuilder.AppendLine("Damage: " + heroDamage);
            var expected = stringBuilder.ToString();

            // Act
            var actual = myHero.Display().ToString();

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}