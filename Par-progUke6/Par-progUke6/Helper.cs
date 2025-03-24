namespace Par_progUke6;

public class Helper:IMagical
{
    public bool IsFlying {get; private set;}
    public string Specialist {get; private set;}
    public bool HelpingSanta {get; private set;}

    public Helper(bool isFlying, string specialist, bool helpingSanta)
    {
        IsFlying = isFlying;
        Specialist = specialist;
        HelpingSanta = helpingSanta;
    }

    public virtual void PerformMagic()
    {

    }
}