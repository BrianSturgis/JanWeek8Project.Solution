using Microsoft.AspNetCore.Mvc;
using BakeryAdmin.Models;

namespace BakeryAdmin.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Order starterItem = new Order("Add first item to To Do List");
      return View(starterItem);
    }

  }
}
