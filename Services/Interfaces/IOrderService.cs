using OrderCreation.Models;

namespace OrderCreation.Services.Interfaces
{
    public interface IOrderService
    {
        public long CreateOrderByMetReq(MeterRequest meterRequest);
    }
}
