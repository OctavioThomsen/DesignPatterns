namespace DesignPatterns.AbstractFactory.Entities
{
    public class ModernTable : ATable
    {
        public string modelOfFurniture = "Modern";

        public override void PlaceOn()
        {
            Console.WriteLine($"You place the coffe on {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}
