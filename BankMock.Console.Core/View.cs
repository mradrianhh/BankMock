using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.Console.Core
{
    public abstract class View : IView
    {
        public ViewModel ViewModel;

        public string Identifier { get; set; }

        public View(string identifier)
        {
            Identifier = identifier;
        }

        public abstract void Display();
    }
}
