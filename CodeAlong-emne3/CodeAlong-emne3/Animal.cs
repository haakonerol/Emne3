namespace CodeAlong_emne3;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Race { get; set; }

    public Animal(string name, int age, string race)
    {
        Name = name;
        Age = age;
        Race = race;
    }
}