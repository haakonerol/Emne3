using System.ComponentModel.Design;

namespace PokemonApp;

public class PokemonWorld
{
    public Trainer MyTrainer { get; private set; }
    public List<Pokemon> WildPokemons { get; private set; }
    Random Rnd = new Random();

    public PokemonWorld()
    {
        MyTrainer = new Trainer("Ash",this);
        WildPokemons=new List<Pokemon>
        {
            new Pokemon(5, "Ikachu", "Mud",23),
            new Pokemon(10, "Charmander", "Grass",32),
            new Pokemon(7, "Squirtle", "Water",11),
            new Pokemon(8, "Bulbasaur", "Grass",12),
            new Pokemon(12, "Jigglypuff", "Mud",11),
            new Pokemon(15, "Pidgey", "Water",9)
        };
        Menu();
    }

    public void Menu()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Welcome to Pokemon World");
            Console.WriteLine("1. Go to wilderness");
            Console.WriteLine("2. Go to store");
            Console.WriteLine("3. Go to pokegym");
            Console.WriteLine("4. Exit");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    var foundPokemon=MyTrainer.GotoWilderness();
                    Console.WriteLine($"You found {foundPokemon.Name} ");
                    Console.WriteLine("Do you want to fight(f) or catch(c)?");
                    var answer = Console.ReadLine();
                    if (answer.ToLower() == "f")
                    {
                        MyTrainer.BattlePokemon(foundPokemon);
                    }
                    else
                    {
                        MyTrainer.CatchPokemon(foundPokemon);
                    }
                    break;
                case "2":
                    MyTrainer.EnterStore();
                    break;
                case "3":
                    MyTrainer.GoToGym();
                    break;
                case "4":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
    }

    public Pokemon GetRandomPokemon(string wilderness)
    {
       var selectedPokemons= WildPokemons.Where(pokemon=>pokemon.Type==wilderness).ToList();
       var randIndex=Rnd.Next(0,selectedPokemons.Count);
       return selectedPokemons[randIndex];
    }
}