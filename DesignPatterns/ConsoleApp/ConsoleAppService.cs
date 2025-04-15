using DesignPatterns.ConsoleApp.Helpers;
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
                ConsoleAppPrintHelper.DesignPatternSelector();

                if (int.TryParse(Console.ReadLine(), out patternChoice))
                {
                    if (patternChoice == 9)
                    {
                        ConsoleAppPrintHelper.Quitting();
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