using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Factories
{
    public class ShipFactory : ILogisticsFactory
    {
        public ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
