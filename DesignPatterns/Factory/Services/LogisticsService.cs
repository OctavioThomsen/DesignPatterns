using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Services
{
    public class LogisticsService
    {
        private ILogisticsFactory logisticsFactory;

        public LogisticsService(ILogisticsFactory factory)
        {
            logisticsFactory = factory;
        }

        public void RunFactoryMethod()
        {
            ITransport package = GetPackage();
            package.Deliver();
        }

        public ITransport GetPackage()
        {
            return logisticsFactory.CreateTransport();
        }
    }
}
