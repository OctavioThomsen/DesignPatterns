using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Factories
{
    public class ExpressPackageFactory : IPackageFactory
    {
        public IPackage CreatePackage()
        {
            return new ExpressPackage();
        }
    }
}
