using BankMock.Core.Models;

namespace BankMock.BankAccounts.Core.Data
{
    public class InMemoryDbConnection : IDbConnection
    {
        public List<BankAccount> BankAccounts { get; set; }

        public InMemoryDbConnection()
        {
            BankAccounts = new List<BankAccount>();
        }
    }
}
