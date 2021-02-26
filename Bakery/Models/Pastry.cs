using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int NumPastry {get; set;}

    public static int Price(int num)
    {
      int NumPastry = num;
      int price = 2;

      if (NumPastry == 1)
      {
        return num * price;
      }
      else if (NumPastry % 3 == 0)
      {
        return (NumPastry / 3) * 5;
      }
      else if (NumPastry % 3 == 1)
      {
        return ((NumPastry - 1) / 3) * 5 + price;
      }
      else
      {
        return 0;
      }

    }
  }
}