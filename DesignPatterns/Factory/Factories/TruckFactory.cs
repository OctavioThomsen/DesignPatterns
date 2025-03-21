using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Factories
{
    public class TruckFactory : ILogisticsFactory
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
