using System;

namespace VendorPage.Models
{
  public class BreadOrder
  {
    public int Loaves { get; set; }

    public BreadOrder(int loaves)
    {
      Loaves = loaves;
    }

    public int GetCost(int loaves)
    {
      int cost = 0;
      int discountLoaves = 0;
      if (loaves % 3 == 0)
      {
        discountLoaves = loaves / 3;
      }
      else
      {
        int remainder = loaves % 3;
        discountLoaves = (loaves - remainder) / 3;
      }

      if (loaves < 2)
      {
        cost = loaves * 5;
      }
      else if (loaves >= 2)
      {
        cost = (loaves - discountLoaves) * 5;
      }
      return cost;
    }

  }
}