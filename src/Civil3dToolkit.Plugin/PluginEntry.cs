namespace Civil3dToolkit.Plugin;

using Civil3dToolkit.Core.Commands;
using Civil3dToolkit.Core.Interfaces;
using Civil3dToolkit.Shared;

/// <summary>
/// The entry point for routed commands. 
/// Implements IPluginBootstrapper to provide type-safe communication with the Loader.
/// </summary>
public class PluginEntry : IPluginBootstrapper
{
    public void Initialize()
    {
        // Initialize DI when the plugin is loaded into memory
        DiContainer.Initialize();
    }

    public void Terminate()
    {
        // Handle cleanup before hot-reload unloads the assembly.
        System.Windows.Application.Current?.Dispatcher.Invoke(() =>
        {
            foreach (Window window in System.Windows.Application.Current.Windows.Cast<Window>().ToList())
            {
                window.Close();
            }
        });
    }

    public void ExecuteCommand(string commandName)
    {
        if (DiContainer.Services == null) return;

        try
        {
            // Discovery Pattern: Find the command that matches the name passed from the Loader
            IEnumerable<IToolkitCommand> commands = DiContainer.Services.GetServices<IToolkitCommand>();
            IToolkitCommand? targetCommand = commands.FirstOrDefault(c => c.CommandName == commandName);

            if (targetCommand != null)
            {
                targetCommand.Execute();
            }
            else
            {
                IUserInteractionService? ui = DiContainer.Services.GetService<IUserInteractionService>();
                ui?.WriteMessage($"Command '{commandName}' not recognized by the Plugin.");
            }
        }
        catch (Exception ex)
        {
            IUserInteractionService? ui = DiContainer.Services.GetService<IUserInteractionService>();
            ui?.WriteMessage($"[EXECUTION ERROR]: {ex.Message}");
        }
    }
}
