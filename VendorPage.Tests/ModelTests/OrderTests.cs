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
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}