using BankMock.BankAccounts.Core.Data;
using BankMock.Core.Models;
using Xunit;

namespace BankMock.BankAccounts.Core.Services
{
    public class BankAccountServiceTests
    {
        private readonly IBankAccountService _bankAccountService;

        public BankAccountServiceTests()
        {
            _bankAccountService = new BankAccountService(new MockDbConnection());
        }

        [Fact]
        public void ShouldReturnNullIfNotFound()
        {
            _bankAccountService.BankAccounts.Clear();

            BankAccount account = _bankAccountService.GetAccount("123");

            Assert.Null(account);
        }

    }
}
