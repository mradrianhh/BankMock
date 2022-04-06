using BankMock.Core.Models;

namespace BankMock.Bills.Core.Services
{
    public interface IBillService
    {
        List<Bill> Bills { get; }

        Bill GetBill(int id);
        IEnumerable<Bill> GetBills();
        IEnumerable<Bill> GetBillsByFilter(Func<Bill, bool> filter);
    }
}