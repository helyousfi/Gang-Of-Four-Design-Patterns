using DependencyInjection.SimpleExample;
using Microsoft.Extensions.Configuration;

#region SimpleExample
/*
IMessageWriter writer = new ConsoleMessageWriter();
var salutation = new Salutation(writer);
salutation.Exclaim("Hello DI");*/
#endregion

#region SimpleExampleLateBinding
IConfigurationRoot configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

string? typeName = configuration["messageWriter"];
if (string.IsNullOrWhiteSpace(typeName))
{
    throw new InvalidOperationException("Configuration value 'messageWriter' is missing or empty.");
}

Type? type = Type.GetType(typeName);
if (type == null)
{
    throw new TypeLoadException($"The type '{typeName}' could not be loaded. Make sure the assembly and namespace are correct.");
}

object? instance = Activator.CreateInstance(type);
if (instance is not IMessageWriter writer)
{
    throw new InvalidCastException($"The created instance of type '{typeName}' does not implement IMessageWriter.");
}

var salutation = new Salutation(writer);
salutation.Exclaim("Hello DI");
#endregion