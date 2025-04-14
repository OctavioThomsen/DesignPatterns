
namespace DesignPatterns.Patterns.Builder.Helpers
{
    internal class BuilderPrintsHelper
    {
        public static void BuilderTypeSelector()
        {
            Console.WriteLine("Select a builder type:");
            Console.WriteLine("1 - Brick");
            Console.WriteLine("2 - Stone");
            Console.WriteLine("3 - Wood");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }

        public static void WhatToBuildSelector()
        {
            Console.WriteLine("Select what to build:");
            Console.WriteLine("1 - Walls");
            Console.WriteLine("2 - Doors");
            Console.WriteLine("3 - Windows");
            Console.WriteLine("4 - Roof");
            Console.WriteLine("5 - Garage");
            Console.WriteLine("6 - Create a standard house");
            Console.WriteLine("7 - Show the house");
            Console.WriteLine("8 - Reset house");
            Console.WriteLine("9 - Exit");
            Console.WriteLine();
        }

        internal static void PatternDesignTittle()
        {
            Console.WriteLine("BUILDER METHOD.");
            Console.WriteLine();
        }
    }
}