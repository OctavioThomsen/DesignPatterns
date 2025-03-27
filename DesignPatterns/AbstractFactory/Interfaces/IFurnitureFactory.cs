namespace DesignPatterns.AbstractFactory.Interfaces
{
    internal interface IFurnitureFactory
    {
        ICouch CreateCouch();

        IChair CreateChair();

        ITable CreateTable();
    }
}