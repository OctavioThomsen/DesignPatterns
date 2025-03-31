namespace DesignPatterns.Factory.Interfaces
{
    internal interface ILogisticsService
    {
        ITransport GetPackage();

        void RunFactoryMethod();
    }
}