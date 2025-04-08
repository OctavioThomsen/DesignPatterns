namespace DesignPatterns.Singleton.Interfaces
{
    internal interface IDatabase
    {
        string ReadDataBase();

        public string ShowConnectionString();
    }
}