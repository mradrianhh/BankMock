using BankMock.Console.Core;

namespace BankMock.Console.Views
{
    public class LoginView : View
    {
        public LoginView(string identifier) : base(identifier)
        {

        }

        public override void Display()
        {
            System.Console.WriteLine("Hello World from Login!");
        }
    }
}
