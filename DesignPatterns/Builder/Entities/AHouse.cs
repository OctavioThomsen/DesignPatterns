namespace DesignPatterns.Builder.Entities
{
    public abstract class AHouse(string material)
    {
        public string Material = material;
        public int Walls { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int Windows { get; set; } = 0;
        public bool Roof { get; set; } = false;
        public bool Garage { get; set; } = false;
    }
}
