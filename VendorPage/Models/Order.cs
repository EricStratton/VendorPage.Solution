using System.Collections.Generic;

namespace VendorPage.Models
{
  public class Order
  {
    public string Description { get; set; }
    private static List<Order> _intances = new List<Order> {};

    public Order(string description)
    {
      Description = description;
    }

    // public static List<Order> GetAll()
    // {
    //   return _intances;
    // }
  }
}