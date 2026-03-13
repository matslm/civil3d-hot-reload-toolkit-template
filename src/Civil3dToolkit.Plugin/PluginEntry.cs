namespace Civil3dToolkit.Plugin;

using System.Reflection;
using Civil3dToolkit.Core.Commands;
using Civil3dToolkit.Core.Interfaces;
using Civil3dToolkit.Shared;

/// <summary>
/// The entry point for routed commands. 
/// Implements IPluginBootstrapper to provide type-safe communication with the Loader.
/// </summary>
public class PluginEntry : IPluginBootstrapper
{
    private IServiceProvider? _serviceProvider;
    private readonly Dictionary<string, IToolkitCommand> _commandMap = new(StringComparer.OrdinalIgnoreCase);

    public void Initialize()
    {
        // 1. Build the DI container when the plugin is loaded into memory
        _serviceProvider = DiContainer.Build();

        // 2. Precompute the command map to avoid reflection per execution
        IEnumerable<IToolkitCommand> commands = _serviceProvider.GetServices<IToolkitCommand>();
        List<string> missingAttributes = [];
        foreach (IToolkitCommand command in commands)
        {
            var attr = command.GetType().GetCustomAttribute<ToolkitCommandAttribute>();
            if (attr != null)
            {
                // Validate for duplicates at startup
                if (_commandMap.ContainsKey(attr.CommandName))
                {
                    throw new InvalidOperationException($"Duplicate command registration found for name: {attr.CommandName}");
                }
                _commandMap[attr.CommandName] = command;
            }
            else
            {
                missingAttributes.Add(command.GetType().Name);
            }
        }

        if (missingAttributes.Count > 0)
        {
            IUserInteractionService? ui = _serviceProvider.GetService<IUserInteractionService>();
            string missing = string.Join(", ", missingAttributes);
            ui?.WriteMessage($"\n[WARN] Commands missing [ToolkitCommand]: {missing}");
        }
    }

    public void Terminate()
    {
        // 1. Close all open WPF windows
        System.Windows.Application.Current?.Dispatcher.Invoke(() =>
        {
            foreach (Window window in System.Windows.Application.Current.Windows.Cast<Window>().ToList())
            {
                window.Close();
            }
        });

        // 2. Dispose of the DI container to trigger cleanup of singleton services
        if (_serviceProvider is IDisposable disposable)
        {
            disposable.Dispose();
        }
        _serviceProvider = null;
        _commandMap.Clear();
    }

    public void ExecuteCommand(string commandName)
    {
        if (_serviceProvider == null) return;

        try
        {
            // Use the precomputed map for fast, reliable discovery
            if (_commandMap.TryGetValue(commandName, out IToolkitCommand? targetCommand))
            {
                targetCommand.Execute();
            }
            else
            {
                IUserInteractionService? ui = _serviceProvider.GetService<IUserInteractionService>();
                ui?.WriteMessage($"\n[ERROR] Command '{commandName}' not recognized by the Plugin.");
            }
        }
        catch (Exception ex)
        {
            IUserInteractionService? ui = _serviceProvider.GetService<IUserInteractionService>();
            ui?.WriteMessage($"\n[EXECUTION ERROR]: {ex.Message}");
        }
    }
}
