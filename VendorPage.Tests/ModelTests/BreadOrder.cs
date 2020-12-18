using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorPage.Models;

namespace VendorPage.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreatesInstanceOfBreadOrder_Order()
    {
      BreadOrder newBreadOrder = new BreadOrder(0);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrder_Int()
    {
      int breadOrder = 3;
      BreadOrder newBreadOrder = new BreadOrder(3);
      int result = newBreadOrder.Loaves;
      Assert.AreEqual(breadOrder, result);
    }

    [TestMethod]
    public void GetCost_ReturnsBreadOrderPriceWithDiscount_Int()
    {
      BreadOrder newBreadOrder = new BreadOrder(13);
      int cost = newBreadOrder.GetCost(newBreadOrder.Loaves);
      Console.WriteLine(cost);
      Assert.AreEqual(45, cost);
    }

    [TestMethod]
    public void GetCost_ReturnsBreadOrderPriceWithoutDiscount_Int()
    {
      BreadOrder newBreadOrder = new BreadOrder(1);
      int cost = newBreadOrder.GetCost(newBreadOrder.Loaves);
      Console.WriteLine(cost);
      Assert.AreEqual(5, cost);
    }

  }
}
