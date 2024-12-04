namespace Par_progUke4;

public class CarShop
{
    private List<Car> _cars;

    public CarShop()
    {
        _cars = new List<Car>() 
        { 
            new Car(1,"Ford","Kuga",2020,"BR32452",24000),
            new Car(2,"Toyota","Camry",2021,"BR32968",12000),
            new Car(3,"Subaru","Forester",2022,"HH32232",14000),
            new Car(4,"Ford","Focus",2023,"BR87452",4000),
            new Car(5,"Subaru","Impreza",2024,"BR32489",2000),
        };
        ShopMenu();
    }
    
    
    public void ShopMenu()
    {
        Console.WriteLine("Welcome to the Car Shop!");
        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Show all cars");
        Console.WriteLine("2. Show all cars by year");
        Console.WriteLine("3. Show all cars by kilometers");
        Console.WriteLine("4. Exit from menu");
        
        int choice = int.Parse(Console.ReadLine());
        
        switch (choice)
            {
                case 1:
                    ShowAllCars();
                    Console.WriteLine("Do you buy one?(y/n)");
                    Car car = SelectCar();
                    BuyCar(car);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        

    }
    public void ShowAllCars()
    {
        foreach (var car in _cars)
        {
            Console.WriteLine($"Car Id:{car.CarId}  {car.Brand} {car.Model} {car.Year}");
        }
    }

    public void BuyCar(Car car)
    {
        
    }

    public Car SelectCar()
    {
        Car car= null;
        var userInput = Console.ReadKey();
        if (userInput.KeyChar == 'y')
        {
            Console.WriteLine("Please select Car Id");
            car = _cars.First(c => c.CarId == int.Parse(Console.ReadLine()));
        }
        return car;
    }
    
    

    
}

