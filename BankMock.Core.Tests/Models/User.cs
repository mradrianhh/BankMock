using System;
using System.Collections.Generic;
using System.Linq;

namespace BankMock.Core.Models
{
    public class User
    {
        public List<BankAccount> BankAccounts { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            BankAccounts = new List<BankAccount>();
        }
    }
}