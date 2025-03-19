using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Models
{
    public class StandardPackage : IPackage
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering a standar package.");
        }
    }
}
