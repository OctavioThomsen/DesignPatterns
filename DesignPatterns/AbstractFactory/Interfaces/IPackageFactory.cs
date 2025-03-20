using DesignPatterns.AbstractFactory.Entities;

namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface IPackageFactory
    {
        public APackage CreatePackage();
    }
}
