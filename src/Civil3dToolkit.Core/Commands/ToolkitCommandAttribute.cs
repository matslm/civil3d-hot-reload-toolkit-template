namespace Civil3dToolkit.Core.Commands;

/// <summary>
/// Decorator for IToolkitCommand implementations to define their command name
/// and enable more robust runtime discovery.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class ToolkitCommandAttribute(string commandName) : Attribute
{
    public string CommandName { get; } = commandName;
}
