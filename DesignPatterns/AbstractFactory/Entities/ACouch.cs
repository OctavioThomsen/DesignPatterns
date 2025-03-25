using DesignPatterns.AbstractFactory.Interfaces;
using DesignPatterns.AbstractFactory.Services;
using DesignPatterns.Factory.Services;

namespace DesignPatterns.AbstractFactory.Entities
{
    public class ACouch : ICouch
    {
        public string typeOfFurniture = "Couch";

        public virtual void LieDown()
        {
            Console.WriteLine("You lie down on the couch.");
        }

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

        public virtual void SitOn()
        {
            Console.WriteLine($"You sit on the {typeOfFurniture}.");
        }
    }
}
