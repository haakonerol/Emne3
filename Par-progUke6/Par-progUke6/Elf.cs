namespace Par_progUke6;

public class Elf : Helper
{
    public Elf() : base(false,"Builder",true)
    {

    }

    public override void PerformMagic()
    {
        Console.WriteLine("I'm Elf");
    }
}