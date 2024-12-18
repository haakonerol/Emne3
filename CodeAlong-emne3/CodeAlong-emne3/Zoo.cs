namespace CodeAlong_emne3;

public class Zoo
{
     List<Animal> Animals = new List<Animal>();

     public void ShowMenu()
     {
          bool quit = false;

          while (!quit)
          {
               Console.Write("please enter animal name: ");
               string name = Console.ReadLine();
               Console.Write("please enter animal age: ");
               int age;
               int.TryParse(Console.ReadLine(), out age);
               Console.Write("please enter animal race: ");
               string race = Console.ReadLine();
               Animals.Add(new Animal(name, age, race));
               quit= ExitMenu(quit);
          }

          Animals.ForEach(animal => Console.WriteLine($"Animal name: {animal.Name}, age: {animal.Age}, race: {animal.Race}"));

          ChoseMenu();

     }

     public bool ExitMenu(bool isQuit)
     {
          Console.WriteLine("Do you want to exit from animal adding menu?(y/n)");
          var input = Console.ReadLine();
          if (input == "y")
          {
               isQuit = true;
          }
          else if (input == "n")
          {
               isQuit = false;
          }
          return isQuit;
     }

     public void ChoseMenu()
     {
          Console.WriteLine("1.Show all animals .");
          Console.WriteLine("2.Show animals by race");

          Console.WriteLine("Please enter your choice: ");
          string choice = Console.ReadLine();

          switch (choice)
          {
               case "1":
                    Animals.ForEach(animal => Console.WriteLine($"Animal name: {animal.Name}, age: {animal.Age}, race: {animal.Race}"));
                    break;
               case "2":
                    ShowSelectedAnimals();
                    break;
               default:
                    Console.WriteLine("Please enter a valid choice");
                    break;
          }
     }

     public void ShowSelectedAnimals()
     {
          Console.Write("Select an race: ");
          string race = Console.ReadLine();

          Animal selectedAnimal = Animals.First(animal => animal.Race == race);

          if (selectedAnimal != null)
          {
               Console.WriteLine($"Animal name: {selectedAnimal.Name}, race: {selectedAnimal.Race}");
          }
          else
          {
               Console.WriteLine("There is no animal with that race");
          }

     }
}