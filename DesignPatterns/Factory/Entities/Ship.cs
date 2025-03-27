using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Entities
{
    internal class Ship : ITransport
    {
        private readonly string typeOfTransport = "ship";

        public void Deliver()
        {
            Console.WriteLine($"Delivering by {typeOfTransport}.");
        }
    }
}