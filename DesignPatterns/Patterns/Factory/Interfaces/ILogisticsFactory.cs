namespace DesignPatterns.Patterns.Factory.Interfaces
{
    internal interface ILogisticsFactory
    {
        ITransport CreateTransport();
    }
}