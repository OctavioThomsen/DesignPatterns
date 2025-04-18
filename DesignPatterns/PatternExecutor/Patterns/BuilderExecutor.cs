﻿using DesignPatterns.PatternExecutor.Enums;
using DesignPatterns.PatternExecutor.Interfaces;
using DesignPatterns.Patterns.Builder.Helpers;
using DesignPatterns.Patterns.Builder.Services;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.PatternExecutor.Patterns
{
    internal class BuilderExecutor : IPatternExecutor
    {
        public PatternType PatternType => PatternType.Builder;

        public void Execute()
        {
            int directorChoice = -1;

            BuilderPrintsHelper.PatternDesignTittle();

            while (directorChoice != 9)
            {
                BuilderPrintsHelper.BuilderTypeSelector();

                if (int.TryParse(Console.ReadLine(), out directorChoice))
                {
                    HouseConstructionService? houseConstructionService = BuilderExecutorService.Execute(directorChoice);

                    if (houseConstructionService != null)
                    {
                        Console.WriteLine();
                        BuildMenuService.Start(houseConstructionService);
                    }
                }
                else
                {
                    SharedPrintHelpers.InvalidOption();
                }
            }
        }
    }
}