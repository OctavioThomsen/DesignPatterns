using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Factories
{
    internal class TruckFactory : ILogisticsFactory
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}