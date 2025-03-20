using DesignPatterns.Factory.Factories;
using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Factory.Services;

namespace DesignPatterns.Factory
{
    public static class FactoryMethodExecutor
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