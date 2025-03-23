namespace DesignPatterns.AbstractFactory.Entities
{
    public class ModernChair : AChair
    {
        public string modelOfFurniture = "Modern";

        public override void SitOn()
        {
            Console.WriteLine($"You sit on the {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}
