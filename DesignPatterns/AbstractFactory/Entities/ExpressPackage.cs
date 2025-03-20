namespace DesignPatterns.AbstractFactory.Entities
{
    public class ExpressPackage : APackage
    {
        public string message = "Delivering a express package.";

        public override void Deliver()
        {
            PrintType();
            Console.WriteLine(message);
        }
    }
}
