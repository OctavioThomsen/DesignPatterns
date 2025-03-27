using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Entities
{
    internal abstract class ACouch : ICouch
    {
        protected readonly string typeOfFurniture = "couch";

        public void DoAnAction()
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine("1 - Lie down");
            Console.WriteLine("2 - Sit on");

            if (int.TryParse(Console.ReadLine(), out int choice))
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
                    case 3:
                    default:
                        {
                            Console.WriteLine("Invalid selection.");
                            break;
                        }
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