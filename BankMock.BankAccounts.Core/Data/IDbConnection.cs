using BankMock.Core.Models;

namespace BankMock.BankAccounts.Core.Data
{
    public interface IDbConnection
    {
        List<BankAccount> BankAccounts { get; set; }
    }
}
