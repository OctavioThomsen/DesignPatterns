namespace DesignPatterns.AbstractFactory.Entities
{
    public class VictorianChair : AChair
    {
        public string modelOfFurniture = "Victorian";

        public override void SitOn()
        {
            Console.WriteLine($"You sit on the {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}
