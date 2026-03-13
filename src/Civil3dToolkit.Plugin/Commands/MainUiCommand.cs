namespace Civil3dToolkit.Plugin.Commands;

using Civil3dToolkit.Core.Commands;
using Civil3dToolkit.Plugin.Views;

internal class MainUiCommand(IServiceProvider serviceProvider) : IToolkitCommand
{
    public string CommandName => "TK_MAIN_UI";

    public void Execute()
    {
        MainWindow mainWindow = serviceProvider.GetRequiredService<MainWindow>();
        Application.ShowModalWindow(mainWindow);
    }
}
