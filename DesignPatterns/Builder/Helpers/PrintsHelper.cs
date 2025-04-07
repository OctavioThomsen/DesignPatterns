using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Helpers
{
    internal class PrintsHelper
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

        public static void InvalidOption()
        {
            Console.WriteLine("Invalid option. Try again.");
            Console.WriteLine();
        }
    }
}
