using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorPage.Models;

namespace VendorPage.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderContructor_CreatesIntanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "Baked goods order";
      Order newOrder = new Order(description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}