using DesignPatterns.Builder.Helpers;

namespace DesignPatterns.Builder.Services
{
    internal static class BuildMenuService
    {
        public static void Start(HouseConstructionService houseService)
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
                            houseService.BuildWalls(quantity);
                            Console.WriteLine($"{quantity} walls created successfully.");
                            break;

                        case 2:
                            Console.Write("How many doors?: ");
                            int.TryParse(Console.ReadLine(), out quantity);
                            houseService.BuildDoors(quantity);
                            Console.WriteLine($"{quantity} doors created successfully.");
                            break;

                        case 3:
                            Console.Write("How many windows?: ");
                            int.TryParse(Console.ReadLine(), out quantity);
                            houseService.BuildWindows(quantity);
                            Console.WriteLine($"{quantity} windows created successfully.");
                            break;

                        case 4:
                            houseService.BuildRoof();
                            Console.WriteLine("Roof created successfully.");
                            break;

                        case 5:
                            houseService.BuildGarage();
                            Console.WriteLine("Garage created successfully.");
                            break;

                        case 6:
                            houseService.MakeStandardHouse();
                            Console.WriteLine("Standard house created successfully.");
                            break;

                        case 7:
                            var house = houseService.GetHouse();
                            Console.WriteLine($"Your house made of {house.Material} has:");
                            Console.WriteLine($"{house.Walls} walls");
                            Console.WriteLine($"{house.Doors} doors");
                            Console.WriteLine($"{house.Windows} windows");
                            Console.WriteLine(house.Roof ? "Has a roof" : "No roof");
                            Console.WriteLine(house.Garage ? "Has a garage" : "No garage");
                            break;

                        case 8:
                            houseService.Reset();
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