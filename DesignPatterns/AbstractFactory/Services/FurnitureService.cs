using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Services
{
    public class FurnitureService
    {
        private IFurnitureFactory furnitureFactory;

        public FurnitureService(IFurnitureFactory factory)
        {
            furnitureFactory = factory;
        }

        public ICouch GetCouch()
        {
            return furnitureFactory.CreateCouch();
        }

        public IChair GetChair()
        {
            return furnitureFactory.CreateChair();
        }

        public ITable GetTable()
        {
            return furnitureFactory.CreateTable();
        }
    }
}
