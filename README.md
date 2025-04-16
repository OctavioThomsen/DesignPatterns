# Design Patterns in C# (.NET 8)

This project is a console application developed in C# using .NET 8 that implements some of the **most widely used design patterns** in software development.  
The goal is to demonstrate clean, consistent implementations that are **aligned with SOLID principles**, with a simple, decoupled, and scalable architecture.

---

## Implemented Patterns

- Abstract Factory  
- Builder  
- Factory Method  
- Singleton  

Each pattern is implemented independently, following its core logic and design intent without sharing logic between them.

---

## Application Structure

The solution is organized by responsibility, following clean architecture and best practices:

- /ConsoleApp → Main logic of the console app (entry from Program.cs) 
- /Extensions → Service configuration (DI) and extension methods 
- /PatternExecutor → Responsible for invoking the selected pattern (generic service) 
- /Patterns → Individual implementations for each pattern 
- /Shared → Shared helpers and utilities 
- Program.cs → Entry point, delegates control to the ConsoleApp layer

---

## Execution Flow

1. **`Program.cs`**  
   The application's entry point. It configures dependency injection and delegates control to the `ConsoleAppService`.

2. **`ConsoleAppService`**  
   Displays the interactive menu to the user and captures their input.

3. **`PatternExecutorService`**  
   Resolves the selected pattern using the dependency container, without relying on concrete classes.

4. **Each Pattern (Abstract Factory, Builder, etc.)**  
   Has its own folder, executor service, and internal classes.  
   No logic is shared between patterns to keep them fully decoupled.

---

## Dependency Injection

The project uses **Microsoft.Extensions.DependencyInjection** to register and manage services through interfaces.

Example configuration:

```csharp
services.AddTransient<IConsoleAppService, ConsoleAppService>();
services.AddTransient<IPatternExecutorService, PatternExecutorService>();
services.AddTransient<IPatternExecutor, BuilderExecutor>();
// etc.
```

This allows for:

- Easy replacement of implementations
- Full compliance with the Dependency Inversion Principle (D from SOLID)
- Simplified testing and maintenance

Best Practices Applied
- Interface-based dependency injection
- Clear separation of concerns
- Clean, expressive code
- Modular organization per pattern
- Console logic fully decoupled from pattern implementations
- Scalable architecture (easy to add new patterns)
