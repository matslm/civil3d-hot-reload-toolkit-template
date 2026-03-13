namespace Civil3dToolkit.Core.Interfaces;

/// <summary>
/// Abstraction for user interactions to keep Core project pure and testable.
/// Prevents dependencies on WPF (MessageBox) or AutoCAD (Editor) in ViewModels.
/// </summary>
public interface IUserMessageService
{
    /// <summary>
    /// Displays an informational message to the user.
    /// </summary>
    void ShowInfo(string title, string message);

    /// <summary>
    /// Displays an error message to the user.
    /// </summary>
    void ShowError(string title, string message, Exception? ex = null);

    /// <summary>
    /// Displays a warning message to the user.
    /// </summary>
    void ShowWarning(string title, string message);
}
