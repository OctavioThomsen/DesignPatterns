using DesignPatterns.Patterns.AbstractFactory.Interfaces;

namespace DesignPatterns.Patterns.AbstractFactory.Entities
{
    internal abstract class AChair : IChair
    {
        protected readonly string typeOfFurniture = "chair";

        public virtual void SitOn()
        {
            Console.WriteLine("You sit on the chair.");
        }
    }
}