namespace PizzaParlour.API.models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDateTime { get; set; }
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public string? Instructions { get; set; }
        public double Price { get; set; }
    }
}
