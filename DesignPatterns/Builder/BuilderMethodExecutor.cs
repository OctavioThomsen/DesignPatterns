using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Directors;
using DesignPatterns.Builder.Entities;

namespace DesignPatterns.Builder
{
    internal class BuilderMethodExecutor
    {
        internal static void Run()
        {
            Director? director = null;
            int directorChoice = -1;
            int buildChoice = -1;
            int quantity = 0;

            while (directorChoice != 0)
            {
                Console.WriteLine("Select a builder type:");
                Console.WriteLine("1 - Brick");
                Console.WriteLine("2 - Stone");
                Console.WriteLine("3 - Wood");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out directorChoice))
                {
                    Console.WriteLine();

                    switch (directorChoice)
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
                            {
                                director = new(new WoodHouseBuilder());
                                break;
                            }
                        case 0:
                            {
                                director = null;
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

                    buildChoice = -1;

                    while (director != null && buildChoice != 0)
                    {
                        Console.WriteLine("Select what to build:");
                        Console.WriteLine("1 - Walls");
                        Console.WriteLine("2 - Doors");
                        Console.WriteLine("3 - Windows");
                        Console.WriteLine("4 - Roof");
                        Console.WriteLine("5 - Garage");
                        Console.WriteLine("6 - Create a standard house");
                        Console.WriteLine("7 - Show the house");
                        Console.WriteLine("8 - Reset house");
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine();

                        if (int.TryParse(Console.ReadLine(), out buildChoice))
                        {
                            switch (buildChoice)
                            {
                                case 1:
                                    {
                                        Console.Write("How many walls?: ");
                                        int.TryParse(Console.ReadLine(), out quantity);
                                        director.HouseBuilder.BuildWalls(quantity);
                                        Console.WriteLine($"{quantity} walls created succesfully.");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("How many doors?: ");
                                        int.TryParse(Console.ReadLine(), out quantity);
                                        director.HouseBuilder.BuildDoors(quantity);
                                        Console.WriteLine($"{quantity} doors created succesfully.");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write("How many windows?: ");
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
                                        director.MakeStandardHouse();
                                        Console.WriteLine("Standard house created succesfully.");
                                        break;
                                    }
                                case 7:
                                    {
                                        AHouse house = director.HouseBuilder.GetResult();

                                        Console.WriteLine($"Your house made of {house.Material} have:");
                                        Console.WriteLine($"{house.Walls} walls");
                                        Console.WriteLine($"{house.Doors} doors");
                                        Console.WriteLine($"{house.Windows} windows");
                                        Console.WriteLine(house.Roof ? "Have a roof" : "Don't have a roof");
                                        Console.WriteLine(house.Garage ? "Have a garage" : "Don't have a garage");
                                        break;
                                    }
                                case 8:
                                    {
                                        director.HouseBuilder.Reset();
                                        Console.WriteLine("House reseted");
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
                        }
                        else
                        {
                            buildChoice = -1;
                            Console.WriteLine();
                            Console.WriteLine("Invalid option. Try again.");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    directorChoice = -1;
                    Console.WriteLine();
                    Console.WriteLine("Invalid option. Try again.");
                    Console.WriteLine();
                }
            }
        }
    }
}