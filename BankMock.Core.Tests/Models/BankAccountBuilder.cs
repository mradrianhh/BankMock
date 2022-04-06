using System;

namespace BankMock.Core.Models
{
    public static class BankAccountBuilder
    {
        public static BankAccountBase GetDefault()
        {
            return new BankAccountBase();
        }
    }
}