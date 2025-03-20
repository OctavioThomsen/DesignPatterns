using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Entities
{
    public class ExpressPackage : IPackage
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering a express package.");
        }
    }
}
