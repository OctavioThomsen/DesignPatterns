namespace DesignPatterns.Patterns.AbstractFactory.Entities
{
    internal class VictorianChair : AChair
    {
        private readonly string modelOfFurniture = "victorian";

        public override void SitOn()
        {
            Console.WriteLine($"You sit on the {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}