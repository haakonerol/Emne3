namespace Par_progUke6;

public class Santa : Helper
{
    public Santa() : base(false,"Delivery",true)
    {

    }
    public override void PerformMagic()
    {
        Console.WriteLine("I'm Santa");
    }
}