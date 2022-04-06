namespace BankMock.Core.Models
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountOwnerSocialSecurityNumber { get; set; }
        public BankAccountType Type { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }

        public BankAccount(BankAccountType type, Currency currency)
        {
            Type = type;
            Currency = currency;
            Amount = 0;
        }
    }
}