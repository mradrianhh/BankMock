using BankMock.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.Bills.Core.Data
{
    public class InMemoryDbConnection : IDbConnection
    {
        public List<Bill> Bills { get; set; }

        public InMemoryDbConnection()
        {
            Bills = new List<Bill>();
        }
    }
}
