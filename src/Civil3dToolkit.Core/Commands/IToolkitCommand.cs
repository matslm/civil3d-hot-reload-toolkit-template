namespace Civil3dToolkit.Core.Commands;

/// <summary>
/// Represents a discrete command that can be executed from Civil 3D.
/// Used to eliminate the large switch-case in PluginEntry.
/// </summary>
public interface IToolkitCommand
{
    /// <summary>
    /// The exact string name of the command as registered in the Loader (e.g., "TK_SQUARE").
    /// </summary>
    string CommandName { get; }

    /// <summary>
    /// The logic to execute when the command is called.
    /// </summary>
    void Execute();
}
