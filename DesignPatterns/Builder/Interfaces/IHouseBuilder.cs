using DesignPatterns.Builder.Entities;

namespace DesignPatterns.Builder.Interfaces
{
    internal interface IHouseBuilder
    {
        void BuildDoors(int doors);

        void BuildGarage();

        void BuildRoof();

        void BuildWalls(int walls);

        void BuildWindows(int windows);

        AHouse GetResult();

        void Reset();
    }
}