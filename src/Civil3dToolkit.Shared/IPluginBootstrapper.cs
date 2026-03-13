namespace Civil3dToolkit.Shared;

/// <summary>
/// Stable interface for communication between the Loader (default context) 
/// and the Plugin (hot-reloaded context). 
/// Prevents brittle string-based reflection.
/// </summary>
public interface IPluginBootstrapper
{
    /// <summary>
    /// Called once when the plugin assembly is loaded.
    /// </summary>
    void Initialize();

    /// <summary>
    /// Called to route a command execution from AutoCAD to the plugin logic.
    /// </summary>
    /// <param name="commandName">The name of the command to execute.</param>
    void ExecuteCommand(string commandName);

    /// <summary>
    /// Called before the plugin assembly is unloaded during hot-reload.
    /// Use this to close WPF windows, unhook events, and dispose services.
    /// </summary>
    void Terminate();
}
