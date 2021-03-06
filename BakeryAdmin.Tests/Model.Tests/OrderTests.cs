using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryAdmin.Models;
using System.Collections.Generic;
using System;


namespace BakeryAdmin.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }


  }

}