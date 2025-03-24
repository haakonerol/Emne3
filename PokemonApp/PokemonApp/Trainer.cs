namespace PokemonApp;

public class Trainer
{
    public PokemonWorld MyWorld { get; private set; }
    public List<string> Inventory { get; private set; }
    public Pokemon StartPokemon { get; private set; }
    public string TrainerName { get; private set; }

    public Trainer(string trainerName, PokemonWorld myWorld)
    {
        TrainerName = trainerName;
        StartPokemon = new Pokemon(7,"Pikachu","Lightning",12);
        Inventory = new List<string>();
        MyWorld = myWorld;
    }

    public Pokemon GotoWilderness()
    {

        while (true)
        {
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine("1. Go to Grass");
            Console.WriteLine("2. Go to Mud");
            Console.WriteLine("3. Go to Water");
            var input = Console.ReadLine();
            if (input == "1")
            {
               return MyWorld.GetRandomPokemon("Grass");
            }
            else if (input == "2")
            {
                MyWorld.GetRandomPokemon("Mud");
            }
            else
            {
                MyWorld.GetRandomPokemon("Water");
            }
        }

    }

    public void BattlePokemon(Pokemon pokemonToFight)
    {
        while (pokemonToFight.Health > 0)
        {
            StartPokemon.Fight(pokemonToFight);
            pokemonToFight.Fight(StartPokemon);
        }
    }

    public void CatchPokemon(Pokemon pokemonToCatch)
    {

    }

    public void EnterStore()
    {

    }

    public void GoToGym()
    {

    }
}