using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Services;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    public static class AbstractFactoryMethodExecutor
    {
        public static void Run()
        {
            Console.WriteLine("Select a package type:");
            Console.WriteLine("1 - Standard Package");
            Console.WriteLine("2 - Express Package");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                IPackageFactory factory;
                switch (choice)
                {
                    case 1:
                        {
                            factory = new StandardPackageFactory();
                            break;
                        }
                    case 2:
                    default:
                        {
                            factory = new ExpressPackageFactory();
                            break;
                        }
                }

                var packageService = new PackageService(factory);
                packageService.RunFactoryMethod();
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}
