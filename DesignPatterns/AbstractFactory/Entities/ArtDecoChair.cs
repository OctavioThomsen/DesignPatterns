namespace DesignPatterns.AbstractFactory.Entities
{
    internal class ArtDecoChair : AChair
    {
        private readonly string modelOfFurniture = "artDeco";

        public override void SitOn()
        {
            Console.WriteLine($"You sit on the {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}