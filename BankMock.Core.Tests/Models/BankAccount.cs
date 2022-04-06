namespace BankMock.Core.Models
{
    public class BankAccount : BankAccountBase
    {
        public int AccountNumber { get; set; }
        public int AccountOwnerSocialSecurityNumber { get; set; }

        public BankAccount(User user, BankAccountType type, Currency currency) : base(type, currency)
        {
            AccountOwnerSocialSecurityNumber = user.SocialSecurityNumber;
        }
    }
}