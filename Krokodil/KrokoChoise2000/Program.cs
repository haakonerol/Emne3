// See https://aka.ms/new-console-template for more information

//1) Reverser stringen!

//Lag et program hvor du kan skrive inn en tekst, og når du sender teksten inn vil du få tilbake teksten reversert. 
//Gjør dette uten å bruke innebygde reverse metoder
//Bygg videre ved å legge til flere ting man kan gjøre med stringen, eksempel:
//Alternativer for hva man vil gjøre, trykk 1,2 eller 3 for å reversere, konvertere til uppercase eller lowercase

using System.ComponentModel.Design;

Console.WriteLine("Hei, velkommen til applikasjon, skriv inn en teskt og se hva som skjer ! ");


string userInput = Console.ReadLine();
string numberChoice = "";
string reversertTxt = "";
Menu();
void Menu()
{
    Console.WriteLine($"Her er teksen du skrev: {userInput} ");
    Console.WriteLine("tast 1 for å vise reversert Txt");
    Console.WriteLine("tast 2 for å vise lengden på input");
    numberChoice = Console.ReadLine();
    
    if (numberChoice == "1")
    {
        reversedTxt();
        Menu();
    }
    else if (numberChoice == "2")
    {
        showLengthOfInput();
        Menu();
    }

    else
    {
        Console.WriteLine("ikke gyldig input");
        Menu();
    }
    

}









void reversedTxt()
{
    for (int i = userInput.Length - 1; i < userInput.Length; i--)
    {
        reversertTxt += userInput[i];
        if (i == 0)
        {
            Console.WriteLine(printReversedTxt());
            return;
        }
    }

}

void showLengthOfInput()
{
    Console.WriteLine("Lengden på teksten du skrev: " + userInput.Length); 
}



string printReversedTxt()
{
    return $"reversert Text: {reversertTxt}";
}