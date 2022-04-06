using BankMock.Core.Models;

namespace BankMock.Transactions.Core.Services
{
    public interface ITransactionService
    {
        List<Transaction> Transactions { get; }

        Transaction GetTransaction(int id);
        IEnumerable<Transaction> GetTransactions();
        IEnumerable<Transaction> GetTransactionsByFilter(Func<Transaction, bool> filter);
    }
}