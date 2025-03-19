using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Factories
{
    public abstract class PackageFactory
    {
        public abstract IPackage CreatePackage();
    }
}
