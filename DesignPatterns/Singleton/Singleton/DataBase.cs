using DesignPatterns.Singleton.Helpers;

namespace DesignPatterns.Singleton.Singleton
{
    internal class Database
    {
        private static string? ConnectionString;
        private static Database? Instance;
        public string? Data { get; set; }

        private Database()
        {
            ConnectionString = "SQLconnection";
        }

        public string ReadDataBase()
        {
            Data = "Data example";

            return $"Returning data: {Data}";
        }

        public static string ShowConnectionString()
        {
            return $"Connection string: '{ConnectionString}'";
        }

        internal static Database GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Database();
                SingletonPrintsHelper.DatabaseCreatedForFirstTime();
            }
            else
            {
                SingletonPrintsHelper.DatabaseAlreadyCreated();
            }
            Console.WriteLine();

            return Instance;
        }
    }
}