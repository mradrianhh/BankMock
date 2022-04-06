using BankMock.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.BankAccounts.Core.Data
{
    public class MockDbConnection : IDbConnection
    {
        public List<BankAccount> BankAccounts { get; set; }

        public MockDbConnection()
        {
            BankAccounts = new List<BankAccount>();
        }
    }
}
