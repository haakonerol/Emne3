namespace Par_progUke6;

public class Reindeer : Helper
{
    public Reindeer() : base(true,"Towing",true)
    {

    }
    public override void PerformMagic()
    {
        Console.WriteLine("I'm Reindeer");
    }
}