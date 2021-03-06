using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryAdmin.Models;

namespace BakeryAdmin.Controllers
{
  public class VendorsController : Controller
  {
  [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorDescription, string vendorName)
    {
      Vendor newVendor = new Vendor(vendorDescription,vendorName);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendors", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(DateTime orderDate,int vendorId,int invoiceTotal, string orderTitle, string description, int quantityBread, int quantityPastry)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDate,invoiceTotal,orderTitle,description,quantityBread,quantityPastry);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendors", foundVendor);
      return View("Show", model);
    }
  }
}