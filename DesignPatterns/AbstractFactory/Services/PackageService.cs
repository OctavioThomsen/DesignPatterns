using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Services
{
    public class PackageService
    {
        private IPackageFactory packageFactory;

        public PackageService(IPackageFactory factory)
        {
            packageFactory = factory;
        }

        public void RunFactoryMethod()
        {
            IPackage package = GetPackage();
            package.Deliver();
        }

        public APackage GetPackage()
        {
            return packageFactory.CreatePackage();
        }
    }
}
