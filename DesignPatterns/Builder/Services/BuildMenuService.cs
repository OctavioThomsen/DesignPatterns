using DesignPatterns.Builder.Helpers;

namespace DesignPatterns.Builder.Services
{
    internal static class BuildMenuService
    {
        public static void Start(HouseConstructionService houseConstructionService)
        {
            int buildChoice = -1;
            int quantity;

            while (buildChoice != 9)
            {
                PrintsHelper.WhatToBuildSelector();

                if (int.TryParse(Console.ReadLine(), out buildChoice))
                {
                    switch (buildChoice)
                    {
                        case 1:
                            Console.Write("How many walls?: ");
                            int.TryParse(Console.ReadLine(), out quantity);
                            houseConstructionService.BuildWalls(quantity);
                            Console.WriteLine($"{quantity} walls created successfully.");
                            break;

                        case 2:
                            Console.Write("How many doors?: ");
                            int.TryParse(Console.ReadLine(), out quantity);
                            houseConstructionService.BuildDoors(quantity);
                            Console.WriteLine($"{quantity} doors created successfully.");
                            break;

                        case 3:
                            Console.Write("How many windows?: ");
                            int.TryParse(Console.ReadLine(), out quantity);
                            houseConstructionService.BuildWindows(quantity);
                            Console.WriteLine($"{quantity} windows created successfully.");
                            break;

                        case 4:
                            houseConstructionService.BuildRoof();
                            Console.WriteLine("Roof created successfully.");
                            break;

                        case 5:
                            houseConstructionService.BuildGarage();
                            Console.WriteLine("Garage created successfully.");
                            break;

                        case 6:
                            houseConstructionService.MakeStandardHouse();
                            Console.WriteLine("Standard house created successfully.");
                            break;

                        case 7:
                            var house = houseConstructionService.GetHouse();
                            Console.WriteLine($"Your house made of {house.Material} has:");
                            Console.WriteLine($"{house.Walls} walls");
                            Console.WriteLine($"{house.Doors} doors");
                            Console.WriteLine($"{house.Windows} windows");
                            Console.WriteLine(house.Roof ? "Has a roof" : "No roof");
                            Console.WriteLine(house.Garage ? "Has a garage" : "No garage");
                            break;

                        case 8:
                            houseConstructionService.Reset();
                            Console.WriteLine("House reset.");
                            break;

                        case 9:
                            break;

                        default:
                            PrintsHelper.InvalidOption();
                            break;
                    }
                    Console.WriteLine();
                }
                else
                {
                    PrintsHelper.InvalidOption();
                }
            }
        }
    }
}