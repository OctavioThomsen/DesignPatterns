using DesignPatterns.Patterns.Builder.Interfaces;

namespace DesignPatterns.Patterns.Builder.Directors
{
    internal class Director : IDirector
    {
        internal IHouseBuilder HouseBuilder { get; set; }

        internal Director(IHouseBuilder houseBuilder)
        {
            HouseBuilder = houseBuilder;
        }

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