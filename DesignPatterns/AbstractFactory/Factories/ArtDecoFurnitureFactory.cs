using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public ICouch CreateCouch()
        {
            return new ArtDecoCouch();
        }

        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ITable CreateTable()
        {
            return new ArtDecoTable();
        }
    }
}
