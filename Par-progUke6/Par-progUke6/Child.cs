namespace Par_progUke6;

public class Child
{
    public string Name { get; set; }
    public bool IsNice { get; set; }
    public List<string> Wishes { get; set; }
    public bool RecievedGift { get; set; }

    public Child(string name, bool isNice, List<string> wishes, bool recievedGift)
    {
        Name = name;
        IsNice = isNice;
        Wishes = wishes;
        RecievedGift = recievedGift;
    }
}