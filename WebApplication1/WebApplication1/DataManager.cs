namespace WebApplication1;

public class DataManager
{
    public static Person[] GetPeople()
    {
        return new Person[]
        {
            new Person{Name="Per", BirthYear=1979},
            new Person{Name="Ole", BirthYear=1983},
        };
    }
}