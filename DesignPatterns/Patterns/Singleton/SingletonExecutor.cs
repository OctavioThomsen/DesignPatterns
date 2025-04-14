using DesignPatterns.Patterns.Singleton.Helpers;
using DesignPatterns.Patterns.Singleton.Interfaces;
using DesignPatterns.Shared.Helpers;
using DesignPatterns.Shared.Interfaces;

namespace DesignPatterns.Patterns.Singleton
{
    internal class SingletonExecutor : IPatternExecutor
    {
        private readonly IDatabaseExecutorService databaseExecutorService;

        public SingletonExecutor(IDatabaseExecutorService databaseExecutorService)
        {
            this.databaseExecutorService = databaseExecutorService;
        }

        public void Execute()
        {
            int choice = -1;

            SingletonPrintsHelper.PatternDesignTittle();

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
        }
    }
}