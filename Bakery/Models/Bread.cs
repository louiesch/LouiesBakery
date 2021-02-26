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

    }

    public int Cost()
    {
      return 0;
    }
  }
}