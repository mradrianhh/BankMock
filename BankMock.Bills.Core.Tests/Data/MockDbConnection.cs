using BankMock.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.Bills.Core.Data
{
    public class MockDbConnection : IDbConnection
    {
        public List<Bill> Bills { get; set; }

        public MockDbConnection()
        {
            Bills = new List<Bill>();
        }
    }
}
