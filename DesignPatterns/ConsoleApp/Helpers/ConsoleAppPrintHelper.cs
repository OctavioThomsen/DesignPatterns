namespace DesignPatterns.ConsoleApp.Helpers
{
    internal static class ConsoleAppPrintHelper
    {
        public static void DesignPatternSelector()
        {
            Console.WriteLine("Select a design pattern:");
            Console.WriteLine("1 - Abstract Factory Method");
            Console.WriteLine("2 - Builder Method");
            Console.WriteLine("3 - Factory Method");
            Console.WriteLine("4 - Singleton Method");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }

        public static void Quitting()
        {
            Console.WriteLine();
            Console.WriteLine("Quitting...");
            Console.WriteLine();
        }
    }
}
