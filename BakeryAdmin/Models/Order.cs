using System.Collections.Generic;
using System;

namespace BakeryAdmin.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get;set; }

    public int Id {get;}

    private static List<Order> _instances = new List<Order> { };

    public Order(string name,string description,string price,string date)
    {
      Name = name;
      Description = description;
      Price = price;
      Date = date;
    
      _instances.Add(this);
      Id = _instances.Count;
    }



  }

}