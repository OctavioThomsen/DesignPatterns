using DesignPatterns.Singleton.Helpers;
using DesignPatterns.Singleton.Singleton;

namespace DesignPatterns.Singleton.Services
{
    internal class DatabaseExecutorService
    {
        private Database? database;

        public DatabaseExecutorService(Database? database)
        {
            this.database = database;
        }

        public void Execute(int option)
        {
            switch (option)
            {
                case 1:
                    {
                        GetDatabase();
                        break;
                    }
                case 2:
                    {
                        ClearDatabaseInstance();
                        break;
                    }
                case 3:
                    {
                        ShowConnectionString();
                        break;
                    }
                case 4:
                    {
                        GetDatabase();
                        break;
                    }
                case 9:
                    {
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        PrintsHelper.InvalidOption();
                        break;
                    }
            }
        }

        private void GetDatabase()
        {
            if (IsDatabaseInstanced())
            {
                PrintsHelper.DatabaseAlreadyInstanced();
            }
            else
            {
                database = Database.GetInstance();
            }
        }

        private void ClearDatabaseInstance()
        {
            if (IsDatabaseInstanced())
            {
                database = null;
                PrintsHelper.DatabaseCleared();
            }
            else
            {
                PrintsHelper.DatabaseNotInstanced();
            }
        }

        internal void ReadDatabase()
        {
            if (IsDatabaseInstanced())
            {
                Console.WriteLine(database!.ReadDataBase());
                Console.WriteLine();
            }
            else
            {
                PrintsHelper.DatabaseNotInstanced();
            }
        }

        private void ShowConnectionString()
        {
            if (IsDatabaseInstanced())
            {
                Console.WriteLine(Database.ShowConnectionString());
                Console.WriteLine();
            }
            else
            {
                PrintsHelper.DatabaseNotInstanced();
            }
        }

        private bool IsDatabaseInstanced()
        {
            return database != null;
        }
    }
}