using DesignPatterns.Builder.Entities;

namespace DesignPatterns.Builder.Interfaces
{
    public interface IHouseBuilder
    {
        void BuildWalls(int walls);

        void BuildDoors(int doors);

        void BuildWindows(int windows);

        void BuildRoof();

        void BuildGarage();

        void Reset();

        AHouse GetResult();
    }
}
