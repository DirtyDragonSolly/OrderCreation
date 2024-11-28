using OrderCreation.Models.Requests;
using OrderCreation.Repositories.Interfaces;
using OrderCreation.Services.Interfaces;

namespace OrderCreation.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;        
        }

        public long CreateOrderByMetReq(MeterRequest meterRequest)
        {
            // Примерная логика для вычисления номера заказа и возвращения его
            double exchangeRate = GetExchangeRate();
            long paymentConditionID = GetPaymentConditionID();
            long currencyID = GetCurrencyID();
            long managerID = GetManagerID();

            // Пример создания заказа
            long orderID = GenerateOrderID();
            Console.WriteLine("Creating order with the following details:");
            Console.WriteLine($"Contact: {meterRequest.Contact}");
            Console.WriteLine($"Post Address: {meterRequest.PostAddr}");
            Console.WriteLine($"Email: {meterRequest.Email}");
            Console.WriteLine($"Phone: {meterRequest.Phone}");
            Console.WriteLine($"ManagerID: {managerID}");
            Console.WriteLine($"ExchangeRate: {exchangeRate}");

            // Имитация процесса сохранения заказа
            _orderRepository.SaveOrder(orderID, meterRequest);

            return orderID;
        }
    }

}
