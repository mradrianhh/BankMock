using BankMock.Identity.Core.Models;

namespace BankMock.Identity.Core.Services
{
    public interface IIdentityService
    {
        public AuthenticationResult Login(string socialSecurityNumber, string password);
    }
}