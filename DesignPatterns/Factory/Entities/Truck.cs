using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Entities
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by truck.");
        }
    }
}
