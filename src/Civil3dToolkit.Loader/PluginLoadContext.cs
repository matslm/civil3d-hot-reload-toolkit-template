namespace Civil3dToolkit.Loader;

using System.Runtime.Loader;

/// <summary>
/// Custom AssemblyLoadContext that resolves NuGet dependencies from the plugin directory.
/// </summary>
public class PluginLoadContext(string pluginDirectory) : AssemblyLoadContext(isCollectible: true)
{
    protected override Assembly? Load(AssemblyName assemblyName)
    {
        // CRITICAL: Ensure the Shared assembly is resolved by the Default context.
        // If we load it here, the types won't match the ones in the Loader.
        if (assemblyName.Name == "Civil3dToolkit.Shared")
        {
            return null; 
        }

        // 1. Look for the requested DLL (e.g., CommunityToolkit.Mvvm.dll) in the output folder
        string assemblyPath = Path.Combine(pluginDirectory, $"{assemblyName.Name}.dll");

        // 2. If not found locally (like AutoCAD native DLLs), return null.
        // This forces the default context to resolve Autodesk dependencies.
        if (!File.Exists(assemblyPath)) return null;
        
        // 3. Read as bytes to prevent locking the dependency files during development
        byte[] assemblyBytes = File.ReadAllBytes(assemblyPath);
        using var stream = new MemoryStream(assemblyBytes);
        return LoadFromStream(stream);
    }
}
