using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory.Factories
{
    public class StandardPackageFactory : PackageFactory
    {
        public override IPackage CreatePackage()
        {
            return new StandardPackage();
        }
    }
}
