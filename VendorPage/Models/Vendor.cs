using System.Collections.Generic;

namespace VendorPage.Models
{

  public class Vendor
  {

      public string Name { get; set; }
      public string Description { get; set; }

      public Vendor(string vendorName, string vendorDescription)
      {
        Name = vendorName;
        Description = vendorDescription;
      }
  }
}