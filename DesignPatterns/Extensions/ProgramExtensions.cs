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
            services.AddSingleton<IDatabase, Database>(provider => Database.GetInstance());
            services.AddTransient<IDatabaseExecutorService, DatabaseExecutorService>();

            return services;
        }
    }
}