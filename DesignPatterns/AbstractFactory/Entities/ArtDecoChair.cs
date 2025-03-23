namespace DesignPatterns.AbstractFactory.Entities
{
    public class ArtDecoChair : AChair
    {
        public string modelOfFurniture = "ArtDeco";

        public override void SitOn()
        {
            Console.WriteLine($"You sit on the {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}
