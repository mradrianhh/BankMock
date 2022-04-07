using BankMock.Console.Core;
using BankMock.Console.ViewModels;
using BankMock.Console.Views;

namespace BankMock.Console
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Application app = new Application();

            app.Configure();

            app.AddView(new LoginViewModel((IHttpClientFactory)app.ServiceProvider.GetService(typeof(IHttpClientFactory))), new LoginView("Login"));

            app.Run();
        }
    }

}