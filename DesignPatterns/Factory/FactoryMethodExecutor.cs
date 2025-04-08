using DesignPatterns.Factory.Helpers;
using DesignPatterns.Factory.Services;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.Factory
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