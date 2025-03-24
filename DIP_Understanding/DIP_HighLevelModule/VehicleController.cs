using DIP_Abstraction;

namespace DIP_HighLevelModule;

public class VehicleController
{
    private IVehicle _vehicle;

    public VehicleController(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }

    public void FireToEnemy()
    {
        _vehicle.Fire();
    }

    public void MoveToSomewhere()
    {
        _vehicle.Move();
    }

}