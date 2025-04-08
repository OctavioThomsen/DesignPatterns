using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Helpers;
using DesignPatterns.AbstractFactory.Interfaces;
using DesignPatterns.Builder.Services;

namespace DesignPatterns.AbstractFactory.Services
{
    internal class AbstractFactoryExecutorService
    {
        public static FurnitureService? Execute(int option)
        {
            return option switch
            {
                1 => new FurnitureService(new ArtDecoFurnitureFactory()),
                2 => new FurnitureService(new ModernFurnitureFactory()),
                3 => new FurnitureService(new VictorianFurnitureFactory()),
                9 => null,
                _ => ReturnNullWithMessage()
            };
        }

        private static FurnitureService? ReturnNullWithMessage()
        {
            PrintsHelper.InvalidOption();
            return null;
        }
    }
}