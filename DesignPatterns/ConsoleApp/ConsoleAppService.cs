using DesignPatterns.ConsoleApp.Interfaces;
using DesignPatterns.PatternExecutor.Interfaces;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.ConsoleApp
{
    internal class ConsoleAppService : IConsoleAppService
    {
        private readonly IPatternExecutorService _patternExecutorService;

        public ConsoleAppService(IPatternExecutorService patternExecutorService)
        {
            _patternExecutorService = patternExecutorService;
        }

        public void Run()
        {
            int patternChoice = -1;

            while (patternChoice != 9)
            {
                Console.WriteLine("Select a design pattern:");
                Console.WriteLine("1 - Abstract Factory Method");
                Console.WriteLine("2 - Builder Method");
                Console.WriteLine("3 - Factory Method");
                Console.WriteLine("4 - Singleton Method");
                Console.WriteLine("9 - Exit");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out patternChoice))
                {
                    if (patternChoice == 9)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Quitting...");
                        Console.WriteLine();
                        return;
                    }

                    Console.Clear();

                    _patternExecutorService.ExecutePattern(patternChoice);
                }
                else
                {
                    Console.Clear();
                    SharedPrintHelpers.InvalidOption();
                }

                Console.Clear();
            }
        }
    }
}