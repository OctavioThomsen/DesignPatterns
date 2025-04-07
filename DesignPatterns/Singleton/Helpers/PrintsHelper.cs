namespace DesignPatterns.Singleton.Helpers
{
    internal static class PrintsHelper
    {
        public static void WhatToDoSelector()
        {
            Console.WriteLine("Select what to do:");
            Console.WriteLine("1 - Get database instance");
            Console.WriteLine("2 - Clear database instance");
            Console.WriteLine("3 - Show connection string");
            Console.WriteLine("4 - Read from data base");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }

        public static void InvalidOption()
        {
            Console.WriteLine("Invalid option. Try again.");
            Console.WriteLine();
        }

        public static void DatabaseNotInstanced()
        {
            Console.WriteLine("Database is not instanced.");
            Console.WriteLine();
        }

        public static void DatabaseCleared()
        {
            Console.WriteLine("Database cleared succesfully.");
            Console.WriteLine();
        }

        public static void DatabaseAlreadyCreated()
        {
            Console.WriteLine("Database was already created. Obtaining its instance.");
            Console.WriteLine();
        }

        public static void DatabaseAlreadyInstanced()
        {
            Console.WriteLine("Database its already instanced.");
            Console.WriteLine();
        }

        public static void DatabaseCreatedForFirstTime()
        {
            Console.WriteLine("Database created for the first time.");
            Console.WriteLine();
        }
    }
}
