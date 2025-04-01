using DesignPatterns.Singleton.Singleton;

namespace DesignPatterns.Singleton
{
    internal static class SingletonMethodExecutor
    {
        private static DataBase? DataBase;

        internal static void Run()
        {
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("Select what to do:");
                Console.WriteLine("1 - Get database instance");
                Console.WriteLine("2 - Clear database instance");
                Console.WriteLine("3 - Show connection string");
                Console.WriteLine("4 - Read from data base");
                Console.WriteLine("0 - Exit");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                DataBase = DataBase.GetInstance();
                                Console.WriteLine();
                                break;
                            }
                        case 2:
                            {
                                if (DataBase == null)
                                {
                                    Console.WriteLine("Database is not instanced.");
                                }
                                else
                                {
                                    DataBase = null;
                                    Console.WriteLine("Database cleared succesfully.");
                                }
                                Console.WriteLine();
                                break;
                            }
                        case 3:
                            {
                                if (DataBase == null)
                                {
                                    Console.WriteLine("Database is not instanced.");
                                }
                                else
                                {
                                    Console.WriteLine(DataBase.ShowConnectionString());
                                }
                                Console.WriteLine();
                                break;
                            }
                        case 4:
                            {
                                if (DataBase == null)
                                {
                                    Console.WriteLine("Database is not instanced.");
                                }
                                else
                                {
                                    Console.WriteLine(DataBase.ReadDataBase());
                                }
                                Console.WriteLine();
                                break;
                            }
                        case 0:
                            {
                                Console.Clear();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid option. Try again.");
                                Console.WriteLine();
                                break;
                            }
                    }
                }
                else
                {
                    choice = -1;
                    Console.WriteLine();
                    Console.WriteLine("Invalid option. Try again.");
                    Console.WriteLine();
                }
            }
        }
    }
}