using Microsoft.AspNetCore.Mvc;
using BakeryAdmin.Models;

namespace BakeryAdmin.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Order starterOrder = new Order("Add first order for the bakery");
      return View(starterOrder);
    }

  }
}