using System.Collections.Generic;
using System;

namespace BakeryAdmin.Models
{
  public class Order
  {
    public DateTime Date { get; set; }
    public int InvoiceTotal { get; set; }
    public int QuantityBread { get; set; }
    public int QuantityPastry { get; set; }
    public string Description { get; set; }
    public string OrderTitle { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(DateTime orderDate,int invoiceTotal,string orderTitle, string description, int quantityBread, int quantityPastry)
    {
      Date = orderDate;
      InvoiceTotal = invoiceTotal;
      OrderTitle = orderTitle;
      Description = description;
      QuantityBread = quantityBread;
      QuantityPastry = quantityPastry;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }


  }

}