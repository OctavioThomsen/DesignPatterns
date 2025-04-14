using DesignPatterns.Patterns.Factory.Entities;
using DesignPatterns.Patterns.Factory.Interfaces;

namespace DesignPatterns.Patterns.Factory.Factories
{
    internal class ShipFactory : ILogisticsFactory
    {
        public ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}