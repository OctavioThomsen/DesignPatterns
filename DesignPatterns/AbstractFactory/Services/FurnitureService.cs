using DesignPatterns.AbstractFactory.Helpers;
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

        public IFurniture? Execute(int option)
        {
            return option switch
            {
                1 => GetCouch(),
                2 => GetChair(),
                3 => GetTable(),
                9 => null,
                _ => ReturnNullWithMessage()
            };
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

        private static IFurniture? ReturnNullWithMessage()
        {
            PrintsHelper.InvalidOption();
            return null;
        }
    }
}