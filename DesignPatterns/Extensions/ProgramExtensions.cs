using DesignPatterns.ConsoleApp;
using DesignPatterns.ConsoleApp.Interfaces;
using DesignPatterns.PatternExecutor;
using DesignPatterns.PatternExecutor.Interfaces;
using DesignPatterns.PatternExecutor.Patterns;
using DesignPatterns.Patterns.Factory;
using DesignPatterns.Patterns.Singleton.Interfaces;
using DesignPatterns.Patterns.Singleton.Services;
using DesignPatterns.Patterns.Singleton.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Extensions
{
    internal static class ProgramExtensions
    {
        public static IServiceCollection AddProjectDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IDatabase>(provider => Database.GetInstance());

            services.AddTransient<IDatabaseExecutorService, DatabaseExecutorService>();

            services.AddTransient<IPatternExecutor, AbstractFactoryExecutor>();
            services.AddTransient<IPatternExecutor, BuilderExecutor>();
            services.AddTransient<IPatternExecutor, FactoryExecutor>();
            services.AddTransient<IPatternExecutor, SingletonExecutor>();

            services.AddTransient<IPatternExecutorService, PatternExecutorService>();
            services.AddTransient<IConsoleAppService, ConsoleAppService>();

            return services;
        }
    }
}