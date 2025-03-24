using System.Threading.Channels;

namespace ConsoleApp4;

internal class Program
{
    private static void Main(string[] args)
    {
        var random = new Random();
        var randomNumber = random.Next(1, 4);
        Console.Write("Would you like to a new hobby? (y/n)");
        var input1 = Console.ReadKey();
        Console.WriteLine();
        // Console.WriteLine(randomNumber);
        // Console.WriteLine(ConsoleKey.Y);
        if (input1.Key == ConsoleKey.Y)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine($"{name} is now a magician.Poof, magic!");
                    break;
                case 2:
                    Console.WriteLine($" Don't laugh...but {name} is now an official toad-onlick'er. Sorry.");
                    break;
                case 3:
                    Console.WriteLine($"{name} is now a philatelist. Would you come over!");
                    break;
            }
        }
        else if (input1.Key == ConsoleKey.N)
        {
            Console.WriteLine("Ok. Maybe next time.");
        }
    }
}