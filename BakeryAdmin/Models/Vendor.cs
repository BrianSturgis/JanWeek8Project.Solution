using System.Collections.Generic;

namespace BakeryAdmin.Models
{
  public class Category
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
  }
}