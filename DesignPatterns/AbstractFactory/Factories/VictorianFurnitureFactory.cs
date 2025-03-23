using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public ICouch CreateCouch()
        {
            return new VictorianCouch();
        }

        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ITable CreateTable()
        {
            return new VictorianTable();
        }
    }
}
