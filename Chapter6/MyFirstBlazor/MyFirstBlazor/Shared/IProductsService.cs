using System.Collections.Generic;

namespace MyFirstBlazor.Shared
{
  public interface IProductsService
  {
    IEnumerable<Product> GetAllProducts();
  }
}
