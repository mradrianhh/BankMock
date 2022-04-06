using System.Collections.Generic;

namespace BankMock.Identity.Core.Data
{
    internal class MockDbConnection : IDbConnection
    {
        public List<Models.Identity> Identities { get; set; }

        public MockDbConnection()
        {
            Identities = new List<Models.Identity>();
            Identities.Add(new Models.Identity { SocialSecurityNumber = "123456789", Password = "securepassword" });
        }
    }
}
