namespace Civil3dToolkit.Core.ViewModels;

using Civil3dToolkit.Core.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

/// <summary>
/// Implementation sample: The ViewModel for the main dashboard.
/// Demonstrates pure C# logic that interacts with AutoCAD via an interface.
/// </summary>
public partial class MainViewModel(ICivilService civilService) : ObservableObject
{
    [ObservableProperty]
    private string _greetingMessage = "Ready to automate Civil 3D!";

    [RelayCommand]
    private void ExecuteSampleAction()
    {
        // Execute the AutoCAD drawing logic via the interface
        bool success = civilService.DrawSquare(100.0, 100.0, 5.0);

        if (success)
        {
            GreetingMessage = $"Sample square successfully drawn at {DateTime.Now.ToShortTimeString()}";
            System.Windows.MessageBox.Show("Square drawn in Model Space!", "Success", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
        }
        else
        {
            GreetingMessage = "Failed to draw the square. Check AutoCAD console.";
        }
    }
}
