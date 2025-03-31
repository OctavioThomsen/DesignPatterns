namespace DesignPatterns.Singleton.Singleton
{
    internal class DataBase
    {
        private static DataBase? Instance;
        private static string? ConnectionString;
        public string? Data { get; set; }

        private DataBase()
        {
            ConnectionString = "SQLconnection";
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

        public string ReadDataBase()
        {
            Console.WriteLine("Going back and forth to the database to obtain the information.");
            Data = "Data example";

            return $"Returning data: {Data}";
        }
    }
}