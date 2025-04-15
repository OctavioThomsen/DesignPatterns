using DesignPatterns.Shared.Enums;

namespace DesignPatterns.Shared.Interfaces
{
    internal interface IPatternExecutor
    {
        PatternType PatternType { get; }
        void Execute();
    }
}