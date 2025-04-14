using DesignPatterns.Extensions;
using DesignPatterns.Services;
using DesignPatterns.Shared.Helpers;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddProjectDependencies();

var serviceProvider = services.BuildServiceProvider();
var patternExecutorService = serviceProvider.GetRequiredService<PatternExecutorService>();

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

        patternExecutorService.ExecutePattern(patternChoice);
    }
    else
    {
        Console.Clear();
        SharedPrintHelpers.InvalidOption();
    }
}