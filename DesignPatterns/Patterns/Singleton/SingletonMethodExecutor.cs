using DesignPatterns.Patterns.Singleton.Helpers;
using DesignPatterns.Patterns.Singleton.Interfaces;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.Patterns.Singleton
{
    internal static class SingletonMethodExecutor
    {
        internal static void Run(IDatabaseExecutorService databaseExecutorService)
        {
            int choice = -1;

            while (choice != 9)
            {
                SingletonPrintsHelper.WhatToDoSelector();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    databaseExecutorService.Execute(choice);
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