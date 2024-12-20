namespace MainCodeAlongEmne3;

public class Employee
{
    public string Name { get; set; }
    public Rimi RimiSinsen { get; set; }

    public Employee(string name, Rimi rimi)
    {
        Name = name;
        RimiSinsen = rimi;
    }

    public void CheckIdToSellAlch(Customer customer)
    {
        string item = customer.Chart.Where(item => item.IsAlcohole).ToString();
        Console.WriteLine(item);

        if (customer.CustomerId.Age >= 18)
        {
            SellAlch(customer);
        }
        else
        {
            Console.WriteLine($"You can't buy this {item}");
        }
    }

    public void SellAlch(Customer customer)
    {
        string item = customer.Chart.Where(item => item.IsAlcohole).ToString();
        Console.WriteLine($"Takk og god jul {customer.CustomerId.Name}");
        Console.WriteLine($"You bought {item}");
        customer.BuyAlch();
    }
}