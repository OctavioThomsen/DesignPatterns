namespace DesignPatterns.AbstractFactory.Helpers
{
    internal static class AbstractFactoryPrintsHelper
    {
        public static void ChairActionSelector()
        {
            Console.WriteLine("Chair actions:");
            Console.WriteLine("1 - Sit on");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }

        public static void CouchActionSelector()
        {
            Console.WriteLine("Couch actions:");
            Console.WriteLine("1 - Lie down");
            Console.WriteLine("2 - Sit on");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }

        public static void FurnitureSelector()
        {
            Console.WriteLine("Select a furniture:");
            Console.WriteLine("1 - Couch");
            Console.WriteLine("2 - Chair");
            Console.WriteLine("3 - Table");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }

        public static void ModelSelector()
        {
            Console.WriteLine("Select a model:");
            Console.WriteLine("1 - ArtDeco");
            Console.WriteLine("2 - Modern");
            Console.WriteLine("3 - Victorian");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }

        public static void TableActionSelector()
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine("1 - Place on");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }
    }
}