namespace Bankapp;

public class Account
{ 
     int _balance;
     string _accountName;
     bool _savingsAccount;
     string _accountNumber;
     string[] _accountTransactions;

     public Account( string accountName, bool isSavingsAccount)
     {
          _balance = 10000;
          _accountName = accountName;
          _savingsAccount = isSavingsAccount;
          _accountNumber = new Guid().ToString();
          _accountTransactions = new string[100];
     }

     public void DepositMoney(int amount)
     {
          _balance += amount;
     }

     public void WithdrawMoney(int amount)
     {
          if (_balance >= amount)
          { 
               _balance -= amount;
          }
          else
          {
               Console.WriteLine("Not enough money on this account");
          }
     }
}