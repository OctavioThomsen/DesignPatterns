using DesignPatterns.Factory.Factories;

namespace DesignPatterns.Factory.Services
{
    internal static class LogisticsExecutorService
    {
        public static void Execute(int option)
        {
            LogisticsService? logisticsService = option switch
            {
                1 => new LogisticsService(new TruckFactory()),
                2 => new LogisticsService(new ShipFactory()),
                _ => null
            };

            logisticsService?.GetAndDeliverPackage();
        }
    }
}