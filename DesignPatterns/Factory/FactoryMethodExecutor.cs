using DesignPatterns.Factory.Helpers;
using DesignPatterns.Factory.Services;

namespace DesignPatterns.Factory
{
    internal static class FactoryMethodExecutor
    {
        internal static void Run()
        {
            int choice = -1;

            while (choice != 9)
            {
                PrintsHelper.LogisticTypeSelector();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    LogisticsExecutorService.Execute(choice);
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