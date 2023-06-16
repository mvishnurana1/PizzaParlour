using PizzaParlour.API.models;

namespace PizzaParlour.API.Dtos
{
    public class PizzaOrderDto
    {
        public DateTime OrderDateTime { get; set; }
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public string? Instructions { get; set; }
        public double Price { get; set; }
    }

    public class PizzaOrderResponseDto
    {
        public int OrderId { get; set; }
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
    }

    public class PizzaUpdateDto
    {
    }

    public class PizzaUpdateResponseDto { }
}
