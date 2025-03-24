namespace ConsoleApp1;

class Program
{
    /* function main(){
         console.log("Hello World!");
     }*/
    static void Main(string[] args)
    {
        string text="Hei på deg";
        Console.WriteLine(text);
        int number = 5;
        number = 11;
        Console.WriteLine(number);
        bool boolean = true;
        float f= 3.14f;
        double d = 3.14;
        char c = 'a';
        Console.WriteLine(d);
        var text2 = "1234";
        var f2= 3.14f;
        var d2 = 3.14;
        var c2 = 'a';
        var number2 = 5;
        number2 = Convert.ToInt32(text2);
        Console.WriteLine(number2);
        var num = GetNumber();
        Console.WriteLine(num);
    }

    static int GetNumber()
    {
        return 5;
    }
}