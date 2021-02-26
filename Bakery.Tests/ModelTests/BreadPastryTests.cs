using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Price_GetPriceOfBread_Int()
    {
      Assert.AreEqual(5, Bread.Price(1));
    }

    // [TestMethod]
    // public void Price_GetPriceOfBreadWithDeal_Int()
    // {
    //   Bread newOrder = new Bread(5);
    //   int result = newOrder.Price();
    //   Assert.AreEqual(20, result);
    // }
  }



  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Price_GetPriceOfPastry_Int()
    {
      Assert.AreEqual(2, Pastry.Price(1));
    }

    [TestMethod]
    public void Price_GetPriceOfPastryWithDeal_Int()
    {
      Assert.AreEqual(5, Pastry.Price(3));
    }

    [TestMethod]
    public void Price_GetPricePlusOneWithDeal_Int()
    {
      Assert.AreEqual(12, Pastry.Price(7));
    }

    [TestMethod]
    public void Price_GetPricePlusTwoWithDeal_Int()
    {
      Assert.AreEqual(14, Pastry.Price(8));
    }
  }
}