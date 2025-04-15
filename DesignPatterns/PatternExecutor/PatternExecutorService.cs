using DesignPatterns.PatternExecutor.Enums;
using DesignPatterns.PatternExecutor.Interfaces;
using DesignPatterns.Shared.Helpers;

namespace DesignPatterns.PatternExecutor
{
    internal class PatternExecutorService : IPatternExecutorService
    {
        private readonly IEnumerable<IPatternExecutor> _executors;

        public PatternExecutorService(IEnumerable<IPatternExecutor> executors)
        {
            _executors = executors;
        }

        public void ExecutePattern(int patternChoice)
        {
            var patternType = (PatternType)patternChoice;

            IPatternExecutor? executor = _executors.FirstOrDefault(e => e.PatternType == patternType);

            if (executor is null)
            {
                SharedPrintHelpers.InvalidOption();
                return;
            }

            executor.Execute();
        }
    }
}