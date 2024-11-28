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
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
    
}