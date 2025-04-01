using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Entities
{
    internal abstract class ATable : ITable
    {
        protected readonly string typeOfFurniture = "table";

        public void DoAnAction()
        {
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("Select an action:");
                Console.WriteLine("1 - Place on");
                Console.WriteLine("0 - Exit");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                PlaceOn();
                                break;
                            }
                        case 0:
                            {
                                break;
                            }
                        case 2:
                        default:
                            {
                                Console.WriteLine("Invalid option. Try again.");
                                break;
                            }
                    }

                    Console.WriteLine();
                }
                else
                {
                    choice = -1;
                    Console.WriteLine("Invalid option. Try again.");
                    Console.WriteLine();
                }
            }
        }

        public virtual void PlaceOn()
        {
            Console.WriteLine("You place the coffe.");
        }
    }
}