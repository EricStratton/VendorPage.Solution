using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorPage.Models;

namespace VendorPage.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test Vendor", "Test Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "Test Description");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor (name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result); 
    }
    
    [TestMethod]
    public void Find_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Pierre";
      string name02 = "Steve";
      string description01 = "Impatient";
      string description02 = "Very Impatient";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendorById_Vendor()
    {
      string name01 = "Pierre";
      string name02 = "Steve";
      string description01 = "Impatient";
      string description02 = "Very Impatient";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_PlacesAnOrderWithinAVendorProfile_OrderList()
    {
      string description = "Impatient";
      Order newOrder = new Order(description);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Pierre";
      Vendor newVendor = new Vendor(name, "Test description");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}