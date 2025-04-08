using DesignPatterns.Shared.Helpers;
using DesignPatterns.Singleton.Interfaces;

namespace DesignPatterns.Singleton.Services
{
    internal class DatabaseExecutorService : IDatabaseExecutorService
    {
        private readonly IDatabase _database;

        public DatabaseExecutorService(IDatabase database)
        {
            _database = database;
        }

        public void Execute(int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine(_database.ShowConnectionString());
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine(_database.ReadDataBase());
                    Console.WriteLine();
                    break;

                case 9:
                    Console.Clear();
                    break;

                default:
                    SharedPrintHelpers.InvalidOption();
                    break;
            }
        }
    }
}