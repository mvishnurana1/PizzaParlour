using PizzaParlour.API.Dtos;
using PizzaParlour.API.models;

namespace PizzaParlour.API.services
{
    public interface IPizzaService
    {
        public Task<Order> CreatePizzaOrder(PizzaOrderDto order);
        public Task<Pizza> ReadPizzaOrder(int orderId);
        public Task<Pizza> ReadPizzaOrdersForDate(DateTime date);
        public Task<Pizza> UpdatePizzaOrder(PizzaUpdateDto update);
        public Task<Pizza> DeletePizzaOrder(int orderId);
    }

    public class PizzaService : IPizzaService
    {
        public Task<Order> CreatePizzaOrder(PizzaOrderDto order)
        {
            throw new NotImplementedException();
        }

        public Task<Pizza> DeletePizzaOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<Pizza> ReadPizzaOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<Pizza> ReadPizzaOrdersForDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<Pizza> UpdatePizzaOrder(PizzaUpdateDto update)
        {
            throw new NotImplementedException();
        }
    }
}
