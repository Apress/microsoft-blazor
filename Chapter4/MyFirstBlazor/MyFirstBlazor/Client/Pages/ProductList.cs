using Microsoft.AspNetCore.Components;
using MyFirstBlazor.Shared;

namespace MyFirstBlazor.Client.Pages
{
  public partial class ProductList
  {
    [Inject]
    public IProductsService productService { get; set; }
  }
}
