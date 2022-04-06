using BankMock.Core.Models;
using System;
using System.Collections.Generic;

namespace BankMock.Transactions.Core.Data
{
    public class MockDbConnection : IDbConnection
    {
        public List<Transaction> Transactions { get; set; }

        public MockDbConnection()
        {
            Transactions = new List<Transaction>();
        }
    }
}
