namespace Civil3dToolkit.Plugin.Views;

using Civil3dToolkit.Core.ViewModels;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    /// <summary>
    /// Constructor with dependency injection. 
    /// The DI container automatically provides the MainViewModel instance.
    /// </summary>
    /// <param name="viewModel">The view model for this window.</param>
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        
        // Bind the injected view model to the UI
        DataContext = viewModel;
    }
}
