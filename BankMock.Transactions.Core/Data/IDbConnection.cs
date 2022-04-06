using BankMock.Core.Models;

namespace BankMock.Transactions.Core.Data
{
    public interface IDbConnection
    {
        List<Transaction> Transactions { get; set; }
    }
}
