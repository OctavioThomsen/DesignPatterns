using DesignPatterns.AbstractFactory.Helpers;
using DesignPatterns.AbstractFactory.Services;

namespace DesignPatterns.AbstractFactory
{
    internal static class AbstractFactoryMethodExecutor
    {
        internal static void Run()
        {
            int modelChoice = -1;

            while (modelChoice != 9)
            {
                PrintsHelper.ModelSelector();

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
                    PrintsHelper.InvalidOption();
                }
            }
        }
    }
}