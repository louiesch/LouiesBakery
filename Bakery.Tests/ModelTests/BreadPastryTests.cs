using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadPrice_GetPriceOfBread_Int()
    {
      int breadOrder = 1;
      Bread newBreadOrder = new Bread(breadOrder);
      int result = newBreadOrder.BreadPrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void BreadPrice_GetPriceOfBreadWithDeal_Int()
    {
      int breadOrder = 3;
      Bread newBreadOrder = new Bread(breadOrder);
      int result = newBreadOrder.BreadPrice();
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void BreadPrice_GetPriceOfLotsOfBreadWithDeal_Int()
    {
      int breadOrder = 6;
      Bread newBreadOrder = new Bread(breadOrder);
      int result = newBreadOrder.BreadPrice();
      Assert.AreEqual(20, result);
    }
  }



  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryPrice_GetPriceOfPastry_Int()
    {
      int pastryOrder = 1;
      Pastry newPastryOrder = new Pastry(pastryOrder);
      int result = newPastryOrder.PastryPrice();
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void PastryPrice_GetPriceOfPastryWithDeal_Int()
    {
      int pastryOrder = 3;
      Pastry newPastryOrder = new Pastry(pastryOrder);
      int result = newPastryOrder.PastryPrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void PastryPrice_GetPricePlusOneWithDeal_Int()
    {
      int pastryOrder = 7;
      Pastry newPastryOrder = new Pastry(pastryOrder);
      int result = newPastryOrder.PastryPrice();
      Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void PastryPrice_GetPricePlusTwoWithDeal_Int()
    {
      int pastryOrder = 8;
      Pastry newPastryOrder = new Pastry(pastryOrder);
      int result = newPastryOrder.PastryPrice();
      Assert.AreEqual(14, result);
    }
  }
}