using BankMock.Core.Models;
using BankMock.Transactions.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.Transactions.Core.Services
{
    public class TransactionService : ITransactionService
    {
        public List<Transaction> Transactions { get; private set; }

        public TransactionService(IDbConnection db)
        {
            Transactions = db.Transactions;
        }

        public IEnumerable<Transaction> GetTransactionsByFilter(Func<Transaction, bool> filter)
        {
            return Transactions.Where(filter);
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return Transactions;
        }

        public Transaction GetTransaction(int id)
        {
            return Transactions.FirstOrDefault(transaction => transaction.Id == id);
        }
    }
}
