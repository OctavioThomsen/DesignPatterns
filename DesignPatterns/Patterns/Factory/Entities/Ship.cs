using DesignPatterns.Patterns.Factory.Interfaces;

namespace DesignPatterns.Patterns.Factory.Entities
{
    internal class Ship : ITransport
    {
        private readonly string typeOfTransport = "ship";

        public void Deliver()
        {
            Console.WriteLine($"Delivering by {typeOfTransport}.");
            Console.WriteLine();
        }
    }
}