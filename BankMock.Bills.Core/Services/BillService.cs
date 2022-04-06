using BankMock.Bills.Core.Data;
using BankMock.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.Bills.Core.Services
{
    public class BillService : IBillService
    {
        public List<Bill> Bills { get; private set; }

        public BillService(IDbConnection db)
        {
            Bills = db.Bills;
        }

        public IEnumerable<Bill> GetBillsByFilter(Func<Bill, bool> filter)
        {
            return Bills.Where(filter);
        }

        public IEnumerable<Bill> GetBills()
        {
            return Bills;
        }

        public Bill GetBill(int id)
        {
            return Bills.FirstOrDefault(bill => bill.Id == id);
        }
    }
}
