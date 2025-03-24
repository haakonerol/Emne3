namespace Reverser_string;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter text:");
        var input=Console.ReadLine();

        Console.WriteLine(input.Length - 1);
        

        var reversed = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed+= input[i];
            
        }
        Console.WriteLine(reversed);
    }
}