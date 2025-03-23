using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Services;
using DesignPatterns.AbstractFactory.Interfaces;
using DesignPatterns.AbstractFactory.Entities;

namespace DesignPatterns.AbstractFactory
{
    public static class AbstractFactoryMethodExecutor
    {
        public static void Run()
        {
            Console.WriteLine("Select a model:");
            Console.WriteLine("1 - ArtDeco");
            Console.WriteLine("2 - Modern");
            Console.WriteLine("3 - Victorian");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                IFurnitureFactory furnitureFactory;
                switch (choice)
                {
                    case 1:
                        {
                            furnitureFactory = new ArtDecoFurnitureFactory();
                            break;
                        }
                    case 2:
                        {
                            furnitureFactory = new ModernFurnitureFactory();
                            break;
                        }
                    case 3:
                    default:
                        {
                            furnitureFactory = new VictorianFurnitureFactory();
                            break;
                        }
                }

                var FurnitureService = new FurnitureService(furnitureFactory);

                Console.WriteLine("Select a furniture:");
                Console.WriteLine("1 - Couch");
                Console.WriteLine("2 - Chair");
                Console.WriteLine("3 - Table");

                if (int.TryParse(Console.ReadLine(), out choice))
                {

                    IFurniture furniture;
                    switch (choice)
                    {
                        case 1:
                            {
                                furniture = FurnitureService.GetCouch();
                                break;
                            }
                        case 2:
                            {
                                furniture = FurnitureService.GetChair();
                                break;
                            }
                        case 3:
                        default:
                            {
                                furniture = FurnitureService.GetTable();
                                break;
                            }
                    }

                    furniture.DoAnAction();
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}
