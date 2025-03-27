using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Factories
{
    internal class VictorianFurnitureFactory : IFurnitureFactory
    {
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