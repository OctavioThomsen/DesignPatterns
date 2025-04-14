using DesignPatterns.AbstractFactory;
using DesignPatterns.Patterns.Builder;
using DesignPatterns.Patterns.Factory;
using DesignPatterns.Patterns.Singleton;
using DesignPatterns.Shared.Helpers;
using DesignPatterns.Shared.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Services
{
    internal class PatternExecutorService
    {
        private readonly IServiceProvider _serviceProvider;

        public PatternExecutorService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void ExecutePattern(int patternChoice)
        {
            IPatternExecutor? patternExecutor = patternChoice switch
            {
                1 => _serviceProvider.GetRequiredService<AbstractFactoryExecutor>(),
                2 => _serviceProvider.GetRequiredService<BuilderExecutor>(),
                3 => _serviceProvider.GetRequiredService<FactoryExecutor>(),
                4 => _serviceProvider.GetRequiredService<SingletonExecutor>(),
                _ => ReturnNullWithMessage()
            };

            if (patternExecutor is null)
            {
                return;
            }

            patternExecutor.Execute();

            Console.Clear();
        }

        private static IPatternExecutor? ReturnNullWithMessage()
        {
            SharedPrintHelpers.InvalidOption();
            return null;
        }
    }
}