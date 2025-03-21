using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Services
{
    public class PackageService
    {
        private ILogisticsFactory packageFactory;

        public PackageService(ILogisticsFactory factory)
        {
            packageFactory = factory;
        }

        public void RunFactoryMethod()
        {
            ITransport package = GetPackage();
            package.Deliver();
        }

        public ITransport GetPackage()
        {
            return packageFactory.CreateTransport();
        }
    }
}
