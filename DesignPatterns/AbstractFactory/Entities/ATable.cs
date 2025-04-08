using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Entities
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