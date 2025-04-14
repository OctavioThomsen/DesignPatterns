using DesignPatterns.Patterns.AbstractFactory.Entities;
using DesignPatterns.Patterns.AbstractFactory.Interfaces;

namespace DesignPatterns.Patterns.AbstractFactory.Factories
{
    internal class VictorianFurnitureFactory : IFurnitureFactory
    {
        public readonly string Name = "VictorianFurnitureFactory";

        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICouch CreateCouch()
        {
            return new VictorianCouch();
        }

        public ITable CreateTable()
        {
            return new VictorianTable();
        }
    }
}