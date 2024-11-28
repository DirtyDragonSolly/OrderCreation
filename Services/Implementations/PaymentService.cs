using OrderCreation.Services.Interfaces;

namespace OrderCreation.Services.Implementations
{
    public class PaymentService : IPaymentService
    {
        private double GetExchangeRate()
        {
            // Заглушка для получения курса обмена
            return 1.1;
        }

        private long GetPaymentConditionID()
        {
            // Заглушка для получения ID условий оплаты
            return 1;
        }

        private long GetCurrencyID()
        {
            // Заглушка для получения ID валюты
            return 1;
        }
    }
}
