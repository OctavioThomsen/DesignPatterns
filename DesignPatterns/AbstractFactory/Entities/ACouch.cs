using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Entities
{
    internal abstract class ACouch : ICouch
    {
        protected readonly string typeOfFurniture = "couch";

        public void DoAnAction()
        {
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("Select an action:");
                Console.WriteLine("1 - Lie down");
                Console.WriteLine("2 - Sit on");
                Console.WriteLine("0 - Exit");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                LieDown();
                                break;
                            }
                        case 2:
                            {
                                SitOn();
                                break;
                            }
                        case 0:
                            {
                                break;
                            }
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
                    Console.Clear();
                    Console.WriteLine("Invalid option. Try again.");
                    Console.WriteLine();
                }
            }
        }

        public virtual void LieDown()
        {
            Console.WriteLine("You lie down on the couch.");
        }

        public virtual void SitOn()
        {
            Console.WriteLine($"You sit on the {typeOfFurniture}.");
        }
    }
}