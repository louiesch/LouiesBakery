using System;
using Bakery.Models;
using System.Collections.Generic;

namespace BakeryClerk
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hi there, welcome to Louie's Bakery! Here for my delicious bread and pastries, I suppose? (type in 'yes' or 'no'");
      string userInput = Console.ReadLine();
      if (userInput == "no")
      {
        Console.WriteLine("Then get outta here! Go on, scram!");
      }
      else if (userInput == "yes")
      {
        Console.WriteLine("Great! Bread is $5 a loaf. But just for you, with this limited time offer, buy 2 loaves and get 1 free! The pastries are $2 each, but if you buy 3 at a time I'll bump the price down to $5!");
      }
    }
  }
}