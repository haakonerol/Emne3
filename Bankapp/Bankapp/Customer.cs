namespace Bankapp;

public class Customer
{
    string _customerName;
    string _socialSecurityNumber;
    Account _savingsAccount;
    Account _currentAccount;

    public Customer(string customerName)
    {
        _customerName=customerName;
        _savingsAccount = new Account("Savings", true);
        _currentAccount = new Account("Current", false);
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void Withdraw(int amount,bool fromSavings)
    {
        if (fromSavings)
        {
            _savingsAccount.WithdrawMoney(amount);
        }
        else
        {
            _currentAccount.WithdrawMoney(amount);
        }
    }

    public void DepositToSavingsAccount(int amount)
    {
        _savingsAccount.DepositMoney(amount);
    }
    public void DepositToCurrentAccount(int amount)
    {
        _currentAccount.DepositMoney(amount);
    }
}