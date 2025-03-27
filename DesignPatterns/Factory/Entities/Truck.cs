using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Entities
{
    internal class Truck : ITransport
    {
        private readonly string typeOfTransport = "truck";

        public void Deliver()
        {
            Console.WriteLine($"Delivering by {typeOfTransport}.");
        }
    }
}