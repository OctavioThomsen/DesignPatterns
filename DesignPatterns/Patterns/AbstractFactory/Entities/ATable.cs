using DesignPatterns.Patterns.AbstractFactory.Interfaces;

namespace DesignPatterns.Patterns.AbstractFactory.Entities
{
    internal abstract class ATable : ITable
    {
        protected readonly string typeOfFurniture = "table";

        public virtual void PlaceOn()
        {
            Console.WriteLine("You place the coffe.");
        }
    }
}