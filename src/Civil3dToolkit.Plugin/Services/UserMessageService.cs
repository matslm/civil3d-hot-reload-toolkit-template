namespace Civil3dToolkit.Plugin.Services;

using Civil3dToolkit.Core.Interfaces;
using System.Windows;

/// <summary>
/// Plugin-level implementation of IUserMessageService using WPF MessageBox.
/// Implementation is internal to maintain encapsulation within the UI layer.
/// </summary>
internal class UserMessageService : IUserMessageService
{
    public void ShowInfo(string title, string message)
    {
        MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
    }

    public void ShowError(string title, string message, Exception? ex = null)
    {
        string fullMessage = ex != null ? $"{message}\n\nDetails: {ex.Message}" : message;
        MessageBox.Show(fullMessage, title, MessageBoxButton.OK, MessageBoxImage.Error);
    }

    public void ShowWarning(string title, string message)
    {
        MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Warning);
    }
}
