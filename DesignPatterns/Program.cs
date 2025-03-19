using DesignPatterns.Factory.Services;

// Injeccion de dependencia: Factory
var packageService = new PackageService();

while (true)
{
    Console.WriteLine("Select a design pattern:");
    Console.WriteLine("1 - Factory Method");
    Console.WriteLine("0 - Exit");

    if (int.TryParse(Console.ReadLine(), out int patternChoice))
    {
        switch (patternChoice)
        {
            case 1:
                packageService.RunFactoryMethod();
                break;
            case 0:
                return;
            default:
                Console.WriteLine("Invalid option. Try again.");
                break;
        }
    }
}
