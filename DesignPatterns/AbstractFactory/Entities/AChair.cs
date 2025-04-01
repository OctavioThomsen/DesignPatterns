using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Entities
{
    internal abstract class AChair : IChair
    {
        protected readonly string typeOfFurniture = "chair";

        public void DoAnAction()
        {
            int choice = -1;

            while (choice != 0) {

                Console.WriteLine("Select an action:");
                Console.WriteLine("1 - Sit on");
                Console.WriteLine("0 - Exit");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
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
                    Console.WriteLine("Invalid option. Try again.");
                    Console.WriteLine();
                }
            }
        }

        public virtual void SitOn()
        {
            Console.WriteLine("You sit on the chair.");
        }
    }
}