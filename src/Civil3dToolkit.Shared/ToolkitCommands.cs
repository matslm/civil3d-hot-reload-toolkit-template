namespace Civil3dToolkit.Shared;

/// <summary>
/// Centralized registry of all command names to avoid "stringly-typed" discovery.
/// Used by both the Loader (for [CommandMethod]) and the Plugin (for routing).
/// </summary>
public static class ToolkitCommands
{
    public const string MainUi = "TK_MAIN_UI";
    public const string CustomBand = "TK_CUSTOMBAND";
    public const string DrawSquare = "TK_SQUARE";
    public const string Reload = "TK_RELOAD";
}
