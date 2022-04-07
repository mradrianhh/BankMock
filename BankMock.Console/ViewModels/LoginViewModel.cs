using BankMock.Console.Core;

namespace BankMock.Console.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public LoginViewModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
    }
}
