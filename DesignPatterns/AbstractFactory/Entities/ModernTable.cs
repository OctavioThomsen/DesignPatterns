﻿namespace DesignPatterns.AbstractFactory.Entities
{
    internal class ModernTable : ATable
    {
        private readonly string modelOfFurniture = "modern";

        public override void PlaceOn()
        {
            Console.WriteLine($"You place the coffe on {modelOfFurniture} {typeOfFurniture}.");
        }
    }
}