using System.Collections.Generic;

namespace VendorPage.Models
{

  public class Vendor
  {

      public string Name { get; set; }
      public string Description { get; set; }
      public int Id { get; }
      private List<Vendor> _instances = new List<Vendor> {};

      public Vendor(string vendorName, string vendorDescription)
      {
        Name = vendorName;
        Description = vendorDescription;
        _instances.Add(this);
        Id = _instances.Count;
      }
  }
}