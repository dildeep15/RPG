
using RPGHeroes;
/// <summary>
/// The base abstract Hero class to encapsulate all the shared functionality (fields and methods).
/// </summary>
abstract public class Hero
{
    public Hero(string name)
    {
        Name = name;
    }

    public string Name;
    public Dictionary<string, int> Level;
    public Dictionary<string, int> LevelUpAttribute;
}