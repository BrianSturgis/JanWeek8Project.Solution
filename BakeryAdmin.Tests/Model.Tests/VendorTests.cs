using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryAdmin.Models;
using System.Collections.Generic;
using System;

namespace BakeryAdmin.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor","test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "Test description";
      Vendor newVendor = new Vendor(description,name);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string description = "Test description";
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(description,name);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Work";
      string name02 = "School";
      string description01 = "Recurring twice weekly bread loaf order";
      string description02 = "New Relic Gala event";
      Vendor newVendor1 = new Vendor(name01,description01);
      Vendor newVendor2 = new Vendor(name02,description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Work";
      string name02 = "School";
      string description01 = "Recurring twice weekly bread loaf order";
      string description02 = "New Relic Gala event";
      Vendor newVendor1 = new Vendor(name01,description01);
      Vendor newVendor2 = new Vendor(name02,description02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      DateTime orderDate01 = new DateTime(2020,12,25);
      orderDate01.ToString();
      int invoiceTotal01 = 220;
      string orderTitle01 = "Allora Cafe food";
      string description = "veggies";
      int breadQuantity01 = 20;
      int pastryQuantity01 = 40;
      Order newOrder = new Order(orderDate01,invoiceTotal01,description,orderTitle01,breadQuantity01,pastryQuantity01);
      List<Order> newList = new List<Order> { newOrder };
      string description01 = "Recurring twice weekly bread loaf order";
      string name = "Work";
      Vendor newVendor = new Vendor(name,description01);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }


  }
}