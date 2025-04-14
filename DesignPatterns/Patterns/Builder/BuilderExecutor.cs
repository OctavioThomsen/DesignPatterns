using DesignPatterns.Patterns.Builder.Helpers;
using DesignPatterns.Patterns.Builder.Services;
using DesignPatterns.Shared.Helpers;
using DesignPatterns.Shared.Interfaces;

namespace DesignPatterns.Patterns.Builder
{
    internal class BuilderExecutor : IPatternExecutor
    {
        public void Execute()
        {
            int directorChoice = -1;

            BuilderPrintsHelper.PatternDesignTittle();

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
        }
    }
}