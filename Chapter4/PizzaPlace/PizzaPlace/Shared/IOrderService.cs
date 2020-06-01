using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
  public interface IOrderService
  {
    Task PlaceOrder(Basket basket);
  }
}
