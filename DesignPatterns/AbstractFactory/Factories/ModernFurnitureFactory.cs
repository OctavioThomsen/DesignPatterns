using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public ICouch CreateCouch()
        {
            return new ModernCouch();
        }

        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}
