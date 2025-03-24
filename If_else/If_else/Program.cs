namespace If_else;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("Enter number: ");
     int input1 = int.Parse(Console.ReadLine());
     Console.Write("Enter another number: ");
     int input2 = int.Parse(Console.ReadLine());
     int result = Oppgave2(input1, input2);
     bool result1=Oppgave3(input1, input2);
     string message = result1 ? "\none of the numbers or \nsum of numbers is equal to 30" : "";
     Console.WriteLine($"{result} {result1} {message}" );
    }
    static int Oppgave2(int a, int b)
    {
        if (a != b) return a + b;
        else return a * b;
    }

    static bool Oppgave3(int a, int b)
    {
        if (a == 30||b==30||(a+b)==30) return true;
        else return false;
    }
}