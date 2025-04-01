namespace DesignPatterns.Singleton.Singleton
{
    internal class DataBase
    {
        private static string? ConnectionString;
        private static DataBase? Instance;
        public string? Data { get; set; }

        private DataBase()
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

        internal static DataBase GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DataBase();
                Console.WriteLine("DataBase created.");
            }
            else
            {
                Console.WriteLine("DataBase was already created.");
            }

            return Instance;
        }
    }
}