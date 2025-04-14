using DesignPatterns.Patterns.Factory.Helpers;
using DesignPatterns.Patterns.Factory.Services;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.Patterns.Factory
{
    internal static class FactoryMethodExecutor
    {
        internal static void Run()
        {
            int choice = -1;

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

            Console.Clear();
        }
    }
}