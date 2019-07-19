using System;
using Patisserie.Loaf;



namespace Patisserie
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("How many loaves of bread would you like? Each loaf is $5 each. We also have a buy 2 get 1 free deal.");
      int BreadInput = int.Parse(Console.ReadLine());
      Console.WriteLine("How many Pastries would you like? Pastries are $2 each or $5 for 3.");
      int PastryInput = int.Parse(Console.ReadLine());

      Bread bread = new Bread(BreadInput);
      Pastry pastry = new Pastry(PastryInput);
      int TotalPrice = bread.BreadTotal + pastry.PastryTotal;

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Your Bread comes out to $" + bread.BreadTotal);
      Console.WriteLine("Your Pastries comes out to $" + pastry.PastryTotal);
      Console.WriteLine("You owe $" + TotalPrice);

      Console.ResetColor();







    }
  }
}
