namespace DesignPatterns.Patterns.Singleton.Interfaces
{
    internal interface IDatabase
    {
        string ReadDataBase();

        public string ShowConnectionString();
    }
}