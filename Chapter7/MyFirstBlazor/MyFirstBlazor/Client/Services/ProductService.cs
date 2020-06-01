using MyFirstBlazor.Shared;
using System.Collections.Generic;

namespace MyFirstBlazor.Client.Services
{
  public class HardCodedProductService : IProductsService
  {
    public static List<Product> products = new List<Product>
    {
      new Product {
        Name = "Isabelle's Homemade Marmelade",
        Description = "...",
        UnitPrice = 1.99M
      }, new Product
      {
        Name = "Liesbeth's Applecake",
        Description = "...",
        UnitPrice = 3.99M
      }
    };

    public IEnumerable<Product> GetAllProducts()
    => products;
  }
}
