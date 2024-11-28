using OrderCreation.Models.Entities;
using OrderCreation.Repositories.Implementations;
using OrderCreation.Repositories.Interfaces;
using OrderCreation.Services.Implementations;

namespace OrderCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация тестовых данных для заявки
            var meterRequest = new MeterRequest
            {
                Contact = Console.ReadLine(),
                PostAddr = Console.ReadLine(),
                Email = Console.ReadLine(),
                Phone = Console.ReadLine(),
                Phone1 = Console.ReadLine(),
                Phone2 = Console.ReadLine(),
                MetReqNum = Console.ReadLine(),
                ContactKindKey = Console.ReadLine()
            };

            // Создание заказа
            OrderService orderService = new OrderService(new OrderRepository());
            long orderID = orderService.CreateOrderByMetReq(meterRequest);

            // Вывод номера созданного заказа
            Console.WriteLine($"Order ID: {orderID}");
        }
    }

    private long GetManagerID()
    {
        // Заглушка для получения ID менеджера
        return 123;
    }

    private long GenerateOrderID()
    {
        // Логика генерации уникального ID заказа
        return new Random().Next(100000, 999999);
    }
}
