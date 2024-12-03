namespace Bankapp;

public class Customer
{
    string _customerName;
    string _socialSecurityNumber;
    Account _savingsAccount;
    Account _currentAccount;
    List<Bill> _bills;

    public Customer(string customerName)
    {
        _customerName=customerName;
        _savingsAccount = new Account("Savings", true);
        _currentAccount = new Account("Current", false);
        _bills = new List<Bill>();
    }

    public Customer(string customerName, bool hasBills)
    {
        _customerName=customerName;
        _savingsAccount = new Account("Savings", true);
        _currentAccount = new Account("Current", false);

        _bills = new List<Bill>() {new Bill(1,"12345",300, "Telenord",new DateTime(2024,12,24)), new Bill(2,"23456",200, "Elvia",new DateTime(2024,12,24)), new Bill(3,"34567",1200, "Storebrand",new DateTime(2024,12,15)), new Bill(4,"45678",3000, "DNB",new DateTime(2025,1,1)) };
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

    public void PrintBills()
    {
        foreach (Bill bill in _bills)
        {
            Console.WriteLine($"BillId:{bill.Id} Kidnr:{bill.KidNr} Amount:{bill.Amount} DueDate:{bill.PayDate.ToShortDateString()}");
        }
    }

    public Bill FindBill(int billId)
    {
        Bill bill = _bills.First(bill => bill.Id == billId);
        return bill;
    }

    public void PayBill(int billId)
    {
        var bill = FindBill(billId);
        _currentAccount.WithdrawMoney(bill.Amount);
        _bills.Remove(bill);
        
    }
}