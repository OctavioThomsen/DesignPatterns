using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Entities
{
    internal class ModernCouch : ACouch
    {
        public string modelOfFurniture = "Modern";

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
