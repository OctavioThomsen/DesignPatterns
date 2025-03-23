using DesignPatterns.Factory.Factories;
using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Factory.Services;

namespace DesignPatterns.Factory
{
    public static class FactoryMethodExecutor
    {
        public static void Run()
        {
            Console.WriteLine("Select a logistic type:");
            Console.WriteLine("1 - Truck");
            Console.WriteLine("2 - Ship");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                ILogisticsFactory factory;
                switch (choice)
                {
                    case 1:
                        {
                            factory = new TruckFactory();
                            break;
                        }
                    case 2:
                    default:
                        {
                            factory = new ShipFactory();
                            break;
                        }
                }

                var logisticsService = new LogisticsService(factory);
                logisticsService.RunFactoryMethod();
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}