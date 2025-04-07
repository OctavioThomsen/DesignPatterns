using DesignPatterns.Builder.Helpers;
using DesignPatterns.Builder.Services;

namespace DesignPatterns.Builder
{
    internal class BuilderMethodExecutor
    {
        internal static void Run()
        {
            int directorChoice = -1;

            while (directorChoice != 9)
            {
                PrintsHelper.BuilderTypeSelector();

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
                    PrintsHelper.InvalidOption();
                }
            }

            Console.Clear();
        }
    }
}