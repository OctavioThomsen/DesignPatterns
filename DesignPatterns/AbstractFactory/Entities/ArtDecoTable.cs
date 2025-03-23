namespace DesignPatterns.AbstractFactory.Entities
{
    internal class ArtDecoTable : ATable
    {
        public string modelOfFurniture = "ArtDeco";

        public override void PlaceOn()
        {
            Console.WriteLine($"You place the coffe on {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}
