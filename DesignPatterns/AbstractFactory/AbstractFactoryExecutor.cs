using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Interfaces;
using DesignPatterns.AbstractFactory.Services;

namespace DesignPatterns.AbstractFactory
{
    internal static class AbstractFactoryMethodExecutor
    {
        internal static void Run()
        {
            FurnitureService? furnitureService = null;
            int modelChoice = -1;
            int furnitureChoice = -1;

            while (modelChoice != 0)
            {
                Console.WriteLine("Select a model:");
                Console.WriteLine("1 - ArtDeco");
                Console.WriteLine("2 - Modern");
                Console.WriteLine("3 - Victorian");
                Console.WriteLine("0 - Exit");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out modelChoice))
                {
                    Console.WriteLine();

                    switch (modelChoice)
                    {
                        case 1:
                            {
                                furnitureService = new(new ArtDecoFurnitureFactory());
                                break;
                            }
                        case 2:
                            {
                                furnitureService = new(new ModernFurnitureFactory());
                                break;
                            }
                        case 3:
                            {
                                furnitureService = new(new VictorianFurnitureFactory());
                                break;
                            }
                        case 0:
                            {
                                furnitureService = null;
                                Console.Clear();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid option. Try again.");
                                Console.WriteLine();
                                break;
                            }
                    }

                    furnitureChoice = -1;

                    while (furnitureService != null && furnitureChoice != 0)
                    {
                        Console.WriteLine("Select a furniture:");
                        Console.WriteLine("1 - Couch");
                        Console.WriteLine("2 - Chair");
                        Console.WriteLine("3 - Table");
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine();

                        if (int.TryParse(Console.ReadLine(), out furnitureChoice))
                        {
                            IFurniture? furniture = null;

                            switch (furnitureChoice)
                            {
                                case 1:
                                    {
                                        furniture = furnitureService.GetCouch();
                                        break;
                                    }
                                case 2:
                                    {
                                        furniture = furnitureService.GetChair();
                                        break;
                                    }
                                case 3:
                                    {
                                        furniture = furnitureService.GetTable();
                                        break;
                                    }
                                case 0:
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Invalid option. Try again.");
                                        Console.WriteLine();
                                        break;
                                    }
                            }

                            Console.WriteLine();

                            furniture?.DoAnAction();
                        }
                        else
                        {
                            furnitureChoice = -1;
                            Console.WriteLine();
                            Console.WriteLine("Invalid option. Try again.");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    modelChoice = -1;
                    Console.WriteLine();
                    Console.WriteLine("Invalid option. Try again.");
                    Console.WriteLine();
                }
            }
        }
    }
}