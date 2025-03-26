using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Directors;
using DesignPatterns.Builder.Entities;

namespace DesignPatterns.Builder
{
    public class BuilderMethodExecutor
    {
        public static void Run()
        {
            Console.WriteLine("Select a builder type:");
            Console.WriteLine("1 - Brick");
            Console.WriteLine("2 - Stone");
            Console.WriteLine("3 - Wood");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Director director;
                switch (choice)
                {
                    case 1:
                        {
                            director = new(new BrickHouseBuilder());
                            break;
                        }
                    case 2:
                        {
                            director = new(new StoneHouseBuilder());
                            break;
                        }
                    case 3:
                    default:
                        {
                            director = new(new WoodHouseBuilder());
                            break;
                        }
                }

                int quantity = 0;

                while (choice != 0) 
                {
                    Console.WriteLine("Select what to build:");
                    Console.WriteLine("1 - Walls");
                    Console.WriteLine("2 - Doors");
                    Console.WriteLine("3 - Windows");
                    Console.WriteLine("4 - Roof");
                    Console.WriteLine("5 - Garage");
                    Console.WriteLine("6 - Standard House and show the house");
                    Console.WriteLine("7 - Reset house");
                    Console.WriteLine("0 - Finish and show the house");

                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                {
                                    Console.WriteLine("How many walls?:");
                                    int.TryParse(Console.ReadLine(), out quantity);
                                    director.HouseBuilder.BuildWalls(quantity);
                                    Console.WriteLine($"{quantity} walls created succesfully.");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("How many doors?:");
                                    int.TryParse(Console.ReadLine(), out quantity);
                                    director.HouseBuilder.BuildDoors(quantity);
                                    Console.WriteLine($"{quantity} doors created succesfully.");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("How many windows?:");
                                    int.TryParse(Console.ReadLine(), out quantity);
                                    director.HouseBuilder.BuildWindows(quantity);
                                    Console.WriteLine($"{quantity} windows created succesfully.");
                                    break;
                                }
                            case 4:
                                {
                                    director.HouseBuilder.BuildRoof();
                                    Console.WriteLine("Roof created succesfully.");
                                    break;
                                }
                            case 5:
                                {
                                    director.HouseBuilder.BuildGarage();
                                    Console.WriteLine("Garage created succesfully.");
                                    break;
                                }
                            case 6:
                                {
                                    director.HouseBuilder.Reset();
                                    Console.WriteLine("House reseted");
                                    break;
                                }
                            case 7:
                                {
                                    director.MakeStandarHouse();
                                    Console.WriteLine("Standard house created succesfully.");
                                    choice = 0;
                                    continue;
                                }
                            case 0:
                            default:
                                {
                                    choice = 0;
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                }

                AHouse house = director.HouseBuilder.GetResult();

                Console.WriteLine($"Your house made of {house.Material} have:");
                Console.WriteLine($"{house.Walls} walls");
                Console.WriteLine($"{house.Doors} doors");
                Console.WriteLine($"{house.Windows} windows");
                Console.WriteLine(house.Roof ? "Have a roof" : "Don't have a roof");
                Console.WriteLine(house.Garage ? "Have a garage" : "Don't have a garage");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}
