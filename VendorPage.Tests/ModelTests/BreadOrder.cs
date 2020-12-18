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
  }
}
