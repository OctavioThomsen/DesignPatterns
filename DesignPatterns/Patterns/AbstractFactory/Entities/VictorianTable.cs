namespace DesignPatterns.Patterns.AbstractFactory.Entities
{
    internal class VictorianTable : ATable
    {
        private readonly string modelOfFurniture = "victorian";

        public override void PlaceOn()
        {
            Console.WriteLine($"You place the coffe on {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}