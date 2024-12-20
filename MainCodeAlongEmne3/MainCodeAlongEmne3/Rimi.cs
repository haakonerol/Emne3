namespace MainCodeAlongEmne3;

public class Rimi
{
    public Employee MyEmployee {get; set;}
    public List<Customer> MyCustomers { get; set; }
    public int KlokkaSlett { get; set; }

    public Rimi()
    {
        KlokkaSlett = 19;
        MyEmployee = new Employee("Lars",this);
        MyCustomers = new List<Customer>()
        {
            new Customer(new Id("Ole",19),true,new List<Item>(){new Item("Absolout",true,1200)}),
            new Customer(new Id("Per",29),true,new List<Item>(){new Item("Jonny Walker",true,2200)}),
            new Customer(new Id("Kari",21),false,new List<Item>(){new Item("Absolout",true,1200)}),
            new Customer(new Id("Anna",18),false,new List<Item>(){new Item("Absolout",true,1200)}),
        };

    }

    public void Kasse()
    {

        foreach (Customer customer in MyCustomers)
        {
            var input = "";
            if (customer.Chart.FirstOrDefault(item => item.IsAlcohole) != null) input = "1";
            else input = "2";
            switch (input)
            {
                case "1":
                    if(!customer.IsLooklikeOlderThen25 && KlokkaSlett < 20) MyEmployee.CheckIdToSellAlch(customer);
                    Console.WriteLine("Værsågod Neste!");
                    break;
                case "2":
                    Console.WriteLine("Værsågod Neste!");
                    MyEmployee.SellAlch(customer);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
            Task.Delay(1000).Wait();
        }


    }
}