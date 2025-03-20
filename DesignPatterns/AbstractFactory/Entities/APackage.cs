using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Entities
{
    public abstract class APackage : IPackage
    {
        public string Type = "Package";

        public virtual void Deliver() { }

        public virtual void PrintType() 
        {
            Console.WriteLine("Type of this package is: " + Type);
        }
    }
}
