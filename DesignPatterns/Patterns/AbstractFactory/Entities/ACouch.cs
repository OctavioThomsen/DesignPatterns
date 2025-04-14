using DesignPatterns.Patterns.AbstractFactory.Interfaces;

namespace DesignPatterns.Patterns.AbstractFactory.Entities
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