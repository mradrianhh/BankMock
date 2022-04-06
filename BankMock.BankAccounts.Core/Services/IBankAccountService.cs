using BankMock.Core.Models;

namespace BankMock.BankAccounts.Core.Services
{
    public interface IBankAccountService
    {
        List<BankAccount> BankAccounts { get; }

        BankAccount GetAccount(string accountNumber);
        IEnumerable<BankAccount> GetAccounts();
        IEnumerable<BankAccount> GetAccountsByFilter(Func<BankAccount, bool> filter);
    }
}