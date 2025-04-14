namespace DesignPatterns.Patterns.Factory.Interfaces
{
    internal interface ILogisticsService
    {
        ITransport GetPackage();

        void GetAndDeliverPackage();
    }
}