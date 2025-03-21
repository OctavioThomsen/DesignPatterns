using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Entities
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by ship.");
        }
    }
}
