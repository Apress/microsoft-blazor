using System.Collections.Generic;

namespace PizzaPlace.Shared
{
  public class Order
  {
    public int Id { get; set; }

    public Customer Customer { get; set; }

    public int CustomerId { get; set; }

    public List<PizzaOrder> PizzaOrders { get; set; }

    public decimal TotalPrice { get; set; }

  }
}
