using BankMock.Core.Models;
using BankMock.Transactions.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankMock.Transactions.Core.Services
{
    public class TransactionServiceTests
    {
        private readonly ITransactionService _transactionService;

        public TransactionServiceTests()
        {
            _transactionService = new TransactionService(new MockDbConnection());
        }

        [Fact]
        public void ShouldReturnNullIfNotFound()
        {
            _transactionService.Transactions.Clear();

            Transaction account = _transactionService.GetTransaction(0);

            Assert.Null(account);
        }

    }
}
