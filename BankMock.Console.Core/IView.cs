namespace BankMock.Console.Core
{
    public interface IView
    {
        string Identifier { get; set; }

        void Display();
    }
}