using OrderCreation.Models.Requests;

namespace OrderCreation.Services.Interfaces
{
    public interface IOrderService
    {
        public long CreateOrderByMetReq(MeterRequest meterRequest);
    }
}
