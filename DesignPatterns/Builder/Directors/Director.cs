using DesignPatterns.Builder.Entities;
using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder.Directors
{
    public class Director
    {
        public IHouseBuilder HouseBuilder { get; set; }

        public Director(IHouseBuilder houseBuilder)
        {
            HouseBuilder = houseBuilder;
        }

        public void MakeStandarHouse()
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
