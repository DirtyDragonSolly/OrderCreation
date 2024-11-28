namespace OrderCreation.Services.Interfaces
{
    public interface IPaymentService
    {
        private double GetExchangeRate();
        private long GetPaymentConditionID();
        private long GetCurrencyID();
    }
}
