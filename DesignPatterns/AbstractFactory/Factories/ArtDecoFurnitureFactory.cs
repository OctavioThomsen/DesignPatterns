using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Factories
{
    internal class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public string Name { get; set; } = "ArtDecoFurnitureFactory";

        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ICouch CreateCouch()
        {
            return new ArtDecoCouch();
        }

        public ITable CreateTable()
        {
            return new ArtDecoTable();
        }
    }
}