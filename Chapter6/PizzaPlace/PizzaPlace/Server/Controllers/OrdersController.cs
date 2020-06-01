using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Shared;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class OrdersController : ControllerBase
  {
    private readonly PizzaPlaceDbContext db;

    public OrdersController(PizzaPlaceDbContext db)
      => this.db = db;

    [HttpPost("/orders")]
    public IActionResult CreateOrder([FromBody] Basket basket)
    {
      Customer customer = basket.Customer;
      var order = new Order()
      {
        PizzaOrders = new List<PizzaOrder>()
      };
      customer.Order = order;

      foreach (int pizzaId in basket.Orders)
      {
        Pizza pizza = this.db.Pizzas.Single(p => p.Id == pizzaId);
        order.PizzaOrders.Add(new PizzaOrder { Pizza = pizza, Order = order });
      }

      order.TotalPrice = order.PizzaOrders.Sum(po => po.Pizza.Price);

      this.db.Customers.Add(customer);
      this.db.SaveChanges();

      return Ok();
    }
  }
}