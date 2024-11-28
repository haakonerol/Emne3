namespace Bankapp;

public class Account
{ 
     int _balance;
     string _accountName;
     bool _isSavingsAccount;
     string _accountNumber;
     string[] _accountTransactions;

     public void DepositMoney(int amount)
     {
          _balance += amount;
     }
}