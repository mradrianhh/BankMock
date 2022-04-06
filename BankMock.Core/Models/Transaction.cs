using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.Core.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string TargetAccountNumber { get; set; }
        public string SourceAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public DateTime Date { get; set; }
    }
}
