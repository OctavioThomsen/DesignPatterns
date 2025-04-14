using DesignPatterns.Patterns.Factory.Interfaces;

namespace DesignPatterns.Patterns.Factory.Services
{
    internal class LogisticsService : ILogisticsService
    {
        private readonly ILogisticsFactory logisticsFactory;

        internal LogisticsService(ILogisticsFactory factory)
        {
            logisticsFactory = factory;
        }

        public ITransport GetPackage()
        {
            return logisticsFactory.CreateTransport();
        }

        public void GetAndDeliverPackage()
        {
            ITransport package = GetPackage();
            package.Deliver();
        }
    }
}