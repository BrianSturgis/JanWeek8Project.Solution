using Microsoft.AspNetCore.Mvc;
using BakeryAdmin.Models;
using System.Collections.Generic;

namespace BakeryAdmin.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/Orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
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
      return RedirectToAction("Index");
    }
    [HttpPost("/Orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }

  }
}