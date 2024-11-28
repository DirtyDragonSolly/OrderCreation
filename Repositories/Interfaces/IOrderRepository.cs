using OrderCreation.Models.Requests;

namespace OrderCreation.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public void SaveOrder(long orderID, MeterRequest meterRequest);
    }
}
