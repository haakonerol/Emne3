namespace Bankapp;

public class Bill
{
    public int Id { get; private set; }
    public int Amount{get; private set;}
    public string AccountNumber{get;private set;}
    public string KidNr{get;private set;}
    public string Sender{get;private set;}
    public DateTime PayDate{get;private set;}

    public Bill(int billId,string kidNr,int billAmount, string billSender, DateTime billDate)
    {
        Id = billId;
       Amount = billAmount;
       KidNr = kidNr;
       Sender = billSender;
       PayDate = billDate;
    }
}