using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Models
{
    public class ExpressPackage : IPackage
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering a express package.");
        }
    }
}
