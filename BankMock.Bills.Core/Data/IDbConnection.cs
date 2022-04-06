using BankMock.Core.Models;

namespace BankMock.Bills.Core.Data
{
    public interface IDbConnection
    {
        List<Bill> Bills { get; set; }
    }
}