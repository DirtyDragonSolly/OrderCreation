using OrderCreation.Services.Interfaces;

namespace OrderCreation.Services.Implementations
{
    public class PaymentService : IPaymentService
    {
        public double GetExchangeRate()
        {
            // Заглушка для получения курса обмена
            return 1.1;
        }

        public long GetPaymentConditionID()
        {
            // Заглушка для получения ID условий оплаты
            return 1;
        }

        public long GetCurrencyID()
        {
            // Заглушка для получения ID валюты
            return 1;
        }
    }
}
