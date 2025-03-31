using DesignPatterns.Builder.Directors;
using DesignPatterns.Singleton.Singleton;

namespace DesignPatterns.Factory
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
                Console.WriteLine("1 - Read data base");
                Console.WriteLine("2 - Clear data base instance");
                Console.WriteLine("3 - Show connection string");
                Console.WriteLine("0 - Exit");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                DataBase = DataBase.GetInstance();
                                Console.WriteLine(DataBase.ReadDataBase());
                                break;
                            }
                        case 2:
                            {
                                if (DataBase == null)
                                {
                                    Console.WriteLine("Data base was not created.");
                                }
                                else
                                {
                                    DataBase = null;
                                    Console.WriteLine("Data base cleared succesfully.");
                                }
                                break;
                            }
                        case 3:
                            {
                                DataBase = DataBase.GetInstance();
                                Console.WriteLine(DataBase.ShowConnectionString());
                                break;
                            }
                        case 0:
                            {
                                choice = 0;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid selection.");
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }

        }
    }
}