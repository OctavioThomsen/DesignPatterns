using DesignPatterns.Patterns.Factory.Interfaces;

namespace DesignPatterns.Patterns.Factory.Entities
{
    internal class Truck : ITransport
    {
        private readonly string typeOfTransport = "truck";

        public void Deliver()
        {
            Console.WriteLine($"Delivering by {typeOfTransport}.");
            Console.WriteLine();
        }
    }
}