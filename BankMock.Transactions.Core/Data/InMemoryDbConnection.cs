using BankMock.Core.Models;

namespace BankMock.Transactions.Core.Data
{
    public class InMemoryDbConnection : IDbConnection
    {
        public List<Transaction> Transactions { get; set; }

        public InMemoryDbConnection()
        {
            Transactions = new List<Transaction>();
        }
    }
}
