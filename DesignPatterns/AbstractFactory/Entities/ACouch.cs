using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Entities
{
    internal abstract class ACouch : ICouch
    {
        protected readonly string typeOfFurniture = "couch";

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