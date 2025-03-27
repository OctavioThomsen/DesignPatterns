namespace DesignPatterns.Factory.Interfaces
{
    internal interface ILogisticsFactory
    {
        ITransport CreateTransport();
    }
}