using DesignPatterns.Builder.Entities;
using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder.Builders
{
    internal class BrickHouseBuilder : IHouseBuilder
    {
        private BrickHouse House = new("Brick");

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

        public AHouse GetResult()
        {
            return House;
        }

        public void Reset()
        {
            House = new("Brick");
        }
    }
}