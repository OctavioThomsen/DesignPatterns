using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Entities
{
    internal abstract class AChair : IChair
    {
        protected readonly string typeOfFurniture = "chair";

        public void DoAnAction()
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine("1 - Sit on");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        {
                            SitOn();
                            break;
                        }
                    case 2:
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
            Console.WriteLine("You sit on the chair.");
        }
    }
}