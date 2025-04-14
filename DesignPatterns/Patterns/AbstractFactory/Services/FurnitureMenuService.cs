using DesignPatterns.Patterns.AbstractFactory.Helpers;
using DesignPatterns.Patterns.AbstractFactory.Interfaces;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.Patterns.AbstractFactory.Services
{
    internal static class FurnitureMenuService
    {
        public static void Start(FurnitureService furnitureService)
        {
            int furnitureChoice = -1;

            while (furnitureChoice != 9)
            {
                AbstractFactoryPrintsHelper.FurnitureSelector();

                if (int.TryParse(Console.ReadLine(), out furnitureChoice))
                {
                    IFurniture? furniture = furnitureService.Execute(furnitureChoice);

                    if (furniture != null)
                    {
                        Console.WriteLine();
                        HandleFurnitureAction(furniture);
                    }
                }
                else
                {
                    SharedPrintHelpers.InvalidOption();
                }
            }
        }

        private static void HandleFurnitureAction(IFurniture furniture)
        {
            switch (furniture)
            {
                case IChair chair:
                    HandleChairActions(chair);
                    break;

                case ICouch couch:
                    HandleCouchActions(couch);
                    break;

                case ITable table:
                    HandleTableActions(table);
                    break;

                default:
                    Console.WriteLine("Unknown furniture type.");
                    break;
            }
        }

        private static void HandleChairActions(IChair chair)
        {
            int option = -1;

            while (option != 9)
            {
                AbstractFactoryPrintsHelper.ChairActionSelector();

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option == 1)
                        chair.SitOn();
                    else if (option != 9)
                        SharedPrintHelpers.InvalidOption();
                }
                else
                {
                    SharedPrintHelpers.InvalidOption();
                }

                Console.WriteLine();
            }
        }

        private static void HandleCouchActions(ICouch couch)
        {
            int option = -1;

            while (option != 9)
            {
                AbstractFactoryPrintsHelper.CouchActionSelector();

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option == 1)
                        couch.SitOn();
                    else if (option == 2)
                        couch.LieDown();
                    else if (option != 9)
                        SharedPrintHelpers.InvalidOption();
                }
                else
                {
                    SharedPrintHelpers.InvalidOption();
                }

                Console.WriteLine();
            }
        }

        private static void HandleTableActions(ITable table)
        {
            int option = -1;

            while (option != 9)
            {
                AbstractFactoryPrintsHelper.TableActionSelector();

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option == 1)
                        table.PlaceOn();
                    else if (option != 9)
                        SharedPrintHelpers.InvalidOption();
                }
                else
                {
                    SharedPrintHelpers.InvalidOption();
                }

                Console.WriteLine();
            }
        }
    }
}