using DesignPatterns.PatternExecutor.Enums;
using DesignPatterns.PatternExecutor.Interfaces;
using DesignPatterns.Patterns.Singleton.Helpers;
using DesignPatterns.Patterns.Singleton.Interfaces;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.PatternExecutor.Patterns
{
    internal class SingletonExecutor : IPatternExecutor
    {
        public PatternType PatternType => PatternType.Singleton;
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