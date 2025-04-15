using DesignPatterns.PatternExecutor.Enums;
using DesignPatterns.PatternExecutor.Interfaces;
using DesignPatterns.Patterns.Factory.Helpers;
using DesignPatterns.Patterns.Factory.Services;
using DesignPatterns.Shared.Helpers;

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