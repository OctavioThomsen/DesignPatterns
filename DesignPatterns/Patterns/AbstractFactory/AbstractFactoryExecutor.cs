using DesignPatterns.Patterns.AbstractFactory.Helpers;
using DesignPatterns.Patterns.AbstractFactory.Services;
using DesignPatterns.Shared.Enums;
using DesignPatterns.Shared.Helpers;
using DesignPatterns.Shared.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class AbstractFactoryExecutor : IPatternExecutor
    {
        public PatternType PatternType => PatternType.AbstractFactory;

        public void Execute()
        {
            int modelChoice = -1;

            AbstractFactoryPrintsHelper.PatternDesignTittle();

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

                Console.WriteLine();
            }
        }
    }
}