using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Entities
{
    public class StandardPackage : IPackage
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering a standard package.");
        }
    }
}
