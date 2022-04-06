using BankMock.Identity.Core.Models;

namespace BankMock.Identity.Core.Data
{
    public interface IDbConnection
    {
        List<Models.Identity> Identities { get; set; }
    }
}
