using DesignPatterns.Patterns.Singleton.Interfaces;

namespace DesignPatterns.Patterns.Singleton.Singleton
{
    internal class Database : IDatabase
    {
        private static Database? _instance;
        private static readonly object _lock = new();
        private readonly string? ConnectionString;

        private Database()
        {
            ConnectionString = "SQLconnection";
            Console.WriteLine("Database instance created by DI.");
        }

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance = new Database();
                }
            }

            return _instance;
        }

        public string ReadDataBase()
        {
            string Data = "Data example";

            return $"Returning data: {Data}";
        }

        public string ShowConnectionString()
        {
            return $"Connection string: '{ConnectionString}'";
        }
    }
}