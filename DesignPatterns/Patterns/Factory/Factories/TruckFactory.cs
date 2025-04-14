using DesignPatterns.Patterns.Factory.Entities;
using DesignPatterns.Patterns.Factory.Interfaces;

namespace DesignPatterns.Patterns.Factory.Factories
{
    internal class TruckFactory : ILogisticsFactory
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}