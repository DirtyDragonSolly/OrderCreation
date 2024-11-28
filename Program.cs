using Microsoft.Extensions.DependencyInjection;
using OrderCreation.Models;
using OrderCreation.Services.Interfaces;
using OrderCreation.Services.Implementations;
using OrderCreation.Repositories.Interfaces;
using OrderCreation.Repositories.Implementations;

namespace OrderCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IOrderService, OrderService>()
                .AddTransient<IOrderRepository, OrderRepository>()
                .AddTransient<IManagerService, ManagerService>()
                .AddTransient<IPaymentService, PaymentService>()
                .BuildServiceProvider();
            
            // Инициализация тестовых данных для заявки
            var meterRequest = new MeterRequest
            {
                Contact = "John Doe",
                PostAddr = "1234 Main St.",
                Email = "johndoe@example.com",
                Phone = "+1234567890",
                Phone1 = "+0987654321",
                Phone2 = "+1122334455",
                MetReqNum = "MR12345",
                ContactKindKey = "RP"
            };

            // Создание заказа
            var orderService = serviceProvider.GetService<IOrderService>();
            var orderID = orderService.CreateOrderByMetReq(meterRequest);

            // Вывод номера созданного заказа
            Console.WriteLine($"Order ID: {orderID}");
        }
    }
}
