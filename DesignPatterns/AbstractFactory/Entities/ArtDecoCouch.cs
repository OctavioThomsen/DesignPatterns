namespace DesignPatterns.AbstractFactory.Entities
{
    public class ArtDecoCouch : ACouch
    {
        public string modelOfFurniture = "ArtDeco";

        public override void LieDown()
        {
            Console.WriteLine($"You lie down on the {modelOfFurniture} {typeOfFurniture}.");
        }

        public override void SitOn()
        {
            Console.WriteLine($"You sit on the {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}
