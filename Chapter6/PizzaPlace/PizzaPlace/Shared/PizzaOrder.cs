namespace PizzaPlace.Shared
{
  public class PizzaOrder
  {
    public int Id { get; set; }
    public Order Order { get; set; }
    public Pizza Pizza { get; set; }
  }
}
