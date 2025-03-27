namespace DesignPatterns.AbstractFactory.Entities
{
    internal class ArtDecoTable : ATable
    {
        private readonly string modelOfFurniture = "artDeco";

        public override void PlaceOn()
        {
            Console.WriteLine($"You place the coffe on {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}