using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder.Directors
{
    internal class Director(IHouseBuilder houseBuilder)
    {
        internal IHouseBuilder HouseBuilder { get; set; } = houseBuilder;

        public void MakeStandardHouse()
        {
            HouseBuilder.Reset();
            HouseBuilder.BuildWalls(4);
            HouseBuilder.BuildDoors(1);
            HouseBuilder.BuildWindows(2);
            HouseBuilder.BuildRoof();
            HouseBuilder.BuildGarage();
        }
    }
}