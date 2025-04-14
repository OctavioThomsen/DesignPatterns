using DesignPatterns.Patterns.AbstractFactory.Entities;
using DesignPatterns.Patterns.AbstractFactory.Interfaces;

namespace DesignPatterns.Patterns.AbstractFactory.Factories
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