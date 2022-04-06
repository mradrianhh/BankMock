using BankMock.BankAccounts.Core.Data;
using BankMock.Core.Models;

namespace BankMock.BankAccounts.Core.Services
{
    public class BankAccountService : IBankAccountService
    {
        public List<BankAccount> BankAccounts { get; private set; }

        public BankAccountService(IDbConnection db)
        {
            BankAccounts = db.BankAccounts;
        }

        public IEnumerable<BankAccount> GetAccountsByFilter(Func<BankAccount, bool> filter)
        {
            return BankAccounts.Where(filter);
        }

        public IEnumerable<BankAccount> GetAccounts()
        {
            return BankAccounts;
        }

        public BankAccount GetAccount(string accountNumber)
        {
            return BankAccounts.FirstOrDefault(account => account.AccountNumber == accountNumber);
        }
    }
}
