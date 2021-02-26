using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int NumPastry {get; set;}
    public int PricePastry {get; set;}

    public Pastry(int order)
    {
      NumPastry = order;
      PricePastry = order * 2;
    }

    public int Price()
    {
      return 0;
    }
  }
}