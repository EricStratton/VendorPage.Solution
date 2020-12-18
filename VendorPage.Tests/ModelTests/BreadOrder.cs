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
      BreadOrder newBreadOrder = new BreadOrder();
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }
  }
}
