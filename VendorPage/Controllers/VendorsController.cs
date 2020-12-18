using Microsoft.AspNetCore.Mvc;
using VendorPage.Models;

namespace VendorPage.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}