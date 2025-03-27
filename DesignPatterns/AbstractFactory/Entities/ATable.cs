using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Entities
{
    internal abstract class ATable : ITable
    {
        protected readonly string typeOfFurniture = "table";

        public void DoAnAction()
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine("1 - Place on");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        {
                            PlaceOn();
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

        public virtual void PlaceOn()
        {
            Console.WriteLine("You place the coffe.");
        }
    }
}