using Microsoft.AspNetCore.Components;
using PizzaPlace.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaPlace.Client.Services
{
  public class OrderService : IOrderService
  {
    private readonly HttpClient httpClient;

    public OrderService(HttpClient httpClient)
      => this.httpClient = httpClient;

    public async Task PlaceOrder(Basket basket)
      => await this.httpClient.PostAsJsonAsync("/orders", basket);
  }
}
