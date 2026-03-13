namespace Civil3dToolkit.Plugin.Commands;

using Civil3dToolkit.Core.Commands;
using Civil3dToolkit.Plugin.Views;
using Civil3dToolkit.Shared;

[ToolkitCommand(ToolkitCommands.MainUi)]
internal class MainUiCommand(IServiceProvider serviceProvider) : IToolkitCommand
{
    public void Execute()
    {
        MainWindow mainWindow = serviceProvider.GetRequiredService<MainWindow>();
        Application.ShowModalWindow(mainWindow);
    }
}
