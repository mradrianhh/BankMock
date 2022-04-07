using BankMock.Console.Core;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace BankMock.Console.Core
{
    public class Application
    {
        public IServiceCollection Services { get; set; }
        public IServiceProvider ServiceProvider { get; set; }
        public ViewCollection Views { get; set; }

        public Application()
        {
            Services = new ServiceCollection();
            Views = new ViewCollection();
        }

        public void Configure()
        {
            Services.AddHttpClient();

            // After adding services
            ServiceProvider = Services.BuildServiceProvider();
        }

        public void AddView(ViewModel viewModel, View view)
        {
            Views.AddView(viewModel, view);
        }

        public void Run()
        {
            foreach(var view in Views)
            {
                view.Display();
            }
        }
    }
}
