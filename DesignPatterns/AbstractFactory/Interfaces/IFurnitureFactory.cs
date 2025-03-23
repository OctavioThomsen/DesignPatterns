namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface IFurnitureFactory
    {
        public ICouch CreateCouch();

        public IChair CreateChair();

        public ITable CreateTable();
    }
}
