namespace DesignPatterns.Patterns.AbstractFactory.Interfaces
{
    internal interface IFurnitureService
    {
        IChair GetChair();

        ICouch GetCouch();

        ITable GetTable();
    }
}