namespace Civil3dToolkit.Loader;

using Civil3dToolkit.Shared;

/// <summary>
/// Acts as a proxy router. It registers AutoCAD commands and delegates their 
/// execution to the dynamically loaded core plugin assembly.
/// This assembly remains permanent in AutoCAD memory.
/// </summary>
public class MainLoader : IExtensionApplication
{
    private static PluginLoadContext? _currentContext;
    private static Assembly? _pluginAssembly;
    private static IPluginBootstrapper? _bootstrapper;
    
    private const string PluginDllName = "Civil3dToolkit.Plugin.dll";

    public void Initialize()
    {
        var editor = Application.DocumentManager.MdiActiveDocument.Editor;
        editor.WriteMessage("\n>>> Toolkit Loader Initialized. Type 'TK_RELOAD' to fetch the latest code.\n");
        
        // Autoload the plugin into memory when Civil 3D starts
        ReloadPlugin(); 
    }

    public void Terminate() => UnloadCurrentContext();

    /// <summary>
    /// Hot-reload command. Fetches the latest compiled DLL into the memory context.
    /// </summary>
    [CommandMethod(ToolkitCommands.Reload)]
    public void ReloadPlugin()
    {
        var editor = Application.DocumentManager.MdiActiveDocument.Editor;
        try
        {
            string loaderLocation = Assembly.GetExecutingAssembly().Location;
            string? pluginDirectory = Path.GetDirectoryName(loaderLocation);
            
            if (pluginDirectory == null)
            {
                editor.WriteMessage("\n[ERROR] Could not determine plugin directory.\n");
                return;
            }

            string dllPath = Path.Combine(pluginDirectory, PluginDllName);

            if (!File.Exists(dllPath)) 
            {
                editor.WriteMessage($"\n[ERROR] Core plugin not found at: {dllPath}\n");
                return;
            }

            UnloadCurrentContext();
            _currentContext = new PluginLoadContext(pluginDirectory);

            byte[] dllBytes = File.ReadAllBytes(dllPath);
            
            using (var dllStream = new MemoryStream(dllBytes))
            {
                _pluginAssembly = _currentContext.LoadFromStream(dllStream);
            }

            // Locate and initialize the bootstrapper
            Type? bootstrapperType = _pluginAssembly.GetTypes().FirstOrDefault(t => typeof(IPluginBootstrapper).IsAssignableFrom(t) && t is { IsInterface: false, IsAbstract: false });
            
            if (bootstrapperType != null)
            {
                _bootstrapper = (IPluginBootstrapper?)Activator.CreateInstance(bootstrapperType);
                _bootstrapper?.Initialize();
                editor.WriteMessage($"\n>>> [SUCCESS] Core plugin reloaded into memory and initialized! (Command {ToolkitCommands.Reload} successful)\n");
            }
            else
            {
                editor.WriteMessage("\n[ERROR] IPluginBootstrapper implementation not found in the loaded assembly.\n");
            }
        }
        catch (System.Exception ex)
        {
            editor.WriteMessage($"\n[LOADER ERROR]: {ex.Message}\n");
        }
    }

    /// <summary>
    /// Routes the execution to the type-safe IPluginBootstrapper interface.
    /// </summary>
    private void RouteCommandToPlugin(string commandName)
    {
        var editor = Application.DocumentManager.MdiActiveDocument.Editor;
        
        if (_bootstrapper == null)
        {
            editor.WriteMessage($"\n[ERROR] Plugin not loaded or bootstrapper not found. Run {ToolkitCommands.Reload} first.\n");
            return;
        }

        try
        {
            _bootstrapper.ExecuteCommand(commandName);
        }
        catch (System.Exception ex)
        {
            editor.WriteMessage($"\n[EXECUTION ERROR]: {ex.InnerException?.Message ?? ex.Message}\n");
        }
    }

    private void UnloadCurrentContext()
    {
        if (_currentContext == null) return;
        try 
        {
            _bootstrapper?.Terminate();
        }
        catch 
        { 
            /* Ignore errors during teardown */ 
        }
            
        _bootstrapper = null;
        _currentContext.Unload();
        _currentContext = null;
        _pluginAssembly = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    // =====================================================================
    // NATIVE CIVIL 3D COMMANDS (The Proxy Endpoints)
    // =====================================================================

    [CommandMethod(ToolkitCommands.MainUi)]
    public void ShowMainUi() => RouteCommandToPlugin(ToolkitCommands.MainUi);

    [CommandMethod(ToolkitCommands.CustomBand)]
    public void DrawCustomBand() => RouteCommandToPlugin(ToolkitCommands.CustomBand);
    
    [CommandMethod(ToolkitCommands.DrawSquare)]
    public void DrawSquareCommand() => RouteCommandToPlugin(ToolkitCommands.DrawSquare);
}
