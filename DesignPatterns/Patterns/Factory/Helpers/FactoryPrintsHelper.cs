namespace DesignPatterns.Patterns.Factory.Helpers
{
    internal static class FactoryPrintsHelper
    {
        public static void LogisticTypeSelector()
        {
            Console.WriteLine("Select a logistic type:");
            Console.WriteLine("1 - Truck");
            Console.WriteLine("2 - Ship");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }

        internal static void PatternDesignTittle()
        {
            Console.WriteLine("FACTORY METHOD.");
            Console.WriteLine();
        }
    }
}