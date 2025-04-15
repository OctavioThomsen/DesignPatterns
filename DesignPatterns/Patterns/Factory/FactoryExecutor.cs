using DesignPatterns.Patterns.Factory.Helpers;
using DesignPatterns.Patterns.Factory.Services;
using DesignPatterns.Shared.Enums;
using DesignPatterns.Shared.Helpers;
using DesignPatterns.Shared.Interfaces;

namespace DesignPatterns.Patterns.Factory
{
    internal class FactoryExecutor : IPatternExecutor
    {
        public PatternType PatternType => PatternType.Factory;

        public void Execute()
        {
            int choice = -1;

            FactoryPrintsHelper.PatternDesignTittle();

            while (choice != 9)
            {
                FactoryPrintsHelper.LogisticTypeSelector();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    LogisticsExecutorService.Execute(choice);
                }
                else
                {
                    SharedPrintHelpers.InvalidOption();
                }
            }
        }
    }
}