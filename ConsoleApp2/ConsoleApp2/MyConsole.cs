namespace ConsoleApp2;

internal class MyConsole
{
    public static string Ask(string question)
    {
        Console.Write(question);
        return Console.ReadLine();
    }
}