using DIP_Abstraction;
using DIP_LowLevelModule;
using DIP_HighLevelModule;

namespace DIP_Client;

class Program
{
    static void Main(string[] args)
    {
        IVehicle vehicle = new Tank();
        VehicleController lee=new VehicleController(vehicle);
        lee.FireToEnemy();
        lee.MoveToSomewhere();
    }
}