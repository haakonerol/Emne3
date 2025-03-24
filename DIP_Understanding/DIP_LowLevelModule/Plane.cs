using DIP_Abstraction;

namespace DIP_LowLevelModule;

public class Plane:IVehicle
{
    public void Fire()
    {
        Console.WriteLine("Fire from Plane");
    }

    public void Move()
    {
        Console.WriteLine("Plane on the move");
    }
}