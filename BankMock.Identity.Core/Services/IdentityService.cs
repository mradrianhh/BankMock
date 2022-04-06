using BankMock.Identity.Core.Data;
using BankMock.Identity.Core.Models;

namespace BankMock.Identity.Core.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly List<Models.Identity> _identities;

        public IdentityService(IDbConnection db)
        {
            _identities = db.Identities;
        }

        public AuthenticationResult Login(string socialSecurityNumber, string password)
        {
            var identity = _identities.FirstOrDefault(x => x.SocialSecurityNumber == socialSecurityNumber);

            if (identity?.Password == password)
                return AuthenticationResult.SUCCESS;
            else
                return AuthenticationResult.FAILURE; 
        }
    }
}
