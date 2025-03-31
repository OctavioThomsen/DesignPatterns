using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Services
{
    internal class FurnitureService : IFurnitureService
    {
        private readonly IFurnitureFactory furnitureFactory;

        internal FurnitureService(IFurnitureFactory factory)
        {
            furnitureFactory = factory;
        }

        public IChair GetChair()
        {
            return furnitureFactory.CreateChair();
        }

        public ICouch GetCouch()
        {
            return furnitureFactory.CreateCouch();
        }

        public ITable GetTable()
        {
            return furnitureFactory.CreateTable();
        }
    }
}