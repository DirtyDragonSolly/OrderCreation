using OrderCreation.Models;

namespace OrderCreation.Services.Interfaces
{
    public interface IOrderService
    {
        public Guid CreateOrderByMetReq(MeterRequest meterRequest);
    }
}
