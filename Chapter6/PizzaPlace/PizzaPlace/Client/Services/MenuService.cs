using Microsoft.AspNetCore.Components;
using PizzaPlace.Shared;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PizzaPlace.Client.Services
{
  public class MenuService : IMenuService
  {
    private readonly HttpClient httpClient;

    public MenuService(HttpClient httpClient)
      => this.httpClient = httpClient;


    public async Task<Menu> GetMenu()
    {
      Pizza[] pizzas = await this.httpClient.GetFromJsonAsync<Pizza[]>("/pizzas");
      return new Menu { Pizzas = pizzas.ToList() };
    }
  }
}
