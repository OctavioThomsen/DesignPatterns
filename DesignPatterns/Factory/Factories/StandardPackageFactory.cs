using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Factories
{
    public class StandardPackageFactory : IPackageFactory
    {
        public IPackage CreatePackage()
        {
            return new StandardPackage();
        }
    }
}
