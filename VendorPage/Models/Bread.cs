using System;

namespace VendorPage.Models
{
  public class BreadOrder
  {
    public int Loaves { get; set; }

    public BreadOrder(int loaves)
    {
      Loaves = 1;
    }
  }
}