using OrderCreation.Models;

namespace OrderCreation.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public void SaveOrder(Guid orderID, MeterRequest meterRequest);
    }
}
