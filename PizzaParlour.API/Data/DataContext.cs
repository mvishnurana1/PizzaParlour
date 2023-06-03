using Microsoft.EntityFrameworkCore;
using PizzaParlour.API.models;

namespace PizzaParlour.API.Data
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("PizzaParlourApiDb"));
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
    }
}
