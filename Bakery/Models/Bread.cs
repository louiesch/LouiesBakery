using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int OrderNum {get; set;}
    public int OrderCost {get; set;}

    public Bread(int order)
    {
      OrderNum = order;
      OrderCost = order * 5;
    }

    public int Price()
    {
      return OrderCost;
    }
  }
}