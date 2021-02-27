using System;
using Bakery.Models;


namespace BakeryClerk
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hi there, welcome to Louie's Bakery! Here for my delicious bread and pastries, I suppose? (type 'yes' or 'no')");
      string userInput = Console.ReadLine();
        if (userInput == "yes")
      {
        Console.WriteLine("Great! Bread is $5 a loaf. But just for you, with this limited time offer, buy 2 loaves and get 1 free! So how many loaves for you today?");
        int breadInput = int.Parse(Console.ReadLine());
        Console.WriteLine($"Alright, so {breadInput} loaves today!");
        
        Console.WriteLine($"How about pastries, any of those? They're $2 each, but if you buy 3 at a time I'll bump the price down to $5 per bundle.");
        int pastryInput = int.Parse(Console.ReadLine());
        Console.WriteLine($"Alright, so {pastryInput} pastries today!");        
        
        Console.WriteLine($"If you're all done shopping, the bread will be ${Bread.Price(breadInput)} and the pastries ${Pastry.Price(pastryInput)}. That brings your total to ${Bread.Price(breadInput) + Pastry.Price(pastryInput)}. Thank you, and have a great day!");
      }
      else if (userInput == "no")
      {
        Console.WriteLine("Then get outta here! Go on, scram!");
      }


      
    }
  }
}