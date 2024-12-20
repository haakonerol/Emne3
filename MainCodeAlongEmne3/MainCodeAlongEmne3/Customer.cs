namespace MainCodeAlongEmne3;

public class Customer
{
    public Id CustomerId{ get; set; }
    public bool IsLooklikeOlderThen25 {get; set;}
    public List<Item> Chart { get; set; }

    public Customer(Id customerId, bool isLooklikeOlderThen25, List<Item> chart)
    {
        CustomerId = customerId;
        IsLooklikeOlderThen25 = isLooklikeOlderThen25;
        Chart = chart;
    }

    public void BuyAlch()
    {
        Console.WriteLine("Takk i like måte. Ha det");
    }
}