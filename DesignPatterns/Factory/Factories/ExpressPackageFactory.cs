using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory.Factories
{
    public class ExpressPackageFactory : PackageFactory
    {
        public override IPackage CreatePackage()
        {
            return new ExpressPackage();
        }
    }
}
