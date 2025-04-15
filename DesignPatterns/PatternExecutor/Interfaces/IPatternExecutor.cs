using DesignPatterns.PatternExecutor.Enums;

namespace DesignPatterns.PatternExecutor.Interfaces
{
    internal interface IPatternExecutor
    {
        PatternType PatternType { get; }
        void Execute();
    }
}