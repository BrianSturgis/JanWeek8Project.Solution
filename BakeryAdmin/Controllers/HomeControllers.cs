using System.Net;
using Microsoft.AspNetCore.Mvc;
using BakeryAdmin.Models;

namespace BakeryAdmin.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Order starterItem = new Order("Add an order ");
      return View(starterItem);
    }
    
    [HttpGet("/Orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/Orders")]
    public ActionResult Create(string description)
    {
      Order myOrder = new Order(description);
      return View("Index", myOrder);
    }
  }
}
