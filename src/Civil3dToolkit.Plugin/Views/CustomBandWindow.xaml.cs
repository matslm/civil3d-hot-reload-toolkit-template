namespace Civil3dToolkit.Plugin.Views;

using Civil3dToolkit.Core.ViewModels;

public partial class CustomBandWindow
{
    public CustomBandWindow(CustomBandViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
        viewModel.CloseAction = Close;
    }
}
