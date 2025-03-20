namespace DesignPatterns.AbstractFactory.Entities
{
    public class StandardPackage : APackage
    {
        public string message = "Delivering a standard package.";

        public override void Deliver()
        {
            PrintType();
            Console.WriteLine(message);
        }
    }
}
