using DesignPatterns.Factory.Factories;
using DesignPatterns.Factory.Services;

namespace DesignPatterns.Factory
{
    internal static class FactoryMethodExecutor
    {
        internal static void Run()
        {
            LogisticsService? logisticsService = null;
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("Select a logistic type:");
                Console.WriteLine("1 - Truck");
                Console.WriteLine("2 - Ship");
                Console.WriteLine("0 - Exit");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            {
                                logisticsService = new(new TruckFactory());
                                break;
                            }
                        case 2:
                            {
                                logisticsService = new(new ShipFactory());
                                break;
                            }
                        case 0:
                            {
                                logisticsService = null;
                                Console.Clear();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid option. Try again.");
                                break;
                            }
                    }

                    logisticsService?.RunFactoryMethod();
                }
                else
                {
                    choice = -1;
                    Console.Clear();
                    Console.WriteLine("Invalid option. Try again.");
                    Console.WriteLine();
                }
            }
        }
    }
}