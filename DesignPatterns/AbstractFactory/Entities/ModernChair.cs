namespace DesignPatterns.AbstractFactory.Entities
{
    internal class ModernChair : AChair
    {
        private readonly string modelOfFurniture = "modern";

        public override void SitOn()
        {
            Console.WriteLine($"You sit on the {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}