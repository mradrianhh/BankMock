using BankMock.Bills.Core.Data;
using BankMock.Core.Models;
using Xunit;

namespace BankMock.Bills.Core.Services
{
    public class BillServiceTests
    {
        private readonly IBillService _billService;

        public BillServiceTests()
        {
            _billService = new BillService(new MockDbConnection());
        }

        [Fact]
        public void ShouldReturnNullIfNotFound()
        {
            Bill bill = _billService.GetBill(0);
        
            Assert.Null(bill);
        }

    }
}
