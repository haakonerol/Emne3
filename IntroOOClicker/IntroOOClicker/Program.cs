namespace IntroOOClicker;

class Program
{
    static void Main(string[] args)
    {
      // StaticClicker3.Run();
      
      // var clicker = new Clicker();
      // while (true)
      // {
      //     clicker.Show();
      //     var key = Console.ReadKey(true);
      //     clicker.HandleCommand(key);
      // }

      var clickers = new Clicker1[]
      {
          new Clicker1('a'),
          new Clicker1('b'),
          new Clicker1('c'),
          new Clicker1('d'),
      };
      while (true)
      {
          Console.Clear();
          foreach (var clicker in clickers)
          {
              clicker.Show();
          }
          var cmdKey=Console.ReadKey(true);
          foreach (var clicker in clickers)
          {
              clicker.HandleCommand(cmdKey);
          }
          
      }
    }
}