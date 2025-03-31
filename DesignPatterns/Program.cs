using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;

while (true)
{
    Console.WriteLine("Select a design pattern:");
    Console.WriteLine("1 - Factory Method");
    Console.WriteLine("2 - Abstract Method");
    Console.WriteLine("3 - Builder Method");
    Console.WriteLine("4 - Singleton Method");
    Console.WriteLine("0 - Exit");

    if (int.TryParse(Console.ReadLine(), out int patternChoice))
    {
        switch (patternChoice)
        {
            case 1:
                FactoryMethodExecutor.Run();
                break;

            case 2:
                AbstractFactoryMethodExecutor.Run();
                break;

            case 3:
                BuilderMethodExecutor.Run();
                break;

            case 4:
                SingletonMethodExecutor.Run();
                break;

            case 0:
                return;

            default:
                Console.WriteLine("Invalid option. Try again.");
                break;
        }
    }
}