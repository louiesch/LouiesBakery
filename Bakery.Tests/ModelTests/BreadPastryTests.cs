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
      int result = newOrder.Cost();
      Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void Price_GetPriceOfBreadWithDeal_Int()
    {

    }
  }



  [TestClass]
  public class PastryTests
  {
    // Test methods go here
  }
}