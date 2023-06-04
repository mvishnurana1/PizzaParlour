namespace PizzaParlour.API.models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDateTime { get; set; }
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public string? Instructions { get; set; }
        public double Price { get; set; }
        public OrderType OrderType { get; set; }
    }

    public enum OrderType
    {
        PickUp,
        Delivery
    }
}
