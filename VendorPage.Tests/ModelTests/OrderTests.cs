using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorPage.Models;

namespace VendorPage.Tests 
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderContructor_CreatesIntanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Description", 0, "Dec 21");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "Baked goods order";
      Order newOrder = new Order(description, 0, "Dec 21");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      string description = "Baked goods order";
      int price = 15;
      Order newOrder = new Order(description, price, "Dec 21");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    
    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      string description = "Baked goods order";
      int price = 15;
      string date = "Dec 21";
      Order newOrder = new Order(description, price, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnOrderList_OrderList()
    {
      string description01 = "Baked goods order";
      string description02 = "Bread order";
      Order newOrder1 = new Order(description01, 0, "Dec 21");
      Order newOrder2 = new Order(description02, 1, "Dec 22");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsCorrectOrderById_Order()
    {
      string description01 = "Baked goods order";
      string description02 = "Bread order";
      Order newOrder1 = new Order(description01, 0, "Dec 21");
      Order newOrder2 = new Order(description02, 1, "Dec 22");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}