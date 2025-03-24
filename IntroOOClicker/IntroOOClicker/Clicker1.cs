namespace IntroOOClicker;

public class Clicker1
{
    public int Points;
    public int Upgrades;
    public char Character;

    public Clicker1(char character)
    {
        Upgrades = 1;
        Character = character;
        
    }
    
    public void Show()
    {
        Console.WriteLine($"Klikker {char.ToUpper(Character)}: Du har {Points} poeng. ({Character}=klikk, {char.ToUpper(Character)}=upgrade)");
    }

    public void HandleCommand(ConsoleKeyInfo cmdKey)
    {
        if (cmdKey.KeyChar == Character)
        {
            Points += Upgrades;
        }
        else if (cmdKey.KeyChar == char.ToUpper(Character))
        {
            if (Points >= 10)
            {
                Points -= 10;
                Upgrades++;
            }
        }
    }
}