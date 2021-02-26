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
      Bread newOrder = new Bread(5);
      int result = newOrder.Price();
      Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void Price_GetPriceOfBreadWithDeal_Int()
    {
      Bread newOrder = new Bread(3);
      int result = newOrder.Price();
      Assert.AreEqual(10, result);
    }
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
  }
}