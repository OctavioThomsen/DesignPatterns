namespace DesignPatterns.AbstractFactory.Interfaces
{
    internal interface ICouch : IFurniture
    {
        void SitOn();

        void LieDown();
    }
}