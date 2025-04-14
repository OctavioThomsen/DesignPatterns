namespace DesignPatterns.Patterns.Singleton.Helpers
{
    internal static class SingletonPrintsHelper
    {
        public static void WhatToDoSelector()
        {
            Console.WriteLine("Select what to do:");
            Console.WriteLine("1 - Show connection string");
            Console.WriteLine("2 - Read from data base");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }
    }
}