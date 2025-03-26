using DesignPatterns.Builder.Entities;
using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder.Builders
{
    public class WoodHouseBuilder : IHouseBuilder
    {
        private WoodHouse House = new("Wood");

        public void BuildDoors(int doors)
        {
            House.Doors += doors;
        }

        public void BuildGarage()
        {
            House.Garage = true;
        }

        public void BuildRoof()
        {
            House.Roof = true;
        }

        public void BuildWalls(int walls)
        {
            House.Walls += walls;
        }

        public void BuildWindows(int windows)
        {
            House.Windows += windows;
        }

        public void Reset()
        {
            House = new("Wood");
        }

        public AHouse GetResult()
        {
            return House;
        }
    }
}
