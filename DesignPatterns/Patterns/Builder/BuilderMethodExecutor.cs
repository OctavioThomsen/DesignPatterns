using DesignPatterns.Patterns.Builder.Helpers;
using DesignPatterns.Patterns.Builder.Services;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.Patterns.Builder
{
    internal class BuilderMethodExecutor
    {
        internal static void Run()
        {
            int directorChoice = -1;

            while (directorChoice != 9)
            {
                BuilderPrintsHelper.BuilderTypeSelector();

                if (int.TryParse(Console.ReadLine(), out directorChoice))
                {
                    HouseConstructionService? houseConstructionService = BuilderExecutorService.Execute(directorChoice);

                    if (houseConstructionService != null)
                    {
                        Console.WriteLine();
                        BuildMenuService.Start(houseConstructionService);
                    }
                }
                else
                {
                    SharedPrintHelpers.InvalidOption();
                }
            }

            Console.Clear();
        }
    }
}