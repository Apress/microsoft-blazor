using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
  public interface IMenuService
  {
    Task<Menu> GetMenu();
  }
}
