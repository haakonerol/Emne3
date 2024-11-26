namespace Model_yourself;

public class Model
{
    public string name;
    public string introText;
    public string hobby;

    public Model(string newName, string newIntroText, string newHobby)
    {
        name=newName;
        introText=newIntroText;
        hobby=newHobby;
    }

    public void PrintPerson()
    {
        Console.WriteLine(introText);
        Console.WriteLine($"{name} er opptat av {hobby}");
    }
    
}

 
 