using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;
using DesignPatterns.Singleton.Services;
using DesignPatterns.Singleton.Singleton;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Starting dependency inyection:");
var services = new ServiceCollection();
services.AddSingleton<Database>(provider => Database.GetInstance());
services.AddTransient<DatabaseExecutorService>();
var serviceProvider = services.BuildServiceProvider();
var executor = serviceProvider.GetRequiredService<DatabaseExecutorService>();
Console.WriteLine("Ending dependency inyection.");
Console.WriteLine();

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
                AbstractFactoryMethodExecutor.Run();
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
                Console.WriteLine("Invalid option. Try again.");
                Console.WriteLine();
                break;
        }
    }
    else
    {
        patternChoice = -1;
        Console.Clear();
        Console.WriteLine("Invalid option. Try again.");
        Console.WriteLine();
    }
}