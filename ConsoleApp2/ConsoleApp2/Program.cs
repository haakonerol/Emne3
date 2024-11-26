namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine($"Du har angitt {args.Length}");
        // foreach (var arg in args)
        // {
        //     Console.WriteLine(arg);
        // }
        
        // Console.Write("Hva heter du? ");
        // string input = Console.ReadLine();
        // Console.WriteLine($"Hei {input}!");
        //
        // Console.Write("Hvor bor du? ");
        // string place = Console.ReadLine();
        // Console.WriteLine($"{place}!");

        var name = MyConsole.Ask("Hei.Hva heter du? ");
        Console.WriteLine($"Velkommen {name}!");
        string place = MyConsole.Ask("Hvor bor du? ");
        Console.WriteLine($"{place}!");
    }
}