using System.Net;
using Microsoft.AspNetCore.Mvc;
using BakeryAdmin.Models;
using System.Collections.Generic;

namespace BakeryAdmin.Controllers
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
