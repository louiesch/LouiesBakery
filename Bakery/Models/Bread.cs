using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumBread {get; set;}
    public int PriceBread {get; set;}

    public Bread(int order)
    {
      NumBread = order;
      PriceBread = order * 5;
    }

    public int Price()
    {
      if (NumBread % 3 == 0)
      {
        int OrderTotal = (NumBread - (NumBread / 3)) * 5;
        return OrderTotal;
      }
      else
      {
        return PriceBread;
      }
    }
  }
}