using Microsoft.AspNetCore.Mvc;

namespace VendorPage.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}