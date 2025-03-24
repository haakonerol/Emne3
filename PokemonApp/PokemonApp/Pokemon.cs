namespace PokemonApp;

public class Pokemon
{
    public int Level { get; private set; }
    public string Name { get; private set; }
    public string Type { get; private set; }
    public int Health { get; private set; }
    public int Strength { get; private set; }

    public Pokemon(int level, string name, string type, int strength)
    {
        Level = level;
        Name = name;
        Type = type;
        Health = 100;
        Strength = strength;
    }

    public void Fight(Pokemon opponent)
    {
        opponent.LooseHealth(Strength);
    }

    public void LooseHealth(int strength)
    {
        Health -= strength;
    }
}