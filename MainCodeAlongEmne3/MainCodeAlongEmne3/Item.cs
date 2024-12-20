namespace MainCodeAlongEmne3;

public class Item
{
    public string ItemName { get; set; }
    public bool IsAlcohole { get; set; }
    public int Price { get; set; }

    public Item(string itemName,  bool isAlcohole, int price)
    {
        ItemName = itemName;
        IsAlcohole = isAlcohole;
        Price = price;
    }
}