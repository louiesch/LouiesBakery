using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void OrderCost_GetCostOfBread_Int()
    {
      Bread newOrder = new Bread(5);
      int result = newOrder.Cost();
      Assert.AreEqual(25, result);
    }
  }



  [TestClass]
  public class PastryTests
  {
    // Test methods go here
  }
}