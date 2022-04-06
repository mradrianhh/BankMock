namespace BankMock.Core.Models
{
    public class BankAccountBase
    {
        public BankAccountType Type { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }

        public BankAccountBase(BankAccountType type = BankAccountType.SPENDING, Currency currency = Currency.USD)
        {
            Type = type;
            Amount = 0;
            Currency = currency; 
        }
    }
}
