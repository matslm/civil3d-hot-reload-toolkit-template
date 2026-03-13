namespace Civil3dToolkit.Core.Commands;

/// <summary>
/// Represents a discrete command that can be executed from Civil 3D.
/// Discovery is handled by the [ToolkitCommand] attribute.
/// </summary>
public interface IToolkitCommand
{
    /// <summary>
    /// The logic to execute when the command is called.
    /// </summary>
    void Execute();
}
