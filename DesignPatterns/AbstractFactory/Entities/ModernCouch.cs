namespace DesignPatterns.AbstractFactory.Entities
{
    internal class ModernCouch : ACouch
    {
        private readonly string modelOfFurniture = "modern";

        public override void SitOn()
        {
            Console.WriteLine($"You sit on the {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}