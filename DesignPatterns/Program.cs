using DesignPatterns.AbstractFactory;
using DesignPatterns.Extensions;
using DesignPatterns.Patterns.Builder;
using DesignPatterns.Patterns.Factory;
using DesignPatterns.Patterns.Singleton;
using DesignPatterns.Patterns.Singleton.Interfaces;
using DesignPatterns.Shared.Helpers;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddProjectDependencies();

var serviceProvider = services.BuildServiceProvider();
var executor = serviceProvider.GetRequiredService<IDatabaseExecutorService>();

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
        switch (patternChoice)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("ABSTRACT FACTORY METHOD.");
                Console.WriteLine();
                AbstractFactoryExecutor.Run();
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("BUILDER METHOD.");
                Console.WriteLine();
                BuilderMethodExecutor.Run();
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("FACTORY METHOD.");
                Console.WriteLine();
                FactoryMethodExecutor.Run();
                break;

            case 4:
                Console.Clear();
                Console.WriteLine("SINGLETON METHOD.");
                Console.WriteLine();
                SingletonMethodExecutor.Run(executor);
                break;

            case 9:
                Console.WriteLine();
                Console.WriteLine("Quiting...");
                Console.WriteLine();
                return;

            default:
                Console.Clear();
                SharedPrintHelpers.InvalidOption();
                break;
        }
    }
    else
    {
        Console.Clear();
        SharedPrintHelpers.InvalidOption();
    }
}