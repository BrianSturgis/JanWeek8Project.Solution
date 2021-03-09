using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryAdmin.Models;
using System.Collections.Generic;
using System;


namespace BakeryAdmin.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      DateTime orderDate = new DateTime(2020,12,25);
      orderDate.ToString();
      Order newOrder = new Order(orderDate,1,"test","test",1,1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      DateTime orderDate = new DateTime(2020,12,25);
      orderDate.ToString();
      int invoiceTotal01 = 220;
      string orderTitle = "Test Title";
      string description = "Walk the dog.";
      int breadQuantity = 20;
      int pastryQuantity = 40;
      Order newOrder = new Order(orderDate,invoiceTotal01,orderTitle,description,breadQuantity,pastryQuantity);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      DateTime orderDate = new DateTime(2020,12,25);
      orderDate.ToString();
      int invoiceTotal01 = 220;
      string orderTitle = "Test Org Holiday Fundraiser";
      string description = "Walk the dog.";
      int breadQuantity = 20;
      int pastryQuantity = 40;
      Order newOrder = new Order(orderDate,invoiceTotal01,orderTitle,description, breadQuantity,pastryQuantity);

      string updatedDescription = "Do the dishes";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      DateTime orderDate01 = new DateTime(2020,12,25);
      orderDate01.ToString();
      DateTime orderDate02 = new DateTime(2020,12,25);
      orderDate02.ToString();
      int invoiceTotal01 = 12;
      int invoiceTotal02 = 12;
      string orderTitle01 = "Cafe Allora";
      string orderTitle02 = "burrito bar";
      string description01 = "stock";
      string description02 = "veggies";
      int breadQuantity01 = 20;
      int pastryQuantity01 = 40;
      int breadQuantity02 = 100;
      int pastryQuantity02 = 100;
      Order newOrder1 = new Order(orderDate01,invoiceTotal01,description01,orderTitle01,breadQuantity01,pastryQuantity01);
      Order newOrder2 = new Order(orderDate02,invoiceTotal02,description02,orderTitle02,breadQuantity02,pastryQuantity02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2, };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      DateTime orderDate01 = new DateTime(2020,12,25);
      orderDate01.ToString();
      int invoiceTotal01 = 12;
      string title = "test title";
      string description = "Walk the dog.";
      int breadQuantity01 = 20;
      int pastryQuantity01 = 40;
      Order newOrder = new Order(orderDate01,invoiceTotal01,description,title,breadQuantity01,pastryQuantity01);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      DateTime orderDate01 = new DateTime(2020,12,25);
      orderDate01.ToString();
      DateTime orderDate02 = new DateTime(2020,12,25);
      orderDate02.ToString();
      int invoiceTotal01 = 220;
      int invoiceTotal02 = 800;
      string orderTitle01 = "Cafe Allora";
      string orderTitle02 = "PAM Gala";
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      int breadQuantity01 = 20;
      int pastryQuantity01 = 40;
      int breadQuantity02 = 100;
      int pastryQuantity02 = 100;
      Order newOrder1 = new Order(orderDate01,invoiceTotal01,description01,orderTitle01,breadQuantity01,pastryQuantity01);
      Order newOrder2 = new Order(orderDate02,invoiceTotal02,description02,orderTitle02,breadQuantity02,pastryQuantity02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
}
}