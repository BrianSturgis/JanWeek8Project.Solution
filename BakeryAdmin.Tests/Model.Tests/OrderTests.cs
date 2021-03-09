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
      Order newOrder = new Order("test","test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string orderTitle = "Test Title";
      string description = "Walk the dog.";
      Order newOrder = new Order(orderTitle,description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string orderTitle = "Test Org Holiday Fundraiser";
      string description = "Walk the dog.";
      Order newOrder = new Order(orderTitle,description);

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
      string orderTitle01 = "Cafe Allora";
      string orderTitle02 = "burrito bar";
      string description01 = "stock";
      string description02 = "veggies";
      Order newOrder1 = new Order(description01,orderTitle01);
      Order newOrder2 = new Order(description02,orderTitle02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2, };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "test title";
      string description = "Walk the dog.";
      Order newOrder = new Order(description,title);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderTitle01 = "Suzie's Cafe";
      string orderTitle02 = "PAM Gala";
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Order newOrder1 = new Order(description01,orderTitle01);
      Order newOrder2 = new Order(description02,orderTitle02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
}
}