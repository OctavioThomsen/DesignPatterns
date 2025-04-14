using DesignPatterns.Patterns.Builder.Directors;
using DesignPatterns.Patterns.Builder.Entities;

namespace DesignPatterns.Patterns.Builder.Services
{
    internal class HouseConstructionService
    {
        public Director _director;

        public HouseConstructionService(Director director)
        {
            _director = director;
        }

        public void BuildWalls(int quantity) => _director.HouseBuilder.BuildWalls(quantity);

        public void BuildDoors(int quantity) => _director.HouseBuilder.BuildDoors(quantity);

        public void BuildWindows(int quantity) => _director.HouseBuilder.BuildWindows(quantity);

        public void BuildRoof() => _director.HouseBuilder.BuildRoof();

        public void BuildGarage() => _director.HouseBuilder.BuildGarage();

        public void MakeStandardHouse() => _director.MakeStandardHouse();

        public void Reset() => _director.HouseBuilder.Reset();

        public AHouse GetHouse() => _director.HouseBuilder.GetResult();
    }
}