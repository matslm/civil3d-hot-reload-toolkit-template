namespace Civil3dToolkit.Plugin;

using Civil3dToolkit.Core.Commands;
using Civil3dToolkit.Core.Interfaces;
using Civil3dToolkit.Core.ViewModels;
using Civil3dToolkit.Infrastructure.Commands;
using Civil3dToolkit.Infrastructure.Services;
using Civil3dToolkit.Infrastructure.Transactions;
using Civil3dToolkit.Plugin.Commands;
using Civil3dToolkit.Plugin.Views;

/// <summary>
/// Bootstrapper for the Dependency Injection container.
/// Manages the registration and resolution of Views, ViewModels, and Services.
/// </summary>
public static class DiContainer
{
    public static IServiceProvider? Services { get; private set; }

    /// <summary>
    /// Configures all the dependencies required by the application.
    /// </summary>
    public static void Initialize()
    {
        ServiceCollection services = new();

        // ==========================================
        // 1. Register Infrastructure Services
        // ==========================================
        services.AddSingleton<ICivilService, CivilServiceImpl>();
        services.AddSingleton<IUserInteractionService, AutoCadInteractionService>();
        services.AddSingleton<ITransactionService, TransactionService>();

        // ==========================================
        // 2. Register Plugin Commands (CQRS-style)
        // ==========================================
        // Presentation Commands (UI-dependent)
        services.AddTransient<IToolkitCommand, MainUiCommand>();
        services.AddTransient<IToolkitCommand, CustomBandCommand>();

        // Infrastructure Commands (CAD-dependent)
        services.AddTransient<IToolkitCommand, DrawSquareCommand>();

        // ==========================================
        // 3. Register ViewModels (MVVM)
        // ==========================================
        services.AddTransient<MainViewModel>();
        services.AddTransient<CustomBandViewModel>();

        // ==========================================
        // 4. Register Views (WPF Windows)
        // ==========================================
        services.AddTransient<MainWindow>();
        services.AddTransient<CustomBandWindow>();

        // Build the service provider
        Services = services.BuildServiceProvider();
    }
}
