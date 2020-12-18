using System.Collections.Generic;

namespace VendorPage.Models
{
  public class Order
  {
    public string Description { get; set; }

    public Order(string description)
    {
      Description = "Not Bakery order";
    }

  }
}