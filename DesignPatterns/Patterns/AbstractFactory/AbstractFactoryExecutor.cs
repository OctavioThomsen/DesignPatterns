using DesignPatterns.Patterns.AbstractFactory.Helpers;
using DesignPatterns.Patterns.AbstractFactory.Services;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.AbstractFactory
{
    internal static class AbstractFactoryExecutor
    {
        internal static void Run()
        {
            int modelChoice = -1;

            while (modelChoice != 9)
            {
                AbstractFactoryPrintsHelper.ModelSelector();

                if (int.TryParse(Console.ReadLine(), out modelChoice))
                {
                    FurnitureService? furnitureService = AbstractFactoryExecutorService.Execute(modelChoice);

                    if (furnitureService != null)
                    {
                        Console.WriteLine();
                        FurnitureMenuService.Start(furnitureService);
                    }
                }
                else
                {
                    SharedPrintHelpers.InvalidOption();
                }
            }
        }
    }
}