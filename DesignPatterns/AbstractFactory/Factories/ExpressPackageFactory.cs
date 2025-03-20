using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class ExpressPackageFactory : IPackageFactory
    {
        public APackage CreatePackage()
        {
            return new ExpressPackage();
        }
    }
}
