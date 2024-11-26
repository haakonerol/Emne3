using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        int number = 17;
        long number2 = 2024;
        float number3 = 3.14f;
        double number5 = 3.1415926;
        decimal number4 = 3.14159M;
        string text1 = "Hello World!";
        char vowel = 'a';
        bool isAdmin = true;

        int a = 5;
        decimal b = 3;
        decimal sum = a + b;
        int x, y, z;
        Test1();
        Console.WriteLine(GetSum(3,5));
    }

    static int GetSum(int num1, int num2)
    {
        int total = num1 + num2;
        return total;
    }

    static void Test1()
    {
        Console.WriteLine("Denne metoden returnerer ikke noe verdi");
    }
    
}