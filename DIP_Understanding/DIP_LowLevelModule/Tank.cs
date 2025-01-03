using DIP_Abstraction;

namespace DIP_LowLevelModule;

public class Tank:IVehicle
{
    public void Fire()
    {
        Console.WriteLine("Fire from Tank");
    }

    public void Move()
    {
        Console.WriteLine("Tank on the move");
    }
}