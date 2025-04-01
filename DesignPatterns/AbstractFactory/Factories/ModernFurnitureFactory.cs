using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Factories
{
    internal class ModernFurnitureFactory : IFurnitureFactory
    {
        public readonly string Name = "ModernFurnitureFactory";
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICouch CreateCouch()
        {
            return new ModernCouch();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}