using DesignPatterns.Shared.Helpers;
using DesignPatterns.Singleton.Helpers;
using DesignPatterns.Singleton.Interfaces;

namespace DesignPatterns.Singleton
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