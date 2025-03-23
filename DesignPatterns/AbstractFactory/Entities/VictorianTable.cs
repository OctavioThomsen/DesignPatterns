namespace DesignPatterns.AbstractFactory.Entities
{
    public class VictorianTable : ATable
    {
        public string modelOfFurniture = "Victorian";

        public override void PlaceOn()
        {
            Console.WriteLine($"You place the coffe on {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}
