namespace OrderCreation.Services.Interfaces
{
    public interface IPaymentService
    {
        public double GetExchangeRate();
        public long GetPaymentConditionID();
        public long GetCurrencyID();
    }
}
