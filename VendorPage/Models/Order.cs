using System.Collections.Generic;

namespace VendorPage.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; set; }
    private static List<Order> _intances = new List<Order> {};

    public Order(string orderDescription, int orderPrice, string orderDate)
    {
      Description = orderDescription;
      Price = orderPrice;
      Date = "Jan 15";
      _intances.Add(this);
      Id = _intances.Count;
    }

    public static List<Order> GetAll()
    {
      return _intances;
    }

    public static void ClearAll()
    {
      _intances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _intances[searchId-1];
    }
  }
}