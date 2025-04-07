using DesignPatterns.Singleton.Helpers;
using DesignPatterns.Singleton.Services;

namespace DesignPatterns.Singleton
{
    internal static class SingletonMethodExecutor
    {
        internal static void Run(DatabaseExecutorService databaseExecutorService)
        {
            int choice = -1;

            while (choice != 9)
            {
                PrintsHelper.WhatToDoSelector();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    databaseExecutorService.Execute(choice);
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