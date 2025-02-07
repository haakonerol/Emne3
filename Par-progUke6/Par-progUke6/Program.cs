namespace Par_progUke6;

class Program
{
    static void Main(string[] args)
    {
        List<Child> children = new List<Child>()
        {
            new Child("Charlotte", true, new List<string> { "Toy Car" }, true),
            new Child("William", true, new List<string> { "Video Game", "Lego Set" }, false),
            new Child("Sophia", true, new List<string> { "Plush Toy" }, false),
            new Child("Lucas", false, new List<string> { "Bicycle" }, true),
            new Child("Ella", true, new List<string> { "Board Game", "Art Supplies" }, true),
            new Child("Henry", false, new List<string> { "Puzzle", "Books" }, false),
            new Child("Emma", true, new List<string> { "Dollhouse", "Plush Toy" }, true),
            new Child("James", true, new List<string> { "Lego Set" }, false),
            new Child("Mia", false, new List<string> { "Toy Car", "Puzzle" }, true),
            new Child("Oliver", true, new List<string> { "Art Supplies", "Board Game", "Books" }, false),

        };
        var myElf=new Elf();
        var mySanta = new Santa();
        myElf.PerformMagic();
        mySanta.PerformMagic();
    }
}