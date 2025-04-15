using DesignPatterns.ConsoleApp.Interfaces;
using DesignPatterns.Extensions;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddProjectDependencies();
var serviceProvider = services.BuildServiceProvider();

var app = serviceProvider.GetRequiredService<IConsoleAppService>();

app.Run();