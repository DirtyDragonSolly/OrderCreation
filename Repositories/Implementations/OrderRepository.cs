using OrderCreation.Models.Requests;
using OrderCreation.Repositories.Interfaces;

namespace OrderCreation.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        public void SaveOrder(long orderID, MeterRequest meterRequest)
        {
            // Здесь можно реализовать сохранение в базу данных, сейчас имитация
            Console.WriteLine($"Order {orderID} saved successfully.");
        }
    }
}
