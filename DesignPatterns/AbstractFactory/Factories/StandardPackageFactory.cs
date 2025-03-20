using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class StandardPackageFactory : IPackageFactory
    {
        public APackage CreatePackage()
        {
            return new StandardPackage();
        }
    }
}
