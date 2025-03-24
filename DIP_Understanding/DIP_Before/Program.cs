namespace DIP_Before;

class Program
{
    static void Main(string[] args)
    {
        Comander lee = new Comander()
        {
            Plane = new Plane(),
            Tank = new Tank()
        };
        lee.VehicleType = VehicleType.Tank;
        lee.FireToEnemy();
        lee.MoveToSomwhere();
        Console.WriteLine();
        lee.VehicleType = VehicleType.Plane;
        lee.FireToEnemy();
        lee.MoveToSomwhere();
    }

}

class Comander
{
    public Tank Tank { get; set; }
    public Plane Plane { get; set; }
    public VehicleType VehicleType { get; set; }

    public void FireToEnemy()
    {
        switch (VehicleType)
        {
            case VehicleType.Plane:
                Plane.Fire();
                break;
            case VehicleType.Tank:
                Tank.Fire();
                break;
        }
    }

    public void MoveToSomwhere()
    {
        switch (VehicleType)
        {
            case VehicleType.Plane:
                Plane.Move();
                break;
            case VehicleType.Tank:
                Tank.Move();
                break;
        }
    }
}

enum VehicleType
{
    Tank,
    Plane
}

class Plane
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

class Tank
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