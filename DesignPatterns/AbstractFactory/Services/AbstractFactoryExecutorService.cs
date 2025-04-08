using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.AbstractFactory.Services
{
    internal static class AbstractFactoryExecutorService
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
            SharedPrintHelpers.InvalidOption();
            return null;
        }
    }
}