namespace Bankapp;

public class Bank
{
   Customer _currentCustomer;

   public Bank()
   {
      _currentCustomer = new Customer("John Doe");
      BankMenu();
   }

   void BankMenu()
   {
      Console.WriteLine($"Welcome to the Bank app {_currentCustomer.GetCustomerName()}!");
      Console.WriteLine("1. Deposit money");
      Console.WriteLine("2. Withdraw money");
      Console.WriteLine("3. Pay bill");
      Console.WriteLine("4. Transfer money to savings");
      Console.WriteLine("5. Check account balance");
      Console.WriteLine("6. Exit");
      var input = Console.ReadLine();

      switch (input)
      {
         case "1":
            break;
         case "2":
            break;
         case "3":
            break;
         case "4":
            break;
         case "5":
            break;
         case "6":
            break;
         default:
            break;
      }
   }
}