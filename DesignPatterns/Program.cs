using DesignPatterns.Extensions;
using DesignPatterns.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddProjectDependencies();
var serviceProvider = services.BuildServiceProvider();

var app = serviceProvider.GetRequiredService<IConsoleAppService>();

app.Run();