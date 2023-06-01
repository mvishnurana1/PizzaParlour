namespace PizzaParlour.API.models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Ingredients> Ingredients { get; set; } = new List<Ingredients>();
    }
}
