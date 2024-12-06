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
        
    }
    
    
    public void ShopMenu()
    {
        int attempts = 4;
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nWelcome to the Car Shop!");
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Show all cars");
            Console.WriteLine("2. Show all cars by year");
            Console.WriteLine("3. Show all cars by kilometers");
            Console.WriteLine("4. Exit from menu");

            int choice;
            
            // int.TryParse(Console.ReadLine(), out choice);
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                attempts--;
                if (attempts == 0)
                {
                    exit = true;
                    Console.WriteLine("Exiting. Goodbye!");
                    break;
                }
                Console.WriteLine("\nPlease input a valid choice");
                Console.WriteLine($"!!! You have {attempts} attempts left.!!!");
                Console.WriteLine("*-----------------------------*");
                continue;
            }

            Car selectedCar = null;
            switch (choice)
            {
                case 1:
                    ShowAllCars();
                    selectedCar = SelectCar();
                    if(selectedCar!=null)BuyCar(selectedCar);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    exit = true;
                    Console.WriteLine("Exiting. Goodbye!");
                    break;
                default:
                    Console.WriteLine("That is not a valid option");
                    Console.WriteLine("Please try again");
                    continue;
            }

 
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
        _cars.Remove(car);
        Console.WriteLine($"\nYou bought {car.Brand} {car.Model} {car.Year}");
    }
    
    int selectedCarId;

    public Car SelectCar()
    {
        
        Car car= null;
        Console.WriteLine("Do you buy one?(y/n)");
        var userInput = Console.ReadKey();
        if (userInput.KeyChar == 'y')
        {
            Console.WriteLine("\nPlease select Car Id");
            if (!int.TryParse(Console.ReadLine(), out selectedCarId) ||
                selectedCarId < _cars.Count || selectedCarId > _cars.Count)
            {
                Console.WriteLine("\nPlease input a valid choice");
                ShowAllCars();
            }
            car = _cars.First(c => c.CarId == selectedCarId);
        }else if (userInput.KeyChar == 'n') ShopMenu();
        else
        {
            Console.WriteLine($"{userInput.KeyChar} is an invalid input");
            ShowAllCars();
        }
        return car;
    }
    
    

    
}

