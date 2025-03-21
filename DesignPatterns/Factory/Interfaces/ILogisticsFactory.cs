namespace DesignPatterns.Factory.Interfaces
{
    public interface ILogisticsFactory
    {
        public ITransport CreateTransport();
    }
}
