using OrderCreation.Models;
using OrderCreation.Repositories.Interfaces;
using OrderCreation.Services.Interfaces;

namespace OrderCreation.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IPaymentService _paymentService;
        private readonly IManagerService _managerService;

        public OrderService(IOrderRepository orderRepository, 
                            IPaymentService paymentService, 
                            IManagerService managerService)
        {
            _orderRepository = orderRepository;
            _paymentService = paymentService;
            _managerService = managerService;
        }

        public Guid CreateOrderByMetReq(MeterRequest meterRequest)
        {
            // Примерная логика для вычисления номера заказа и возвращения его
            double exchangeRate = _paymentService.GetExchangeRate();
            long paymentConditionID = _paymentService.GetPaymentConditionID();
            long currencyID = _paymentService.GetCurrencyID();
            long managerID = _managerService.GetManagerID();

            // Пример создания заказа
            var orderID = Guid.NewGuid();
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
