namespace DesignPatterns.Factory.Helpers
{
    internal static class PrintsHelper
    {
        public static void LogisticTypeSelector()
        {
            Console.WriteLine("Select a logistic type:");
            Console.WriteLine("1 - Truck");
            Console.WriteLine("2 - Ship");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }

        public static void InvalidOption()
        {
            Console.WriteLine("Invalid option. Try again.");
            Console.WriteLine();
        }
    }
}
