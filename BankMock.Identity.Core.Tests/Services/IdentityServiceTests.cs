using BankMock.Identity.Core.Data;
using BankMock.Identity.Core.Models;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace BankMock.Identity.Core.Services
{
    public class IdentityServiceTests
    {
        private readonly IIdentityService _identityService;
        private readonly IDbConnection _db;

        public IdentityServiceTests()
        {
            _db = new MockDbConnection();

            _identityService = new IdentityService(_db);
        }

        [Fact]
        public void ShouldReturnFailureOnWrongCredentials()
        {
            AuthenticationResult result = _identityService.Login("number", "password");

            Assert.Equal(AuthenticationResult.FAILURE, result);
        }

        [Fact]
        public void ShouldReturnSuccessOnValidCredentials()
        {
            AuthenticationResult result = _identityService.Login("123456789", "securepassword");

            Assert.Equal(AuthenticationResult.SUCCESS, result);
        }
    }
}
