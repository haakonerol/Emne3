namespace Model_yourself;

class Program
{
    static void Main(string[] args)
    {
        Model hakan = new Model("hakan", "Hei, jeg heter Hakan! Jeg er 45 år gammel og jeg har svart hår",
            "å lære fullstack");
        
        // hakan.PrintPerson();

        Model kevin = new Model("Kevin", "Hei, jeg heter Kevin! Jeg er 32 år gammel og jeg har svart hår",
            " Å lære C#");
        kevin.PrintPerson();
    }
}