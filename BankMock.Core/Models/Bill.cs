using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.Core.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public string KID { get; set; }
        public string TargetAccountNumber { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public DateTime DueDate { get; set; }
        public string Issuer { get; set; }
    }
}
