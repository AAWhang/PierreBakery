using System;
using Patisserie.Loaf;



namespace Patisserie
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.Write("How many Loaves of Bread would you like? Loaves are $5 each. ");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("We also have a buy 2 get 1 free deal.");
      Console.ResetColor();
      bool numCheck = false;
      string BreadInput = Console.ReadLine();
      int BreadNum = 0;
      while (numCheck == false)
      {
        if (int.TryParse(BreadInput, out BreadNum) && BreadNum >= 0)
        {
          numCheck = true;
        } else
        {
          Console.WriteLine("Please enter a valid number.");
          BreadInput = Console.ReadLine();
        }
      }

      Console.Write("How many Pastries would you like? Pastries are $2 each or ");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("$5 for 3.");
      Console.ResetColor();
      string PastryInput = Console.ReadLine();
      int PastryNum = 0;
      numCheck = false;
      while (numCheck == false)
      {
        if (int.TryParse(PastryInput, out PastryNum) && PastryNum >= 0)
        {
          numCheck = true;
        } else
        {
          Console.WriteLine("Please enter a valid number.");
          PastryInput = Console.ReadLine();
        }
      }

      Bread bread = new Bread(BreadNum);
      Pastry pastry = new Pastry(PastryNum);
      int TotalPrice = bread.BreadTotal + pastry.PastryTotal;

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("__________________________________________________");
      Console.WriteLine("Your Bread comes out to $" + bread.BreadTotal);
      Console.WriteLine("Your Pastries comes out to $" + pastry.PastryTotal);
      Console.WriteLine("You owe $" + TotalPrice);

      Console.ResetColor();


    }
  }
}
